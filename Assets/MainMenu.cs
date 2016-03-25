using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public bool isPlay;
    public bool isHelp;
    public bool isOptions;
    public bool isExit;
    
	void OnMouseUP()
    {
        if(isPlay)
        {
<<<<<<< HEAD
            Application.LoadLevel(1);
=======
            Application.LoadLevel(3);
>>>>>>> 8d6141437069199a0f1677ff7af16505bc8d01fd
        }

        if (isHelp)
        {
<<<<<<< HEAD
            Application.LoadLevel(3);
=======
            Application.LoadLevel(2);
>>>>>>> 8d6141437069199a0f1677ff7af16505bc8d01fd
        }

        if (isOptions)
        {
<<<<<<< HEAD
            Application.LoadLevel(0);
=======
            Application.LoadLevel(1);
>>>>>>> 8d6141437069199a0f1677ff7af16505bc8d01fd
        }

        if (isExit)
        {
            Application.Quit();
        }
    }
}
