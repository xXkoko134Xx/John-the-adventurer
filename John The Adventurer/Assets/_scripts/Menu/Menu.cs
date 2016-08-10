using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    //public Canvas Story;
    public Canvas Quit;
  //  public Button StoryButton;
    public Button Play;
    public Button ExitButton;


	// Use this for initialization
	void Start () {
       // Story = Story.GetComponent<Canvas>();
        Quit = Quit.GetComponent<Canvas>();
        Play = Play.GetComponent<Button>();
       // StoryButton = StoryButton.GetComponent<Button>();
        ExitButton = ExitButton.GetComponent<Button>();
       // Story.enabled = false;
        Quit.enabled = false;

	}
	
	// Update is called once per frame
	public void ExitPress () {

        Quit.enabled = true;
       // StoryButton.enabled = false;
        Play.enabled = false;
        ExitButton.enabled = false;

	
	}
    public void Nopress()
    {
        Quit.enabled = false;
        Play.enabled = true;
        //StoryButton.enabled = true;
        ExitButton.enabled = true;
    }

    public void startLvL()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
   /* public void StoryPressed()
    {
        Story.enabled = true;
        Play.enabled = false;
        StoryButton.enabled = false;
        ExitButton.enabled = false;

    }
    public void StoryQuit()
    {
        Story.enabled = false;
        Play.enabled = true;
        StoryButton.enabled = true;
        ExitButton.enabled = true;
    }*/
}
