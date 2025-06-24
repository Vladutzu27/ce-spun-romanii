using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialScript : MonoBehaviour
{
    public TextMeshProUGUI tutorialText;
    public int clipNumber;

    public static TutorialScript instance;

    
    void Awake()
    {
        clipNumber = 1;
        instance = this;
    }

    public void NextClip()
    {
        if (clipNumber == 1)
        {
            //VideoScript.instance.ChangeVideoClip(VideoScript.instance.clip2);
            VideoScript.instance.ChangeVideoClip("ICSURI.webm");
            clipNumber++;
            tutorialText.text = "Pentru a afișa X-uri, apăsați pe [X], [C], [V] pentru unul, două respectiv 3 X-uri.";
        } 
        else
        {
            if (clipNumber == 2)
            {
                //VideoScript.instance.ChangeVideoClip(VideoScript.instance.clip3);
                VideoScript.instance.ChangeVideoClip("Scorethingy.webm");
                clipNumber++;
                tutorialText.text = "Scorul se va adăuga automat când cineva ghicește un răspuns de pe panou. Când o echipă câștigă runda, declarați câștigătorul folosind [A] pentru stânga sau [D] pentru dreapta și de-abia după afișați restul răspunsurilor de pe panou.";
            }
            else
            {
                if (clipNumber == 3)
                {
                    //VideoScript.instance.ChangeVideoClip(VideoScript.instance.clip4);
                    VideoScript.instance.ChangeVideoClip("urmatoarea.webm");
                    clipNumber++;
                    tutorialText.text = "Pentru a trece la următoarea rundă, apăsați tasta dreapta.";
                }
                else
                {
                    if (clipNumber == 4)
                    {
                        //VideoScript.instance.ChangeVideoClip(VideoScript.instance.clip5);
                        VideoScript.instance.ChangeVideoClip("Buzzer.webm");
                        clipNumber++;
                        tutorialText.text = "Pentru a alege aleator dintre echipe, apăsați B.";
                    }
                    else
                    {
                        if (clipNumber == 5)
                        {
                            //VideoScript.instance.ChangeVideoClip(VideoScript.instance.clip6);
                            VideoScript.instance.ChangeVideoClip("Multiplier.webm");
                            clipNumber++;
                            tutorialText.text = "Rotind rotița mouse-ului, puteți schimba muliplicatorul scorului, dublându-l sau triplându-l. Acesta este resetat la următoarea întrebare.";
                        }
                        else
                        {
                            if (clipNumber == 6)
                            {
                                //VideoScript.instance.ChangeVideoClip(VideoScript.instance.clip1);
                                VideoScript.instance.ChangeVideoClip("tabla_1.webm");
                                clipNumber = 1;
                                tutorialText.text = "Pentru a afișa un răspuns, apăsați pe numărul corespunzător răspunsului.";
                            }
                        }
                    }
                }
            }
        }
    }

    public void PreviousClip()
    {
        if (clipNumber == 1)
        {
            VideoScript.instance.ChangeVideoClip("Multiplier.webm");
            clipNumber = 6;
            tutorialText.text = "Rotind rotița mouse-ului, puteți schimba muliplicatorul scorului, dublându-l sau triplându-l. Acesta este resetat la următoarea întrebare.";
        }
        else
        {
            if (clipNumber == 2)
            {
                VideoScript.instance.ChangeVideoClip("tabla_1.webm");
                clipNumber--;
                tutorialText.text = "Pentru a afișa un răspuns, apăsați pe numărul corespunzător răspunsului.";
            }
            else
            {
                if (clipNumber == 3)
                {
                    VideoScript.instance.ChangeVideoClip("ICSURI.webm");
                    clipNumber--;
                    tutorialText.text = "Pentru a afișa X-uri, apăsați pe [X], [C], [V] pentru unul, două respectiv 3 X-uri.";
                }
                else
                {
                    if (clipNumber == 4)
                    {
                        VideoScript.instance.ChangeVideoClip("Scorethingy.webm");
                        clipNumber--;
                        tutorialText.text = "Scorul se va adăuga automat când cineva ghicește un răspuns de pe panou. Când o echipă câștigă runda, declarați câștigătorul folosind [A] pentru stânga sau [D] pentru dreapta și de-abia după afișați restul răspunsurilor de pe panou.";
                    }
                    else
                    {
                        if (clipNumber == 5)
                        {
                            VideoScript.instance.ChangeVideoClip("urmatoarea.webm");
                            clipNumber--;
                            tutorialText.text = "Pentru a trece la următoarea rundă, apăsați tasta dreapta.";
                        }
                        else
                        {
                            if (clipNumber == 6)
                            {
                                VideoScript.instance.ChangeVideoClip("Buzzer.webm");
                                clipNumber--;
                                tutorialText.text = "Pentru a alege aleator dintre echipe, apăsați B.";
                            }
                        }
                    }
                }
            }
        }
    }
}
