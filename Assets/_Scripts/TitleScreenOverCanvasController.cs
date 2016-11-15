using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement; 
using System.Collections;
using UnityEngine.UI;

public class TitleScreenOverCanvasController : MonoBehaviour {
	public static TitleScreenOverCanvasController Instance;

	public GameObject mainmenupanel;
	public GameObject optionspanel;
	public GameObject loadgamepanel;

	public GameObject startgamebutton;
	public GameObject loadgamebutton;
	public GameObject optionsbutton;
	public GameObject closeprogrambutton;

	public GameObject activepanel;

	public GameObject loadgamesessionlistcontent;

	// Use this for initialization
	void Start () {
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Main Menu Actions
	public void StartContinuingGameButtonAction() {
		//In Unity Editor, File->Build Settings->Add/Open Scenes->Select a new scene to include in the build. Now a scene can be SceneManager.LoadScene()
		//To fix lighting if you mess with it: In Unity Editor, Window->Lighting->Lightmaps->Build ("Auto" doesn't work or something)
		#if UNITY_EDITOR
		SceneManager.LoadScene(1);
		#else
		SceneManager.LoadScene("1");
		#endif 
	}
	public void StartNewGameButtonAction() {
		//In Unity Editor, File->Build Settings->Add/Open Scenes->Select a new scene to include in the build. Now a scene can be SceneManager.LoadScene()
		//To fix lighting if you mess with it: In Unity Editor, Window->Lighting->Lightmaps->Build ("Auto" doesn't work or something)
		#if UNITY_EDITOR
		SceneManager.LoadScene(1);
		#else
		SceneManager.LoadScene("1");
		#endif 
	}

	public void switchPanels(GameObject openpanel, GameObject closepanel) {
		closepanel.SetActive(false);
		openpanel.SetActive(true);
		activepanel = openpanel;
	}

	public void LoadGameMenuButtonAction() {
		//ChuruyaDigitalBookSaveLoad.RefreshSessionList();
		//GenerateSessionList();
		switchPanels (loadgamepanel, mainmenupanel);
	}

	public void OptionsMenuButtonAction() {
		switchPanels (optionspanel, mainmenupanel);
	}

	public void ClosePanelAction(){
		switchPanels(mainmenupanel, activepanel);
	}

	public void CloseProgramButtonAction() {
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif 
	}

	//Options Actions


}
