using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerSpawnPos;
    public List<SoCharacters> Characters; 

    // After the player is selected and start game is pressed 
    // TODO - Change scene, start game 
    // TODO - observer patter to detect charachter select

    public void OnStartGame(int CharacterSelected)
    {   
        // Change Scene from MainMenuScene to Level1Scene using SceneManager
        // Send selecter char to and spawn player from GameManager


    }
}
