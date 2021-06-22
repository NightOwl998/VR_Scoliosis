using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showtextforevo : MonoBehaviour
{
    private bool showText = false;
    private bool hover = false;
    public GUIStyle style;
    public Text nameText;
    public Text dialogueText;
    private string NameHover;
    //public Texture textureToDisplay;
    //public Font myFont;
    private void Start()
    {        //showText = false;


        //   if (gameObject.GetComponentt(typeof(Collider)) as Collider) == null)
        //gameObject.AddComponent(typeof(BoxCollider));
    }
    public void OnMouseDown()
    {
        showText = true;

    }
    public void OnGUI()
    {
        //GUI.Label(new Rect(1050, 0, 100, 30), "Avant", style);
        //GUI.Label(new Rect(1500, 0, 100, 30), "Apres", style);
        if (showText)
        {
            showText = false;


            switch (gameObject.tag)
            {
                case "Sacrum":

                    nameText.text = "Sacrum ";
                    dialogueText.text = " Le sacrum est un os pair, médian et symétrique, composé de la soudure des cinq vertèbres sacrées. Il possède une forme pyramidale inversée qui lui permet de se positionner dans le bassin pour le fermer. Sa face supérieure est appelée le promontoire sacré, sa face inférieure l'apex." + "\n" +
                  "Vue sa position anatomique en regard des organes sexuels, le sacrum subit un dimorphisme sexuel. Chez la femme, le sacrum est plus court mais plus large que chez l'homme. ";
                    break;

                case "C1":

                    nameText.text = "Atlas ( C1 )";
                    dialogueText.text = "L'atlas est la première vertèbre cervicale (C1). L'atlas agit comme un ménisque osseux, intercalé entre le crâne et le rachis.Elle ne possède pas de corps vertébral mais seulement deux masses latérales unies par un arc ventral et un arc dorsal.Les masses latérales présentent chacune deux processus articulaires :la fovéa crâniale(cavité glénoïde) qui reçoit le condyle de l'os occipital,la fovéa caudale qui s'articule avec le processus articulaire crânial de C2.Sur leur face médiale, les masses latérales portent le tubercule du ligament transverse. Le ligament transverse est tendu entre les tubercules droit et gauche.Latéralement à ces masses latérales, se trouvent les foramens alaires(équivalent des foramens transversaires), délimités par les deux racines des processus transverses. Ils laissent passer l'artère vertébrale, qui se coude à sa sortie du foramen en haut.L'arc ventral présente sur sa face ventrale le tubercule ventral qui donne insertion à des muscles et sur sa face dorsale, la fovéa dentis qui reçoit le processus odontoïde de l'axis.L'arc dorsal présente sur sa face dorsale le tubercule dorsal qui donne insertion à des muscles et sur sa face supérieure le sillon de l'artère vertébrale(cette dernière cheminant dans le canal transversaire).";
                    break;

                case "C2":
                    nameText.text = "Axis ( C2 )";
                    dialogueText.text = "L'axis est la deuxième vertèbre cervicale (C2)." + "\n" +
                    "Description" + "\n" + "Corps vertébral:Identique par sa face inférieure à celui des autres vertèbres cervicales, il possède sur sa face supérieure une particularité : le processus odontoïde (ou dent de l'axis), de forme pyramidale."
                    + "\n" + "Processus odontoïde:Le processus odontoïde (ou apophyse odontoïde) est situé à la partie supérieure du corps et donne articulation à l'atlas. Il possède un col, zone de constriction à l'endroit où il rejoint le corps de C2."
                    + "\n" + "Arc neural: Les pédicules, très courts, se prolongent par des lames dont le bord inférieur est incurvé. Le processus épineux (union médiane des deux lames) est court et bituberculé. Les processus transverses, à l'union des pédicules et des lames, sont percés d'un foramen transversaire, comme ceux des autres vertèbres cervicales. Le foramen vertébral est de forme triangulaire à base antérieure.";
                    break;
                case "C3":
                    nameText.text = "C3";
                    dialogueText.text = "C3 fait partie des  vertèbres cervicales qui sont localisées au niveau du cou, entre le crâne et la première vertèbre thoracique. Elles forment le rachis cervical." + "\n" +
                "Les vertèbres cervicales sont au nombre de sept(C1 à C7). Les deux premières vertèbres(l'atlas, C1 et l'axis, C2) présentent des formes particulières, notamment un foramen vertébral triangulaire." + "\n" +
                 "Les vertèbres cervicales permettent les mouvements de la tête:" + "\n" +

                    "l'inclinaison (l'oreille se rapproche de l'épaule) ;" + "\n" +
                     "la flexion(menton sur poitrine);" + "\n" +
                    "l'extension (le mouvement inverse) ;" + "\n" +
                      "la rotation(le menton se rapproche de l'épaule)." + "\n";
                    break;
                case "C4":
                    nameText.text = "C4";
                    dialogueText.text = "C4 fait partie des  vertèbres cervicales qui sont localisées au niveau du cou, entre le crâne et la première vertèbre thoracique. Elles forment le rachis cervical." + "\n" +
                "Les vertèbres cervicales sont au nombre de sept(C1 à C7). Les deux premières vertèbres(l'atlas, C1 et l'axis, C2) présentent des formes particulières, notamment un foramen vertébral triangulaire." + "\n" +
                 "Les vertèbres cervicales permettent les mouvements de la tête:" + "\n" +

                    "l'inclinaison (l'oreille se rapproche de l'épaule) ;" + "\n" +
                     "la flexion(menton sur poitrine);" + "\n" +
                    "l'extension (le mouvement inverse) ;" + "\n" +
                      "la rotation(le menton se rapproche de l'épaule)." + "\n";
                    break;
                case "C5":
                    nameText.text = "C5";
                    dialogueText.text = "C5 fait partie des  vertèbres cervicales qui sont localisées au niveau du cou, entre le crâne et la première vertèbre thoracique. Elles forment le rachis cervical." + "\n" +
                "Les vertèbres cervicales sont au nombre de sept(C1 à C7). Les deux premières vertèbres(l'atlas, C1 et l'axis, C2) présentent des formes particulières, notamment un foramen vertébral triangulaire." + "\n" +
                 "Les vertèbres cervicales permettent les mouvements de la tête:" + "\n" +

                    "l'inclinaison (l'oreille se rapproche de l'épaule) ;" + "\n" +
                     "la flexion(menton sur poitrine);" + "\n" +
                    "l'extension (le mouvement inverse) ;" + "\n" +
                      "la rotation(le menton se rapproche de l'épaule)." + "\n";
                    break;
                case "C6":
                    nameText.text = "C6";
                    dialogueText.text = "C6 fait partie des  vertèbres cervicales qui sont localisées au niveau du cou, entre le crâne et la première vertèbre thoracique. Elles forment le rachis cervical." + "\n" +
                "Les vertèbres cervicales sont au nombre de sept(C1 à C7). Les deux premières vertèbres(l'atlas, C1 et l'axis, C2) présentent des formes particulières, notamment un foramen vertébral triangulaire." + "\n" +
                 "Les vertèbres cervicales permettent les mouvements de la tête:" + "\n" +

                    "l'inclinaison (l'oreille se rapproche de l'épaule) ;" + "\n" +
                     "la flexion(menton sur poitrine);" + "\n" +
                    "l'extension (le mouvement inverse) ;" + "\n" +
                      "la rotation(le menton se rapproche de l'épaule)." + "\n";
                    break;
                case "C7":
                    nameText.text = "C7";
                    dialogueText.text = "C7 fait partie des  vertèbres cervicales qui sont localisées au niveau du cou, entre le crâne et la première vertèbre thoracique. Elles forment le rachis cervical." + "\n" +
                "Les vertèbres cervicales sont au nombre de sept(C1 à C7). Les deux premières vertèbres(l'atlas, C1 et l'axis, C2) présentent des formes particulières, notamment un foramen vertébral triangulaire." + "\n" +
                 "Les vertèbres cervicales permettent les mouvements de la tête:" + "\n" +

                    "l'inclinaison (l'oreille se rapproche de l'épaule) ;" + "\n" +
                     "la flexion(menton sur poitrine);" + "\n" +
                    "l'extension (le mouvement inverse) ;" + "\n" +
                      "la rotation(le menton se rapproche de l'épaule)." + "\n";
                    break;
                case "T1":
                    nameText.text = "T1";
                    dialogueText.text = "T1 fait partie des  vertèbres thoraciques (dorsales) forment le haut du dos." + "/n" +
                   "Les vertèbres thoraciques sont localisées au niveau du haut du dos, entre la dernière vertèbre cervicale et la première vertèbre lombaire. Elles forment le rachis thoracique, qui supporte les côtes. Elles servent de support aux côtes. Les articulations des vertèbres thoraciques sont limitées, limitant également les mouvements de la région du corps associee";
                    break;
                case "T2":
                    nameText.text = "T2";
                    dialogueText.text = "T2 fait partie des  vertèbres thoraciques (dorsales) forment le haut du dos." + "/n" +
                   "Les vertèbres thoraciques sont localisées au niveau du haut du dos, entre la dernière vertèbre cervicale et la première vertèbre lombaire. Elles forment le rachis thoracique, qui supporte les côtes. Elles servent de support aux côtes. Les articulations des vertèbres thoraciques sont limitées, limitant également les mouvements de la région du corps associee";
                    break;
                case "T3":
                    nameText.text = "T3";
                    dialogueText.text = "T3 fait partie des  vertèbres thoraciques (dorsales) forment le haut du dos." + "/n" +
                   "Les vertèbres thoraciques sont localisées au niveau du haut du dos, entre la dernière vertèbre cervicale et la première vertèbre lombaire. Elles forment le rachis thoracique, qui supporte les côtes. Elles servent de support aux côtes. Les articulations des vertèbres thoraciques sont limitées, limitant également les mouvements de la région du corps associee";
                    break;
                case "T4":
                    nameText.text = "T4";
                    dialogueText.text = "T4 fait partie des  vertèbres thoraciques (dorsales) forment le haut du dos." + "/n" +
                   "Les vertèbres thoraciques sont localisées au niveau du haut du dos, entre la dernière vertèbre cervicale et la première vertèbre lombaire. Elles forment le rachis thoracique, qui supporte les côtes. Elles servent de support aux côtes. Les articulations des vertèbres thoraciques sont limitées, limitant également les mouvements de la région du corps associee";
                    break;
                case "T5":
                    nameText.text = "T5";
                    dialogueText.text = "T5 fait partie des  vertèbres thoraciques (dorsales) forment le haut du dos." + "/n" +
                   "Les vertèbres thoraciques sont localisées au niveau du haut du dos, entre la dernière vertèbre cervicale et la première vertèbre lombaire. Elles forment le rachis thoracique, qui supporte les côtes. Elles servent de support aux côtes. Les articulations des vertèbres thoraciques sont limitées, limitant également les mouvements de la région du corps associee";
                    break;
                case "T6":
                    nameText.text = "T6";
                    dialogueText.text = "T6 fait partie des  vertèbres thoraciques (dorsales) forment le haut du dos." + "/n" +
                   "Les vertèbres thoraciques sont localisées au niveau du haut du dos, entre la dernière vertèbre cervicale et la première vertèbre lombaire. Elles forment le rachis thoracique, qui supporte les côtes. Elles servent de support aux côtes. Les articulations des vertèbres thoraciques sont limitées, limitant également les mouvements de la région du corps associee";
                    break;
                case "T7":
                    nameText.text = "T7";
                    dialogueText.text = "T7 fait partie des  vertèbres thoraciques (dorsales) forment le haut du dos." + "/n" +
                   "Les vertèbres thoraciques sont localisées au niveau du haut du dos, entre la dernière vertèbre cervicale et la première vertèbre lombaire. Elles forment le rachis thoracique, qui supporte les côtes. Elles servent de support aux côtes. Les articulations des vertèbres thoraciques sont limitées, limitant également les mouvements de la région du corps associee";
                    break;
                case "T8":
                    nameText.text = "T8";
                    dialogueText.text = "T8 fait partie des  vertèbres thoraciques (dorsales) forment le haut du dos." + "/n" +
                   "Les vertèbres thoraciques sont localisées au niveau du haut du dos, entre la dernière vertèbre cervicale et la première vertèbre lombaire. Elles forment le rachis thoracique, qui supporte les côtes. Elles servent de support aux côtes. Les articulations des vertèbres thoraciques sont limitées, limitant également les mouvements de la région du corps associee";
                    break;
                case "T9":
                    nameText.text = "T9";
                    dialogueText.text = "T9 fait partie des  vertèbres thoraciques (dorsales) forment le haut du dos." + "/n" +
                   "Les vertèbres thoraciques sont localisées au niveau du haut du dos, entre la dernière vertèbre cervicale et la première vertèbre lombaire. Elles forment le rachis thoracique, qui supporte les côtes. Elles servent de support aux côtes. Les articulations des vertèbres thoraciques sont limitées, limitant également les mouvements de la région du corps associee";
                    break;
                case "T10":
                    nameText.text = "T10";
                    dialogueText.text = "T10 fait partie des  vertèbres thoraciques (dorsales) forment le haut du dos." + "/n" +
                   "Les vertèbres thoraciques sont localisées au niveau du haut du dos, entre la dernière vertèbre cervicale et la première vertèbre lombaire. Elles forment le rachis thoracique, qui supporte les côtes. Elles servent de support aux côtes. Les articulations des vertèbres thoraciques sont limitées, limitant également les mouvements de la région du corps associee";
                    break;
                case "T11":
                    nameText.text = "T11";
                    dialogueText.text = "T11 fait partie des  vertèbres thoraciques (dorsales) forment le haut du dos." + "/n" +
                   "Les vertèbres thoraciques sont localisées au niveau du haut du dos, entre la dernière vertèbre cervicale et la première vertèbre lombaire. Elles forment le rachis thoracique, qui supporte les côtes. Elles servent de support aux côtes. Les articulations des vertèbres thoraciques sont limitées, limitant également les mouvements de la région du corps associee";
                    break;
                case "T12":
                    nameText.text = "T12";
                    dialogueText.text = "T12 fait partie des  vertèbres thoraciques (dorsales) forment le haut du dos." + "/n" +
                   "Les vertèbres thoraciques sont localisées au niveau du haut du dos, entre la dernière vertèbre cervicale et la première vertèbre lombaire. Elles forment le rachis thoracique, qui supporte les côtes. Elles servent de support aux côtes. Les articulations des vertèbres thoraciques sont limitées, limitant également les mouvements de la région du corps associee";
                    break;
                case "L1":
                    nameText.text = "L1";
                    dialogueText.text = "L1 fait partie des vertèbres lombaires sont situées au bas du dos."
         + "\n" + " Les vertèbres lombaires sont localisées au niveau du bas du dos, entre la dernière vertèbre thoracique et le sacrum. Elles forment le rachis lombaire." +
                "/n Les vertèbres lombaires sont les vertèbres les plus robustes car elles supportent le poids de tout le haut du corps.";
                    break;
                case "L2":
                    nameText.text = "L2";
                    dialogueText.text = "L2 fait partie des vertèbres lombaires sont situées au bas du dos."
         + "\n" + " Les vertèbres lombaires sont localisées au niveau du bas du dos, entre la dernière vertèbre thoracique et le sacrum. Elles forment le rachis lombaire." +
                "/n Les vertèbres lombaires sont les vertèbres les plus robustes car elles supportent le poids de tout le haut du corps.";
                    break;
                case "L3":
                    nameText.text = "L3";
                    dialogueText.text = "L3 fait partie des vertèbres lombaires sont situées au bas du dos."
         + "\n" + " Les vertèbres lombaires sont localisées au niveau du bas du dos, entre la dernière vertèbre thoracique et le sacrum. Elles forment le rachis lombaire." +
                "/n Les vertèbres lombaires sont les vertèbres les plus robustes car elles supportent le poids de tout le haut du corps.";
                    break;
                case "L4":
                    nameText.text = "L4";
                    dialogueText.text = "L4 fait partie des vertèbres lombaires sont situées au bas du dos."
         + "\n" + " Les vertèbres lombaires sont localisées au niveau du bas du dos, entre la dernière vertèbre thoracique et le sacrum. Elles forment le rachis lombaire." +
                "/n Les vertèbres lombaires sont les vertèbres les plus robustes car elles supportent le poids de tout le haut du corps.";
                    break;
                case "L5":
                    nameText.text = "L5";
                    dialogueText.text = "L5 fait partie des vertèbres lombaires sont situées au bas du dos."
         + "\n" + " Les vertèbres lombaires sont localisées au niveau du bas du dos, entre la dernière vertèbre thoracique et le sacrum. Elles forment le rachis lombaire." +
                "/n Les vertèbres lombaires sont les vertèbres les plus robustes car elles supportent le poids de tout le haut du corps.";
                    break;

                default:
                    dialogueText.text = "No Name";
                    break;


            }
        }

        if (hover)
        {
            switch (gameObject.tag)
            {

                case "Sacrum":



                    NameHover = "Sacrum";
                    break;



                case "C1":


                    NameHover = "C1";
                    break;
                case "C2":

                    NameHover = "C2";
                    break;
                case "C3":

                    NameHover = "C3";
                    break;
                case "C4":

                    NameHover = "C4";
                    break;
                case "C5":

                    NameHover = "C5";
                    break;
                case "C6":

                    NameHover = "C6";
                    break;
                case "C7":

                    NameHover = "C7";
                    break;
                case "T1":

                    NameHover = "T1";
                    break;
                case "T2":

                    NameHover = "T2";
                    break;
                case "T3":

                    NameHover = "T3";
                    break;
                case "T4":

                    NameHover = "T4";
                    break;
                case "T5":

                    NameHover = "T5";
                    break;
                case "T6":

                    NameHover = "T6";
                    break;
                case "T7":

                    NameHover = "T7";
                    break;
                case "T8":

                    NameHover = "T8";
                    break;
                case "T9":

                    NameHover = "T9";
                    break;
                case "T10":

                    NameHover = "T10";
                    break;
                case "T11":

                    NameHover = "T11";
                    break;
                case "T12":

                    NameHover = "T12";
                    break;
                case "L1":

                    NameHover = "L1";
                    break;
                case "L2":

                    NameHover = "L2";
                    break;
                case "L3":

                    NameHover = "L3";
                    break;
                case "L4":

                    NameHover = "L4";
                    break;
                case "L5":

                    NameHover = "L5";
                    break;







            }
            GUI.Label(new Rect(Input.mousePosition.x + 80, Screen.height - Input.mousePosition.y, 100, 30), NameHover, style);
        }

    }
    void OnMouseOver()
    {
        hover = true;


    }
    void OnMouseExit()
    {
        hover = false;
    }
    private void Update()
    {



    }





}

