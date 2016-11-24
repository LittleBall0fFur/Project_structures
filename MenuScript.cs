using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuScript : MonoBehaviour {

    public Canvas quitMenu;
    public Canvas optionsMenu;
    public Button optionsText;
    public Button startText;
    public Button exitText;

	void Start ()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        optionsMenu = optionsMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        optionsText = startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
        optionsMenu.enabled = false;
    }
	
    public void ExitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
        optionsMenu.enabled = false;
    }

    public void OptionsPress()
    {
        optionsMenu.enabled = true;
        quitMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        optionsMenu.enabled = false;
    }

    public void StartLvl()
    {
        SceneManager.LoadScene("Prototype_p.4");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
