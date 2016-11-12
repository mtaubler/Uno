using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnoDeckScript {
	public static int unocardtotal;
	public static List<UnoCardScript> unodecklist = new List<UnoCardScript>();

	public static void MakeDeck(){
		// Yellow Cards
        for(int i = 0; i <= 12; i++)
        {
            MakeNewCard(PlayScreenOverCanvasController.unocardsprites[i], i, 0, null);
            if(i!=0)
                MakeNewCard(PlayScreenOverCanvasController.unocardsprites[i], i, 0, null);
        }
        // Blue Cards
        for (int i = 13; i <= 25; i++)
        {
            MakeNewCard(PlayScreenOverCanvasController.unocardsprites[i], i-13, 1, null);
            if (i != 13)
                MakeNewCard(PlayScreenOverCanvasController.unocardsprites[i], i-13, 1, null);
        }
        // Green
        for (int i = 26; i <= 38; i++)
        {
            MakeNewCard(PlayScreenOverCanvasController.unocardsprites[i], i-26, 2, null);
            if (i != 26)
                MakeNewCard(PlayScreenOverCanvasController.unocardsprites[i], i-26, 2, null);
        // Red
        }
        for (int i = 39; i <= 51; i++)
        {
            MakeNewCard(PlayScreenOverCanvasController.unocardsprites[i], i-39, 3, null);
            if (i != 39)
                MakeNewCard(PlayScreenOverCanvasController.unocardsprites[i], i-39, 3, null);
        }

        // Wild Cards
        for (int i = 52; i < 54; i++)
        {
            for(int j = 0; j < 4; j++)
                MakeNewCard(PlayScreenOverCanvasController.unocardsprites[i], 13+(i-52), 4, null);
        }
	}
	public UnoCardScript GetCardInDeck(int index){
		return unodecklist[index];
	}
	public static void RaiseCardTotal(){
        unocardtotal += 1;
		//unocardtotal = unocardtotal + 1;
	}

	public static void MakeNewCard(Sprite newsprite, int newvalue, int newsuit, UnoCardScript newframereference){
		UnoCardScript newcard = new UnoCardScript();
		unodecklist.Add(newcard);
		RaiseCardTotal();
		newcard.editCard (newsprite, newvalue, newsuit, newframereference);
	}
		
	public static void RemoveTopCardAndPutItInTheCurrentPlayersHand(){
		PlayScreenOverCanvasController.currentdeckcard = unodecklist[0];
		//Debug.Log("1: " + unodecklist[0].cardvalue + " " + unodecklist[1].cardvalue);
		unodecklist.Remove(unodecklist[0]);
		//unodecklist[0] = unodecklist[1];
		//Debug.Log("2: " + unodecklist[0].cardvalue + " " + unodecklist[1].cardvalue);
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
