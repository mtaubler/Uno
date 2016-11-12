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

	public GameObject testsizeandpostionbutton;

	public static UnoCardScript currentdeckcard;
	public int playerhandstacktotal = 0;
	public static UnoPlayerScript currentplayer;
	public static GameObject currentselectedcardasvisualbutton;

	public Vector2 sizedeltatest = new Vector2 (3f, 5f);
	public Vector3 positiontest = new Vector3 (184f, -166.3f, 0.0f);
	public bool istestingbuttonsizesandpositioning = false;

	// Use this for initialization
	void Start () {
		Instance = this;
		unocardsprites = Resources.LoadAll<Sprite>("CardSpriteSheet");
		UnoDeckScript.MakeDeck ();
	}

	// Update is called once per frame
	void Update () {
		//SwitchPlayers(UnoPlayerScript newplayerhand);
		if(istestingbuttonsizesandpositioning){
			testsizeandpostionbutton.gameObject.GetComponent<RectTransform>().sizeDelta = sizedeltatest;
			testsizeandpostionbutton.gameObject.GetComponent<RectTransform>().anchoredPosition3D = positiontest;
		}
	}

	public void makeVisualofDeckCard(){
		GameObject newcard = new GameObject("card");
		newcard.layer = 5;
		newcard.transform.SetParent(playerhandpanel.transform);
		newcard.gameObject.AddComponent<RectTransform>();
		newcard.gameObject.AddComponent<Button>();
		newcard.AddComponent<Image>();
		//newcard.gameObject.AddComponent<CanvasRenderer>();

		newcard.GetComponent<Image>().sprite = UnoDeckScript.unodecklist[0].cardsprite;

		newcard.gameObject.GetComponent<RectTransform>().anchorMin = new Vector2 ((float)(0.0 + 0.05*playerhandstacktotal), 0.0f);
		newcard.gameObject.GetComponent<RectTransform>().anchorMax = new Vector2 ((float)(0.20 + 0.05*playerhandstacktotal), 1f);
		playerhandstacktotal++;
		newcard.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2 (0f, 0f);
		newcard.gameObject.GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 1f);
		newcard.gameObject.GetComponent<RectTransform>().anchoredPosition3D = new Vector3 (10.0f, 0.0f, 0.0f);

		newcard.gameObject.GetComponent<Button>().onClick.AddListener( delegate {ActivateGameCardMenuAction(newcard);});
	}

	public void DrawCardAction() {
		UnoDeckScript.RemoveTopCardAndPutItInTheCurrentPlayersHand();
		makeVisualofDeckCard ();
	}

	public void ActivateGameCardMenuAction(GameObject cardwiththisaction){
		currentselectedcardasvisualbutton = cardwiththisaction;
		gamecardmenu.SetActive (true);
	}

	public void SendCardToDumpAction(){
		//Debug.Log(this.gameObject.transform);
		currentselectedcardasvisualbutton.transform.SetParent(carddumpobject.transform);
		//currentselectedcardasvisualbutton.transform.SetParent(this.gameObject.transform);
		currentselectedcardasvisualbutton.gameObject.GetComponent<RectTransform>().anchorMin = new Vector2 (0.5f, 0.5f);
		currentselectedcardasvisualbutton.gameObject.GetComponent<RectTransform>().anchorMax = new Vector2 (0.5f,0.5f);
		currentselectedcardasvisualbutton.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2 (60f, 100f);
		currentselectedcardasvisualbutton.gameObject.GetComponent<RectTransform>().anchoredPosition3D = new Vector3 (0f, 0f, 0.0f);
		//currentselectedcardasvisualbutton.gameObject.GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 1f);
		gamecardmenu.SetActive (false);
		playerhandstacktotal--;
		currentselectedcardasvisualbutton.gameObject.GetComponent<Button> ().enabled = false;
	}

	public void SwitchPlayers(UnoPlayerScript newplayerhand) {
		
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
