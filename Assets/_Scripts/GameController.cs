/*
 * Sourcefile name : GameController
 * Author’s name: Anjith Babu
 * Last	Modifiedby: Anjith Babu
 * Date	lastModified : Feb 29, 2016	
 * Program	description: 
 * Game controller is used to control game objects in the main scene like score, lives etc.
 */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    // private instance variables
    private static int scoreValue;
    private int livesValue;
    

    // public instance variables
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text HighScoreLabel;
    public Text GameOverLabel;
    public Button RestartButton;
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController fp;

    // public access methods
    public int ScoreValue
    {
        get
        {
            return scoreValue;
        }

        set
        {
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                scoreValue = value;
                this.ScoreLabel.text = "Score: " + scoreValue;
            }
        }
    }

    public int LivesValue
    {
        get
        {
            return this.livesValue;
        }

        set
        {
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                this.livesValue = value;
                if (this.livesValue <= 0)
                {
                    this._endGame();
                }
                else
                {
                    this.LivesLabel.text = "Lives: " + this.livesValue;
                }
            }
        }
    }


    // Use this for initialization
    void Start()
    {
        this._initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Initial Method
    private void _initialize()
    {
        this.ScoreValue = 0;
        this.LivesValue = 1;
        this.GameOverLabel.gameObject.SetActive(false);
        this.HighScoreLabel.gameObject.SetActive(false);
        this.RestartButton.gameObject.SetActive(false);
    }

    // Things to do when game ends

    private void _endGame()
    {
        this.HighScoreLabel.text = "High Score: " + this.ScoreValue;
        this.GameOverLabel.gameObject.SetActive(true);
        this.HighScoreLabel.gameObject.SetActive(true);
        this.LivesLabel.gameObject.SetActive(false);
        this.ScoreLabel.gameObject.SetActive(false);
        this.RestartButton.gameObject.SetActive(true);
        GameObject.FindGameObjectWithTag("Enemy").gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("Chest").gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("Wand").gameObject.SetActive(false);

        if (GameObject.Find("Player").GetComponent<CharacterController>())
        {
            GameObject.Find("Player").GetComponent<CharacterController>().enabled = false;
        }

        else
        {
            Debug.Log("No Motor Attached!");
        }
    }

    public void RestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
