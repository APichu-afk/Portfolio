using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Manager : MonoBehaviour
{
    public void SecondYearGame()
    {
        //Bring up UI for Second year game
        SceneManager.LoadScene("Year2Game");
    }
    
    public void ThirdYearGame()
    {
        //Bring up UI for Third year game
        SceneManager.LoadScene("Year3Game");
    }
    
    public void FourthYearGame()
    {
        //Bring up UI for Fourth year game
        SceneManager.LoadScene("Year4Game");
    }
    
    public void VRProject()
    {
        //Bring up ui for VR roject
        SceneManager.LoadScene("VRProject");
    }

    public void ItchIO()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            Application.OpenURL("https://pichumain.itch.io/");
        }

        //Send them to the itch.io page
        if (SceneManager.GetActiveScene().name == "Year2Game")
        {
            Application.OpenURL("https://pichumain.itch.io/birthday-splash-bash");
        }
        
        if(SceneManager.GetActiveScene().name == "Year3Game")
        {
            Application.OpenURL("https://pichumain.itch.io/after-the-crash");
        }
        
        if(SceneManager.GetActiveScene().name == "Year4Game")
        {
            Application.OpenURL("https://tyrannical-studio.itch.io/edge-of-grief");
        }
    }
    public void Github()
    {
        //Send them to the github page
        if (SceneManager.GetActiveScene().name == "Year2Game")
        {
            Application.OpenURL("https://github.com/APichu-afk/BirthdaySplashBashseason2");
        
        }
        
        if (SceneManager.GetActiveScene().name == "Year3Game")
        {
            Application.OpenURL("https://github.com/APichu-afk/GDW-year-3");
        
        }
        
        if (SceneManager.GetActiveScene().name == "Year4Game")
        {
            Application.OpenURL("https://github.com/TyrannicalStudios/Edge-of-Grief");
        
        }
        
        if (SceneManager.GetActiveScene().name == "VRProject")
        {
            Application.OpenURL("https://github.com/JoeyDaStudent/EM-Final-Project");
        
        }
    }

    public void Steam()
    {
        Application.OpenURL("https://store.steampowered.com/app/2393470/Edge_of_Grief/");
    }

    public void Back()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/alexander-edward-chow/");
    }
}
