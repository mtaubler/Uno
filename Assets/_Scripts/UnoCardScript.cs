using UnityEngine;
using System.Collections;

public class UnoCardScript {
	public Sprite cardsprite;
	public int cardvalue; //0-9 are numbered cards ->>> what are numbers for other cards? 11, 12? 10???
	public int suit; //0 is yellow, 1 is blue, 2 is green, 3 is red
	public UnoCardScript next;

	public Sprite getCardSprite(){
		return cardsprite;
	}
	public int getCardValue(){
		return cardvalue;
	}
	public int getCardSuit(){
		return suit;
	}
	public UnoCardScript getNextCard(){
		return next;
	}

	public void editCard(Sprite newsprite, int newvalue, int newsuit, UnoCardScript newframereference){
			cardsprite = newsprite;
			newvalue = cardvalue;
			suit = newsuit;
			next = newframereference;
		}
		/*
		public void editCard(string newsprite, int newvalue, UnoCardScript newframereference){
			cardsprite = LoadSpriteFromName(newsprite);
			newvalue = cardvalue;
			next = newframereference;
		}

		public Sprite LoadSpriteFromName(string spriteinresources){
			return ;
		}*/
}
