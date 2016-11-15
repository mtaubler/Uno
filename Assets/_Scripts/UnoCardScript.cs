using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UnoCardScript : MonoBehaviour  {
	public Sprite cardsprite;
	public int cardvalue; //0-9 are numbered cards, 10 is , 11 is , 12 is , 13 is , 14 is 
	public int suit; //0 is yellow, 1 is blue, 2 is green, 3 is red

	public Sprite getCardSprite(){
		return cardsprite;
	}
	public int getCardValue(){
		return cardvalue;
	}
	public int getCardSuit(){
		return suit;
	}

	public void editCard(Sprite newsprite, int newvalue, int newsuit, UnoCardScript newframereference){
			cardsprite = newsprite;
			newvalue = cardvalue;
			suit = newsuit;
	}
}
