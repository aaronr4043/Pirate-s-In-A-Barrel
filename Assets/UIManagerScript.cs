using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour
{
    public void GoMain()
    {
        Application.LoadLevel(0);
    }

<<<<<<< HEAD
    public void PlayGame()
=======
    public void GoOptions()
>>>>>>> 8d6141437069199a0f1677ff7af16505bc8d01fd
    {
        Application.LoadLevel(1);
    }

<<<<<<< HEAD
=======
    public void GoHelp()
    {
        Application.LoadLevel(2);
    }

    public void PlayGame()
    {
        Application.LoadLevel(3);
    }

>>>>>>> 8d6141437069199a0f1677ff7af16505bc8d01fd
    public void ExitGame()
    {
        Application.Quit();
    }
}
