using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedImages : MonoBehaviour
{
    public GameObject image;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public GameObject image6;
    public GameObject image7;
    public GameObject image8;
    public GameObject image9;
    public GameObject image10;

    public static int timer = 0;
    public static int timer1 = 0;
    public static int timer2 = 0;
    public static int timer3 = 0;
    public static int timer4 = 0;
    public static int timer5 = 0;
    public static int timer6 = 0;
    public static int timer7 = 0;
    public static int timer8 = 0;
    public static int timer9 = 0;
    public static int timer10 = 0;

    public TimerScore timerScore;

    public GameObject secretMovie;

    // Update is called once per frame
    void Update()
    {
        if(timerScore.timerCode == 15)
        {
            isUnlocked();
        }
        else
        {
            isLocked();
        }

        if (timerScore.timerCode1 == 60)
        {
            isUnlocked1();
        }
        else
        {
            isLocked1();
        }

        if (timerScore.timerCode2 == 120)
        {
            isUnlocked2();
        }
        else
        {
            isLocked2();
        }

        if (timerScore.timerCode3 == 180)
        {
            isUnlocked3();
        }
        else
        {
            isLocked3();
        }

        if (timerScore.timerCode4 == 240)
        {
            isUnlocked4();
        }
        else
        {
            isLocked4();
        }

        if (timerScore.timerCode5 == 300)
        {
            isUnlocked5();
        }
        else
        {
            isLocked5();
        }
        if (timerScore.timerCode6 == 360)
        {
            isUnlocked6();
        }
        else
        {
            isLocked6();
        }
        if (timerScore.timerCode7 == 420)
        {
            isUnlocked7();
        }
        else
        {
            isLocked7();
        }
        if (timerScore.timerCode8 == 480)
        {
            isUnlocked8();
        }
        else
        {
            isLocked8();
        }
        if (timerScore.timerCode9 == 540)
        {
            isUnlocked9();
        }
        else
        {
            isLocked9();
        }
        if (timerScore.timerCode10 == 600)
        {
            isUnlocked10();
        }
        else
        {
            isLocked10();
        }
    }

    public void isUnlocked()
    {
        image.SetActive(false);
    }
    public void isLocked()
    {
        image.SetActive(true);
    }

    public void isUnlocked1()
    {
        image1.SetActive(false);
    }
    public void isLocked1()
    {
        image1.SetActive(true);
    }

    public void isUnlocked2()
    {
        image2.SetActive(false);
    }
    public void isLocked2()
    {
        image2.SetActive(true);
    }

    public void isUnlocked3()
    {
        image3.SetActive(false);
    }
    public void isLocked3()
    {
        image3.SetActive(true);
    }

    public void isUnlocked4()
    {
        image4.SetActive(false);
    }
    public void isLocked4()
    {
        image4.SetActive(true);
    }

    public void isUnlocked5()
    {
        image5.SetActive(false);
    }
    public void isLocked5()
    {
        image5.SetActive(true);
    }

    public void isUnlocked6()
    {
        image6.SetActive(false);
    }
    public void isLocked6()
    {
        image6.SetActive(true);
    }

    public void isUnlocked7()
    {
        image7.SetActive(false);
    }
    public void isLocked7()
    {
        image7.SetActive(true);
    }

    public void isUnlocked8()
    {
        image8.SetActive(false);
    }
    public void isLocked8()
    {
        image8.SetActive(true);
    }

    public void isUnlocked9()
    {
        image9.SetActive(false);
    }
    public void isLocked9()
    {
        image9.SetActive(true);
    }

    public void isUnlocked10()
    {
        image10.SetActive(false);
        secretMovie.SetActive(true);
    }
    public void isLocked10()
    {
        image10.SetActive(true);
        secretMovie.SetActive(false);
    }
}
