using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScore : MonoBehaviour
{
    public GameObject panelImage;
    public AudioSource achSound;
    public bool isActivated = false;
    public GameObject achTitle;
    public GameObject achDes;

    // Ach Settings 
    public GameObject achImage;
    public int timertrigger = 15;
    public static int TimerCount;
    public int timerCode;

    // Ach1 Settings
    public int timertrigger1 = 60;
    public static int TimerCount1;
    public int timerCode1;

    //Ach2 Settings
    public int timertrigger2 = 120;
    public static int TimerCount2;
    public int timerCode2;

    //Ach3 Settings
    public int timertrigger3 = 180;
    public static int TimerCount3;
    public int timerCode3;

    //Ach4 Settings
    public int timertrigger4 = 240;
    public static int TimerCount4;
    public int timerCode4;

    //Ach5 Settings
    public int timertrigger5 = 300;
    public static int TimerCount5;
    public int timerCode5;

    //Ach6 Settings
    public int timertrigger6 = 360;
    public static int TimerCount6;
    public int timerCode6;

    //Ach7 Settings
    public int timertrigger7 = 420;
    public static int TimerCount7;
    public int timerCode7;

    //Ach8 Settings
    public int timertrigger8 = 480;
    public static int TimerCount8;
    public int timerCode8;

    //Ach9 Settings
    public int timertrigger9 = 540;
    public static int TimerCount9;
    public int timerCode9;

    //Ach10 Settings
    public int timertrigger10 = 600;
    public static int TimerCount10;
    public int timerCode10;

    private void Awake()
    {
        //PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        //TimerScore PlayerPrefs
        timerCode = PlayerPrefs.GetInt("Timer1");
        timerCode1 = PlayerPrefs.GetInt("Timer2");
        timerCode2 = PlayerPrefs.GetInt("Timer3");
        timerCode3 = PlayerPrefs.GetInt("Timer4");
        timerCode4 = PlayerPrefs.GetInt("Timer5");
        timerCode5 = PlayerPrefs.GetInt("Timer6");
        timerCode6 = PlayerPrefs.GetInt("Timer7");
        timerCode7 = PlayerPrefs.GetInt("Timer8");
        timerCode8 = PlayerPrefs.GetInt("Timer9");
        timerCode9 = PlayerPrefs.GetInt("Timer10");
        timerCode10 = PlayerPrefs.GetInt("Timer11");

        //LockedImage PlayerPrefs
        LockedImages.timer = PlayerPrefs.GetInt("Time");
        LockedImages.timer1 = PlayerPrefs.GetInt("Time1");
        LockedImages.timer2 = PlayerPrefs.GetInt("Time2");
        LockedImages.timer3 = PlayerPrefs.GetInt("Time3");
        LockedImages.timer4 = PlayerPrefs.GetInt("Time4");
        LockedImages.timer5 = PlayerPrefs.GetInt("Time5");
        LockedImages.timer6 = PlayerPrefs.GetInt("Time6");
        LockedImages.timer7 = PlayerPrefs.GetInt("Time7");
        LockedImages.timer8 = PlayerPrefs.GetInt("Time8");
        LockedImages.timer9 = PlayerPrefs.GetInt("Time9");
        LockedImages.timer10 = PlayerPrefs.GetInt("Time10");

        if (TimerCount == timertrigger && timerCode != 15)
        {
            StartCoroutine(Timer1());
        }
        if(TimerCount1 == timertrigger1 && timerCode1 != 60)
        {
           StartCoroutine(Timer2());
        }
        if(TimerCount2 == timertrigger2 && timerCode2 != 120)
        {
           StartCoroutine(Timer3());
        }
        if(TimerCount3 == timertrigger3 && timerCode3 != 180)
        {
           StartCoroutine(Timer4());
        }
        if (TimerCount4 == timertrigger4 && timerCode4 != 240)
        {
           StartCoroutine(Timer5());
        }
        if (TimerCount5 == timertrigger5 && timerCode5 != 300)
        {
           StartCoroutine(Timer6());
        }
        if (TimerCount6 == timertrigger6 && timerCode6 != 360)
        {
            StartCoroutine(Timer7());
        }
        if (TimerCount7 == timertrigger7 && timerCode7 != 420)
        {
            StartCoroutine(Timer8());
        }
        if (TimerCount8 == timertrigger8 && timerCode8 != 480)
        {
            StartCoroutine(Timer9());
        }
        if (TimerCount9 == timertrigger9 && timerCode9 != 540)
        {
            StartCoroutine(Timer10());
        }
        if (TimerCount10 == timertrigger10 && timerCode10 != 600)
        {
            StartCoroutine(Timer11());
        }

        IEnumerator Timer1()
        {
            isActivated = true;
            timerCode = 15;
            PlayerPrefs.SetInt("Timer1", timerCode);
            PlayerPrefs.SetInt("Time", 1);
            achSound.Play();
            achImage.SetActive(true);
            achTitle.GetComponent<Text>().text = "Time";
            achDes.GetComponent<Text>().text = "You lasted for 15 second!";
            panelImage.SetActive(true);

            yield return new WaitForSeconds(4);

            achImage.SetActive(false);
            panelImage.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDes.GetComponent<Text>().text = "";
            isActivated = false;

        }
        IEnumerator Timer2()
        {
            isActivated = true;
            timerCode1 = 60;
            PlayerPrefs.SetInt("Timer2", timerCode1);
            PlayerPrefs.SetInt("Time1", 1);
            achSound.Play();
            achImage.SetActive(true);
            achTitle.GetComponent<Text>().text = "Time";
            achDes.GetComponent<Text>().text = "You lasted for 1 minute!";
            panelImage.SetActive(true);

            yield return new WaitForSeconds(4);

            achImage.SetActive(false);
            panelImage.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDes.GetComponent<Text>().text = "";
            isActivated = false;
        }
        IEnumerator Timer3()
        {
            isActivated = true;
            timerCode2 = 120;
            PlayerPrefs.SetInt("Timer3", timerCode2);
            PlayerPrefs.SetInt("Time2", 1);
            achSound.Play();
            achImage.SetActive(true);
            achTitle.GetComponent<Text>().text = "Time";
            achDes.GetComponent<Text>().text = "You lasted for 2 minutes!";
            panelImage.SetActive(true);

            yield return new WaitForSeconds(4);

            achImage.SetActive(false);
            panelImage.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDes.GetComponent<Text>().text = "";
            isActivated = false;
        }
        IEnumerator Timer4()
        {
            isActivated = true;
            timerCode3 = 180;
            PlayerPrefs.SetInt("Timer4", timerCode3);
            PlayerPrefs.SetInt("Time3", 1);
            achSound.Play();
            achImage.SetActive(true);
            achTitle.GetComponent<Text>().text = "Time";
            achDes.GetComponent<Text>().text = "You lasted for 3 minutes!";
            panelImage.SetActive(true);

            yield return new WaitForSeconds(4);

            achImage.SetActive(false);
            panelImage.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDes.GetComponent<Text>().text = "";
            isActivated = false;
        }
        IEnumerator Timer5()
        {
            isActivated = true;
            timerCode4 = 240;
            PlayerPrefs.SetInt("Timer5", timerCode4);
            PlayerPrefs.SetInt("Time4", 1);
            achSound.Play();
            achImage.SetActive(true);
            achTitle.GetComponent<Text>().text = "Time";
            achDes.GetComponent<Text>().text = "You lasted for 4 minutes!";
            panelImage.SetActive(true);

            yield return new WaitForSeconds(4);

            achImage.SetActive(false);
            panelImage.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDes.GetComponent<Text>().text = "";
            isActivated = false;
        }
        IEnumerator Timer6()
        {
            isActivated = true;
            timerCode5 = 300;
            PlayerPrefs.SetInt("Timer6", timerCode5);
            PlayerPrefs.SetInt("Time5", 1);
            achSound.Play();
            achImage.SetActive(true);
            achTitle.GetComponent<Text>().text = "Time";
            achDes.GetComponent<Text>().text = "You lasted for 5 minutes!";
            panelImage.SetActive(true);

            yield return new WaitForSeconds(4);

            achImage.SetActive(false);
            panelImage.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDes.GetComponent<Text>().text = "";
            isActivated = false;
        }
        IEnumerator Timer7()
        {
            isActivated = true;
            timerCode6 = 360;
            PlayerPrefs.SetInt("Timer7", timerCode6);
            PlayerPrefs.SetInt("Time6", 1);
            achSound.Play();
            achImage.SetActive(true);
            achTitle.GetComponent<Text>().text = "Time";
            achDes.GetComponent<Text>().text = "You lasted for 6 minutes!";
            panelImage.SetActive(true);

            yield return new WaitForSeconds(4);

            achImage.SetActive(false);
            panelImage.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDes.GetComponent<Text>().text = "";
            isActivated = false;
        }
        IEnumerator Timer8()
        {
            isActivated = true;
            timerCode7 = 420;
            PlayerPrefs.SetInt("Timer8", timerCode7);
            PlayerPrefs.SetInt("Time7", 1);
            achSound.Play();
            achImage.SetActive(true);
            achTitle.GetComponent<Text>().text = "Time";
            achDes.GetComponent<Text>().text = "You lasted for 7 minutes!";
            panelImage.SetActive(true);

            yield return new WaitForSeconds(4);

            achImage.SetActive(false);
            panelImage.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDes.GetComponent<Text>().text = "";
            isActivated = false;
        }
        IEnumerator Timer9()
        {
            isActivated = true;
            timerCode8 = 480;
            PlayerPrefs.SetInt("Timer9", timerCode8);
            PlayerPrefs.SetInt("Time8", 1);
            achSound.Play();
            achImage.SetActive(true);
            achTitle.GetComponent<Text>().text = "Time";
            achDes.GetComponent<Text>().text = "You lasted for 8 minutes!";
            panelImage.SetActive(true);

            yield return new WaitForSeconds(4);

            achImage.SetActive(false);
            panelImage.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDes.GetComponent<Text>().text = "";
            isActivated = false;
        }
        IEnumerator Timer10()
        {
            isActivated = true;
            timerCode9 = 540;
            PlayerPrefs.SetInt("Timer10", timerCode9);
            PlayerPrefs.SetInt("Time9", 1);
            achSound.Play();
            achImage.SetActive(true);
            achTitle.GetComponent<Text>().text = "Time";
            achDes.GetComponent<Text>().text = "You lasted for 9 minutes!";
            panelImage.SetActive(true);

            yield return new WaitForSeconds(4);

            achImage.SetActive(false);
            panelImage.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDes.GetComponent<Text>().text = "";
            isActivated = false;
        }
        IEnumerator Timer11()
        {
            isActivated = true;
            timerCode10 = 600;
            PlayerPrefs.SetInt("Timer11", timerCode10);
            PlayerPrefs.SetInt("Time10", 1);
            achSound.Play();
            achImage.SetActive(true);
            achTitle.GetComponent<Text>().text = "Time";
            achDes.GetComponent<Text>().text = "You lasted for 10 minutes!";
            panelImage.SetActive(true);

            yield return new WaitForSeconds(4);

            achImage.SetActive(false);
            panelImage.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDes.GetComponent<Text>().text = "";
            isActivated = false;

            yield return new WaitForSeconds(4);

            isActivated = true;
            achSound.Play();
            achTitle.GetComponent<Text>().text = "Congrats";
            achDes.GetComponent<Text>().text = "You unlocked something in the main menu!";
            panelImage.SetActive(true);

            yield return new WaitForSeconds(4);

            panelImage.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDes.GetComponent<Text>().text = "";
            isActivated = false;
        }
    }
}
