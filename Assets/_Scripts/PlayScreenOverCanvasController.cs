using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

//remodeling this to use the list of frames digitalbookscript makes
public class PlayScreenOverCanvasController : MonoBehaviour {
	public static PlayScreenOverCanvasController Instance;
	public GameObject playerhandpanel;
	public GameObject gamecardmenu;
	public static Sprite[] unocardsprites;

	public GameObject unobutton;
	public GameObject drawbutton;
	public GameObject quitbutton;
	public GameObject carddumpobject;

	public static List<GameObject> unoplayerlist = new List<GameObject>();
	public int totalplayers = 2;
	public static int playerid = 0;
	public static GameObject currentplayer;
	public int currentplayerlocation = 0;

	public bool isswitchingplayers = false;
	public int playerrotationdirection  = 1;

	public static GameObject currentdeckcard;
	public static GameObject currentselectedcardasvisualbutton;

	//public static Vector3[] oppositionlocationsonscreen;

	// Debug test variables, does not need to be in final
	public GameObject testsizeandpostionbutton;
	public Vector2 sizedeltatest = new Vector2 (3f, 5f);
	public Vector3 positiontest = new Vector3 (184f, -166.3f, 0.0f);
	public bool istestingbuttonsizesandpositioning = false;
	public bool istestingsomething = false;
	// End of debug variables.

	// Use this for initialization
	void Start () {
		Instance = this;
		makePlayers ();
		currentplayer = unoplayerlist[0];
		unocardsprites = Resources.LoadAll<Sprite>("CardSpriteSheet");
	}

	// Update is called once per frame
	void Update () {
		/*if(isswitchingplayers){
			changeActivePlayer(playerrotationdirection);
		}*/
		if (istestingsomething) {
			initialDrawSevenCardsForEachPlayer ();
			istestingsomething = false;
		}
		if(istestingbuttonsizesandpositioning){
			testsizeandpostionbutton.gameObject.GetComponent<RectTransform>().sizeDelta = sizedeltatest;
			testsizeandpostionbutton.gameObject.GetComponent<RectTransform>().anchoredPosition3D = positiontest;
		}
	}

	public void makePlayers(){
		for(int i = 0; i < totalplayers; i++){
			unoplayerlist.Add(helper.makePlayer (playerhandpanel));
			playerid++;
		}
	}
	//direction assumed to be either -1 or 1
	public void changeActivePlayer(int direction){
		currentplayerlocation = currentplayerlocation + direction;
		if (currentplayerlocation >= totalplayers) {
			currentplayerlocation = 0;
		}
		if (currentplayerlocation < 0) {
			currentplayerlocation = totalplayers-1;
		}
		for (int i = 0; i < totalplayers; i++) {
			unoplayerlist[i].SetActive(false);
		}
		currentplayer = unoplayerlist[currentplayerlocation];
		currentplayer.SetActive(true);
	}
	public void initialDrawSevenCardsForEachPlayer(){
		for(int i = 0; i < totalplayers; i++){
			currentplayer = unoplayerlist[i];
			for(int j = 0; j < 7; j++){
				helper.editConceptualCardToVisual(UnoDeckScript.unodecklist[0], unoplayerlist[i], new Vector2 ((float)(0.0 + 0.05*unoplayerlist[i].GetComponent<UnoPlayerScript>().playerhandstacktotal), 0.0f), new Vector2 ((float)(0.20 + 0.05*unoplayerlist[i].GetComponent<UnoPlayerScript>().playerhandstacktotal), 1f), new Vector2 (0f, 0f), new Vector3(1f, 1f, 1f), new Vector3 (10.0f, 0.0f, 0.0f));
				unoplayerlist[i].GetComponent<UnoPlayerScript>().playerhandstacktotal++;
				UnoDeckScript.RemoveTopCardToPutItInTheCurrentPlayersHand();
			}
		}
		currentplayer = unoplayerlist[0];
	}
	public void makePlayerOneActivePlayer(){
		for (int i = 0; i < totalplayers; i++) {
			unoplayerlist[i].SetActive(false);
		}
		currentplayer = unoplayerlist[0];
		currentplayer.SetActive(true);
	}

	public void DrawCardAction() {
		helper.editConceptualCardToVisual(UnoDeckScript.unodecklist[0], currentplayer, new Vector2 ((float)(0.0 + 0.05*currentplayer.GetComponent<UnoPlayerScript>().playerhandstacktotal), 0.0f), new Vector2 ((float)(0.20 + 0.05*currentplayer.GetComponent<UnoPlayerScript>().playerhandstacktotal), 1f), new Vector2 (0f, 0f), new Vector3(1f, 1f, 1f), new Vector3 (10.0f, 0.0f, 0.0f));
		currentplayer.GetComponent<UnoPlayerScript>().playerhandstacktotal++;
		UnoDeckScript.RemoveTopCardToPutItInTheCurrentPlayersHand();
	}

	public void ActivateGameCardMenuAction(GameObject cardwiththisaction){
		currentselectedcardasvisualbutton = cardwiththisaction;
		gamecardmenu.SetActive (true);
	}

	public void SendCardToDumpAction(){
		currentselectedcardasvisualbutton.transform.SetParent(carddumpobject.transform);
		currentselectedcardasvisualbutton.gameObject.GetComponent<RectTransform>().anchorMin = new Vector2 (0.5f, 0.5f);
		currentselectedcardasvisualbutton.gameObject.GetComponent<RectTransform>().anchorMax = new Vector2 (0.5f,0.5f);
		currentselectedcardasvisualbutton.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2 (60f, 100f);
		currentselectedcardasvisualbutton.gameObject.GetComponent<RectTransform>().anchoredPosition3D = new Vector3 (0f, 0f, 0.0f);
		gamecardmenu.SetActive (false);
		currentplayer.GetComponent<UnoPlayerScript>().playerhandstacktotal--;
		currentselectedcardasvisualbutton.gameObject.GetComponent<Button> ().enabled = false;

		changeActivePlayer(playerrotationdirection);
	}
	//
	public void QuitGameAction() {
		#if UNITY_EDITOR
		SceneManager.LoadScene(0);
		#else
		SceneManager.LoadScene("0");
		#endif 
	}
}
