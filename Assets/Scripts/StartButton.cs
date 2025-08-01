using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    /*
     * This script is attached to the start button in the main menu and to the Play Again button in the game finished screen
     * When the button is clicked, it loads the game scene
     * This allows players to start the game from the main menu
     */
    public void OnClickStart()
    {
        SceneManager.LoadScene("Board");
    }
}
