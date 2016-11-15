using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnoDeckScript : MonoBehaviour {
	public static UnoDeckScript Instance;
	public GameObject maindeck;
	public static int unocardtotal;
	public static List<GameObject> unodecklist = new List<GameObject>();
	public static Sprite[] unocardsprites;

	// Use this for initialization
	void Start () {
		Instance = this;
		//Debug.Log ("5");
		unocardsprites = Resources.LoadAll<Sprite>("CardSpriteSheet");
		//Debug.Log ("6");
		MakeDeck ();
		//Debug.Log ("7");
		PlayScreenOverCanvasController.Instance.initialDrawSevenCardsForEachPlayer ();
		PlayScreenOverCanvasController.Instance.makePlayerOneActivePlayer ();
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void MakeDeck(){
		//Yellow Cards
		Instance.MakeNewCard (unocardsprites [0], 0, 0);
		Instance.MakeNewCard (unocardsprites [1], 1, 0);
		Instance.MakeNewCard (unocardsprites [2], 2, 0);
		Instance.MakeNewCard (unocardsprites [3], 3, 0);
		Instance.MakeNewCard (unocardsprites [4], 4, 0);
		Instance.MakeNewCard (unocardsprites [5], 5, 0);
		Instance.MakeNewCard (unocardsprites [6], 6, 0);
		Instance.MakeNewCard (unocardsprites [7], 7, 0);
		Instance.MakeNewCard (unocardsprites [8], 8, 0);
		Instance.MakeNewCard (unocardsprites [9], 9, 0);
		Instance.MakeNewCard (unocardsprites [1], 1, 0);
		Instance.MakeNewCard (unocardsprites [2], 2, 0);
		Instance.MakeNewCard (unocardsprites [3], 3, 0);
		Instance.MakeNewCard (unocardsprites [4], 4, 0);
		Instance.MakeNewCard (unocardsprites [5], 5, 0);
		Instance.MakeNewCard (unocardsprites [6], 6, 0);
		Instance.MakeNewCard (unocardsprites [7], 7, 0);
		Instance.MakeNewCard (unocardsprites [8], 8, 0);
		Instance.MakeNewCard (unocardsprites [9], 9, 0);
		Instance.MakeNewCard (unocardsprites [10], 10, 0);
		Instance.MakeNewCard (unocardsprites [10], 10, 0);
		Instance.MakeNewCard (unocardsprites [11], 11, 0);
		Instance.MakeNewCard (unocardsprites [11], 11, 0);
		Instance.MakeNewCard (unocardsprites [12], 12, 0);
		Instance.MakeNewCard (unocardsprites [12], 12, 0);

		//Blue Cards
		Instance.MakeNewCard (unocardsprites [13], 0, 1);
		Instance.MakeNewCard (unocardsprites [14], 1, 1);
		Instance.MakeNewCard (unocardsprites [15], 2, 1);
		Instance.MakeNewCard (unocardsprites [16], 3, 1);
		Instance.MakeNewCard (unocardsprites [17], 4, 1);
		Instance.MakeNewCard (unocardsprites [18], 5, 1);
		Instance.MakeNewCard (unocardsprites [19], 6, 1);
		Instance.MakeNewCard (unocardsprites [20], 7, 1);
		Instance.MakeNewCard (unocardsprites [21], 8, 1);
		Instance.MakeNewCard (unocardsprites [22], 9, 1);
		Instance.MakeNewCard (unocardsprites [14], 1, 1);
		Instance.MakeNewCard (unocardsprites [15], 2, 1);
		Instance.MakeNewCard (unocardsprites [16], 3, 1);
		Instance.MakeNewCard (unocardsprites [17], 4, 1);
		Instance.MakeNewCard (unocardsprites [18], 5, 1);
		Instance.MakeNewCard (unocardsprites [19], 6, 1);
		Instance.MakeNewCard (unocardsprites [20], 7, 1);
		Instance.MakeNewCard (unocardsprites [21], 8, 1);
		Instance.MakeNewCard (unocardsprites [22], 9, 1);
		Instance.MakeNewCard (unocardsprites [23], 10, 1);
		Instance.MakeNewCard (unocardsprites [23], 10, 1);
		Instance.MakeNewCard (unocardsprites [24], 11, 1);
		Instance.MakeNewCard (unocardsprites [24], 11, 1);
		Instance.MakeNewCard (unocardsprites [25], 12, 1);
		Instance.MakeNewCard (unocardsprites [25], 12, 1);
	
		//Green Cards
		Instance.MakeNewCard (unocardsprites [26], 0, 2);
		Instance.MakeNewCard (unocardsprites [27], 1, 2);
		Instance.MakeNewCard (unocardsprites [28], 2, 2);
		Instance.MakeNewCard (unocardsprites [29], 3, 2);
		Instance.MakeNewCard (unocardsprites [30], 4, 2);
		Instance.MakeNewCard (unocardsprites [31], 5, 2);
		Instance.MakeNewCard (unocardsprites [32], 6, 2);
		Instance.MakeNewCard (unocardsprites [33], 7, 2);
		Instance.MakeNewCard (unocardsprites [34], 8, 2);
		Instance.MakeNewCard (unocardsprites [35], 9, 2);
		Instance.MakeNewCard (unocardsprites [27], 1, 2);
		Instance.MakeNewCard (unocardsprites [28], 2, 2);
		Instance.MakeNewCard (unocardsprites [29], 3, 2);
		Instance.MakeNewCard (unocardsprites [30], 4, 2);
		Instance.MakeNewCard (unocardsprites [31], 5, 2);
		Instance.MakeNewCard (unocardsprites [32], 6, 2);
		Instance.MakeNewCard (unocardsprites [33], 7, 2);
		Instance.MakeNewCard (unocardsprites [34], 8, 2);
		Instance.MakeNewCard (unocardsprites [35], 9, 2);
		Instance.MakeNewCard (unocardsprites [36], 10, 2);
		Instance.MakeNewCard (unocardsprites [36], 10, 2);
		Instance.MakeNewCard (unocardsprites [37], 11, 2);
		Instance.MakeNewCard (unocardsprites [37], 11, 2);
		Instance.MakeNewCard (unocardsprites [38], 12, 2);
		Instance.MakeNewCard (unocardsprites [38], 12, 2);

		//Red Cards
		Instance.MakeNewCard (unocardsprites [39], 0, 3);
		Instance.MakeNewCard (unocardsprites [40], 1, 3);
		Instance.MakeNewCard (unocardsprites [41], 2, 3);
		Instance.MakeNewCard (unocardsprites [42], 3, 3);
		Instance.MakeNewCard (unocardsprites [43], 4, 3);
		Instance.MakeNewCard (unocardsprites [44], 5, 3);
		Instance.MakeNewCard (unocardsprites [45], 6, 3);
		Instance.MakeNewCard (unocardsprites [46], 7, 3);
		Instance.MakeNewCard (unocardsprites [47], 8, 3);
		Instance.MakeNewCard (unocardsprites [48], 9, 3);
		Instance.MakeNewCard (unocardsprites [40], 1, 3);
		Instance.MakeNewCard (unocardsprites [41], 2, 3);
		Instance.MakeNewCard (unocardsprites [42], 3, 3);
		Instance.MakeNewCard (unocardsprites [43], 4, 3);
		Instance.MakeNewCard (unocardsprites [44], 5, 3);
		Instance.MakeNewCard (unocardsprites [45], 6, 3);
		Instance.MakeNewCard (unocardsprites [46], 7, 3);
		Instance.MakeNewCard (unocardsprites [47], 8, 3);
		Instance.MakeNewCard (unocardsprites [48], 9, 3);
		Instance.MakeNewCard (unocardsprites [49], 10, 3);
		Instance.MakeNewCard (unocardsprites [49], 10, 3);
		Instance.MakeNewCard (unocardsprites [50], 11, 3);
		Instance.MakeNewCard (unocardsprites [50], 11, 3);
		Instance.MakeNewCard (unocardsprites [51], 12, 3);
		Instance.MakeNewCard (unocardsprites [51], 12, 3);

		//Wild Cards
		Instance.MakeNewCard (unocardsprites [52], 13, 4);
		Instance.MakeNewCard (unocardsprites [52], 13, 4);
		Instance.MakeNewCard (unocardsprites [52], 13, 4);
		Instance.MakeNewCard (unocardsprites [52], 13, 4);
		Instance.MakeNewCard (unocardsprites [53], 14, 4);
		Instance.MakeNewCard (unocardsprites [53], 14, 4);
		Instance.MakeNewCard (unocardsprites [53], 14, 4);
		Instance.MakeNewCard (unocardsprites [53], 14, 4);
	}
	public GameObject GetCardInDeck(int index){
		return unodecklist[index];
	}
	public static void RaiseCardTotal(){
		unocardtotal = unocardtotal + 1;
	}

	public void MakeNewCard(Sprite newsprite, int newvalue, int newsuit){
		unodecklist.Add(helper.makeConceptualCard(maindeck, newsprite, newvalue, newsuit));
		RaiseCardTotal();
	}
		
	public static void RemoveTopCardToPutItInTheCurrentPlayersHand(){
		PlayScreenOverCanvasController.currentdeckcard = unodecklist[0];
		unodecklist.Remove(unodecklist[0]);
		unocardtotal--;
	}
	/*
	public static void ScrambleCardAtLocation(){
		
	}
	public static void ScrambleDeck(){
		
	}
	
	// Idea behind this function is from the setup rules.
	// If a Wild 4 card is at the top then the deck should be 
	// reshuffled before beginning a game.
	public static void isDeckLegal(){
		
	}
	*/
}
