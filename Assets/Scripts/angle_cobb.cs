using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;


public class angle_cobb : MonoBehaviour
{
    public GameObject ourObject;
    public int Poids = 0;
    private float width = 0.1f;
    private static int poid1, poid2;
    private static string vertebre1, vertebre2;
    private bool afficher = false;

    //   ---------------------------------------------------

    public LineRenderer lineRendererTop;
    public LineRenderer lineRendererBottom;
    private static LineRenderer line1, line2, line3, line4;
    private static LineRenderer lineT, lineB, lineM, lineD;
    public static Vector3 intersectPoint;
    private static bool Choisie = false;
    private static bool Choisie1 = false;
    private static bool Choisie2 = false;
    public GUIStyle style;
    private static Vector3 debut1, debut2, fin1, fin2, milieu1, milieu2, fin3, fin4 ;
    private static float angleCobb;
    public Activer instance;
    

    // Start is called before the first frame update
    void Start()
    {

        lineRendererBottom.startWidth = 0.0f;
        lineRendererBottom.endWidth = 0.0f;
        lineRendererTop.startWidth = 0.0f;
        lineRendererTop.endWidth = 0.0f;
        lineRendererTop.positionCount = 3;
        lineRendererBottom.positionCount = 3;
        lineM = (new GameObject("line")).AddComponent<LineRenderer>();
        lineD = (new GameObject("line")).AddComponent<LineRenderer>();
        lineM.positionCount = 3;
        lineD.positionCount = 3;
    }

    


    public void OnMouseDown()
    {
        bool selected = instance.ClickedButton();

        if (selected == true )
        {
            

            if (Choisie1 == false)
            {
                line1 = lineRendererTop;
                line2 = lineRendererBottom;
                poid1 = Poids;
                Choisie1 = true;

                Object[] tab = new Object[30];
                tab = FindObjectsOfType<LineRenderer>();
                foreach (LineRenderer i in tab)
                {
                    i.SetPosition(2, i.GetPosition(1));
                    i.startWidth = 0.0f;
                    i.endWidth = 0.0f;
                }


                vertebre1 = ourObject.tag;
                lineM.startWidth = 0.0f;
                lineM.endWidth = 0.0f;
                lineD.startWidth = 0.0f;
                lineD.endWidth = 0.0f;

            }
            else
            {
                if (Choisie1 == true & Choisie2 == false)
                {
                    line3 = lineRendererTop;
                    line4 = lineRendererBottom;
                    poid2 = Poids;
                    Choisie2 = true;
                    vertebre2 = ourObject.tag;
                }
            }
            if (Choisie1 == true & Choisie2 == true)
            {
                Choisie = true;
                if (poid1 < poid2)
                {
                    lineB = line4;
                    lineT = line1;
                }
                else
                {
                    lineB = line3;
                    lineT = line2;
                }

                instance.Desactiver();
            }
        }
        
        


    }



    public void OnGUI()
    {
        float distance1, distance2, distance3,distance4,coeff;
        bool Cas1, Cas2;
        
        if (Choisie == true)
        {
            debut1 = lineT.GetPosition(0);
            fin1 = lineT.GetPosition(1);
            debut2 = lineB.GetPosition(0);
            fin2 = lineB.GetPosition(1);
            if (IsIntersecting())
            {}
            if(angleCobb < 3.0f)
            {
                coeff = 0.1f;
            }
            else
            {
                coeff = 0.22f;
            }
            afficher = true;
            if (Vector3.Distance(fin1, intersectPoint) > Vector3.Distance(debut1, intersectPoint))
            {
                milieu1 = Vector3.Lerp(debut1, intersectPoint, coeff);
                Cas1 = false;
            }
            else
            {
                milieu1 = Vector3.Lerp(fin1, intersectPoint,coeff);
                Cas1 = true;
            }
            if (Vector3.Distance(fin2, intersectPoint) > Vector3.Distance(debut2, intersectPoint))
            {
                milieu2 = Vector3.Lerp(debut2, intersectPoint, coeff);
                Cas2 = false;
            }
            else 
            { 
                milieu2 = Vector3.Lerp(fin2, intersectPoint, coeff);
                Cas2 = true;
            }

             if(Cas1 == true) 
            {
                fin4 = GetPositionOnSegment(fin1, intersectPoint, milieu2);
                distance1 = Vector3.Distance(fin1, milieu1);
                distance2 = Vector3.Distance(fin1, fin4);
            }
             else 
            {
                fin4 = GetPositionOnSegment(debut1, intersectPoint, milieu2);
                distance1 = Vector3.Distance(debut1, milieu1);
                distance2 = Vector3.Distance(debut1, fin4);
            }
            if (Cas2 == true)
            {
                fin3 = GetPositionOnSegment(fin2, intersectPoint, milieu1);
                distance3 = Vector3.Distance(fin2, milieu2);
                distance4 = Vector3.Distance(fin2, fin3);
            }
            else
            {
                fin3 = GetPositionOnSegment(debut2, intersectPoint, milieu1);
                distance3 = Vector3.Distance(debut2, milieu2);
                distance4 = Vector3.Distance(debut2, fin3);
            }




            
            if (distance1 > distance2)
            {
                lineT.SetPosition(2, milieu1);
            }
            else
            {
                lineT.SetPosition(2, fin4);
            }

            
            if (distance3 > distance4)
            {
                lineB.SetPosition(2, milieu2);
            }
            else
            {
                lineB.SetPosition(2, fin3);
            }
            lineM.SetPosition(0,milieu1);
            lineM.SetPosition(1,fin3);
            lineM.SetPosition(2, fin3);
            lineD.SetPosition(0, milieu2);
            lineD.SetPosition(1, fin4);
            lineD.SetPosition(2, fin4);
            lineT.startWidth = width;
            lineT.endWidth = width;
            lineB.startWidth = width;
            lineB.endWidth = width;
            lineM.startWidth = width;
            lineM.endWidth = width;
            lineD.startWidth = width;
            lineD.endWidth = width;

            Choisie = false;
            Choisie1 = false;
            Choisie2 = false;
            
        }

        if(afficher)
        {
            GUI.Label(new Rect(400, 50, 500, 30), "L'angle Cobb entre "+ vertebre1 + " et "+vertebre2 + " est de : "+ angleCobb, style);
            style.normal.textColor = Color.black;

            style.fontSize = 17;
        } 


    }

        bool IsIntersecting()
        {
            bool isIntersecting = false;

            //print("on est dans intersection");

            //3d -> 2d
            print(debut1.ToString());
            Vector2 l1_start = new Vector2(debut1.x, debut1.y);
            Vector2 l1_end = new Vector2(fin1.x, fin1.y);

            Vector2 l2_start = new Vector2(debut2.x, debut2.y);
            Vector2 l2_end = new Vector2(fin2.x, fin2.y);

            //Direction of the lines
            Vector2 l1_dir = (l1_end - l1_start).normalized;
            Vector2 l2_dir = (l2_end - l2_start).normalized;

            //If we know the direction we can get the normal vector to each line
            Vector2 l1_normal = new Vector2(-l1_dir.y, l1_dir.x);
            Vector2 l2_normal = new Vector2(-l2_dir.y, l2_dir.x);


            //Step 1: Rewrite the lines to a general form: Ax + By = k1 and Cx + Dy = k2
            //The normal vector is the A, B
            float A = l1_normal.x;
            float B = l1_normal.y;

            float C = l2_normal.x;
            float D = l2_normal.y;

            //To get k we just use one point on the line
            float k1 = (A * l1_start.x) + (B * l1_start.y);
            float k2 = (C * l2_start.x) + (D * l2_start.y);


            //Step 2: are the lines parallel? -> no solutions
            if (IsParallel(l1_normal, l2_normal))
            {
                print("The lines are parallel so no solutions!");

                return isIntersecting;
            }


            //Step 3: are the lines the same line? -> infinite amount of solutions
            //Pick one point on each line and test if the vector between the points is orthogonal to one of the normals
            if (IsOrthogonal(l1_start - l2_start, l1_normal))
            {
                print("Same line so infinite amount of solutions!");

                //Return false anyway
                return isIntersecting;
            }


            //Step 4: calculate the intersection point -> one solution
            float x_intersect = (D * k1 - B * k2) / (A * D - B * C);
            float y_intersect = (-C * k1 + A * k2) / (A * D - B * C);

            intersectPoint = new Vector3(x_intersect, y_intersect, 0);
            Vector2 intersecPoint = new Vector2(x_intersect, y_intersect);
            angleCobb = Vector2.Angle(l1_start - intersecPoint, l2_start - intersecPoint);
           

            return isIntersecting;
        }

        //Are 2 vectors parallel?
        bool IsParallel(Vector2 v1, Vector2 v2)
        {
            //2 vectors are parallel if the angle between the vectors are 0 or 180 degrees
            if (Vector2.Angle(v1, v2) == 0f || Vector2.Angle(v1, v2) == 180f)
            {
                return true;
            }

            return false;
        }

        //Are 2 vectors orthogonal?
        bool IsOrthogonal(Vector2 v1, Vector2 v2)
        {
            //2 vectors are orthogonal is the dot product is 0
            //We have to check if close to 0 because of floating numbers
            if (Mathf.Abs(Vector2.Dot(v1, v2)) < 0.000001f)
            {
                return true;
            }

            return false;
        }

        //Is a point c between 2 other points a and b?
        bool IsBetween(Vector2 a, Vector2 b, Vector2 c)
        {
            bool isBetween = false;

            //Entire line segment
            Vector2 ab = b - a;
            //The intersection and the first point
            Vector2 ac = c - a;

            //Need to check 2 things: 
            //1. If the vectors are pointing in the same direction = if the dot product is positive
            //2. If the length of the vector between the intersection and the first point is smaller than the entire line
            if (Vector2.Dot(ab, ac) > 0f && ab.sqrMagnitude >= ac.sqrMagnitude)
            {
                isBetween = true;
            }

            return isBetween;
        }

    public Vector3 GetPositionOnSegment(Vector3 A, Vector3 B, Vector3 point)
    {
        Vector3 projection = Vector3.Project(point - A, B - A);
        return projection + A;
    }
}


