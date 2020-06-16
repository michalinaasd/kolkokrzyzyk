using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameController : MonoBehaviour
{
    int player = 0;

    string crossMark = "x";
    string circleMark = "o";

    // Start is called before the first frame update
    void Start()
    {
        Text movementText = GameObject.Find("movementText").GetComponent<Text>();

        player = 0;
        movementText.text = getPlayerName(player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonClicked(Button button) {
        Text buttonText = GameObject.Find(button.name).GetComponentInChildren<Text>();
        Text movementText = GameObject.Find("movementText").GetComponent<Text>();

        if (buttonText.text == crossMark || buttonText.text == circleMark) {
            return;
        }

        switch (player) {
            case (0):
                buttonText.text = crossMark;
                break;

            case (1):
                buttonText.text = circleMark;
                break;

            default:
                break;
        }

        player = changePlayer(player);
        movementText.text = getPlayerName(player);

        
    }

    int changePlayer(int currentPlayer) {
        switch (currentPlayer)
        {
            case (0):
                return 1;

            case (1):
                return 0;

            default:
                return currentPlayer;
        }
    }

    string getPlayerName(int currentPlayer) {
        switch (currentPlayer)
        {
            case (0):
                return "Cross";

            case (1):
                return "Circle";

            default:
                return "--------";
        }
    }
}


