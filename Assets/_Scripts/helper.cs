using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class helper {
	
	public static GameObject makePlayer(GameObject parent){
		GameObject newplayerhand = new GameObject("Player_" + PlayScreenOverCanvasController.playerid);
		newplayerhand.gameObject.AddComponent<UnoPlayerScript>();
		newplayerhand.transform.SetParent(parent.transform);

		return newplayerhand;
	}
	public static GameObject makePlayerOppositionLabel(GameObject parent){
		GameObject opposingplayerlabel = new GameObject("OpposingPlayer_" + PlayScreenOverCanvasController.playerid);

		GameObject opposingplayernamelabel = new GameObject("PlayerTagText");
		opposingplayernamelabel.AddComponent<Text>();
		opposingplayernamelabel.GetComponent<Text> ().alignment = TextAnchor.MiddleLeft;
		opposingplayernamelabel.GetComponent<Text> ().text = "Player" + PlayScreenOverCanvasController.playerid + ":";

		GameObject opposingplayercardlabel = new GameObject("CardNumberText");
		opposingplayercardlabel.AddComponent<Text>();
		opposingplayercardlabel.GetComponent<Text> ().alignment = TextAnchor.MiddleCenter;
		opposingplayercardlabel.GetComponent<Text> ().text = "" + PlayScreenOverCanvasController.unoplayerlist[PlayScreenOverCanvasController.playerid].GetComponent<UnoPlayerScript>().playerhandstacktotal;

		opposingplayernamelabel.transform.SetParent(opposingplayerlabel.transform);
		opposingplayercardlabel.transform.SetParent(opposingplayerlabel.transform);
		opposingplayerlabel.transform.SetParent(parent.transform);

		return opposingplayerlabel;
	}

	public static GameObject makeConceptualCard(GameObject parent, Sprite newsprite, int newvalue, int newsuit){
		GameObject newcard = new GameObject("card_" + UnoDeckScript.unocardtotal);
		newcard.gameObject.AddComponent<UnoCardScript>();

		newcard.gameObject.GetComponent<UnoCardScript> ().cardsprite = newsprite;
		newcard.gameObject.GetComponent<UnoCardScript> ().cardvalue = newvalue;
		newcard.gameObject.GetComponent<UnoCardScript> ().suit = newsuit;
		newcard.transform.SetParent(parent.transform);

		return newcard;
	}
	public static void editConceptualCardToVisual(GameObject newcard, GameObject parent, Vector2 anchormin, Vector2 anchormax, Vector2 sizedelta, Vector3 localscale, Vector3 localposition){
		newcard.layer = 5;
		newcard.transform.SetParent(PlayScreenOverCanvasController.Instance.playerhandpanel.transform);
		newcard.gameObject.AddComponent<RectTransform>();
		newcard.gameObject.AddComponent<Button>();
		newcard.AddComponent<Image>();

		newcard.GetComponent<Image>().sprite = newcard.gameObject.GetComponent<UnoCardScript> ().getCardSprite();

		newcard.gameObject.GetComponent<RectTransform>().anchorMin = anchormin;
		newcard.gameObject.GetComponent<RectTransform>().anchorMax = anchormax;
		newcard.gameObject.GetComponent<RectTransform>().sizeDelta = sizedelta;
		newcard.gameObject.GetComponent<RectTransform>().localScale = localscale;
		newcard.gameObject.GetComponent<RectTransform>().anchoredPosition3D = localposition;

		newcard.gameObject.GetComponent<Button>().onClick.AddListener( delegate {PlayScreenOverCanvasController.Instance.ActivateGameCardMenuAction(newcard);});
		newcard.transform.SetParent(parent.transform);
	}

	public static void makeVisualCard(GameObject parent, Vector2 anchormin, Vector2 anchormax, Vector2 sizedelta, Vector3 localscale, Vector3 localposition){
		GameObject newcard = new GameObject("card_"+ UnoDeckScript.unocardtotal);
		newcard.layer = 5;
		newcard.transform.SetParent(parent.transform);
		newcard.gameObject.AddComponent<RectTransform>();
		newcard.gameObject.AddComponent<Button>();
		newcard.gameObject.AddComponent<UnoCardScript>();
		newcard.AddComponent<Image>();

		newcard.gameObject.GetComponent<UnoCardScript> ().cardsprite = UnoDeckScript.unodecklist [0].GetComponent<UnoCardScript> ().getCardSprite();
		newcard.gameObject.GetComponent<UnoCardScript> ().cardvalue = UnoDeckScript.unodecklist [0].GetComponent<UnoCardScript> ().getCardValue();
		newcard.gameObject.GetComponent<UnoCardScript> ().suit = UnoDeckScript.unodecklist [0].GetComponent<UnoCardScript> ().getCardSuit();
		newcard.GetComponent<Image>().sprite = newcard.gameObject.GetComponent<UnoCardScript> ().getCardSprite();

		newcard.gameObject.GetComponent<RectTransform>().anchorMin = anchormin;
		newcard.gameObject.GetComponent<RectTransform>().anchorMax = anchormax;
		newcard.gameObject.GetComponent<RectTransform>().sizeDelta = sizedelta;
		newcard.gameObject.GetComponent<RectTransform>().localScale = localscale;
		newcard.gameObject.GetComponent<RectTransform>().anchoredPosition3D = localposition;

		newcard.gameObject.GetComponent<Button>().onClick.AddListener( delegate {PlayScreenOverCanvasController.Instance.ActivateGameCardMenuAction(newcard);});
	}
}
