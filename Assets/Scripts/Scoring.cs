using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{
    private int playerScore = 0;
    private int cpuScore = 0;

    public GameObject playerScoreText;
    public GameObject cpuScoreText;

    public int goal;

    // Update is called once per frame
    void Update()
    {
        if(this.playerScore >= goal || this.cpuScore >= goal)
        {
            SceneManager.LoadScene("GameFinished");
        }
    }

    private void FixedUpdate()
    {
        Text playerScoreTag = playerScoreText.GetComponent<Text>();
        playerScoreTag.text = playerScore.ToString();
        Text cpuScoreTag = cpuScoreText.GetComponent<Text>();
        cpuScoreTag.text = cpuScore.ToString();
    }

    public void AddPlayerScore()
    {
        playerScore++;
    }

    public void AddCpuScore()
    {
        cpuScore++;
    }
}
