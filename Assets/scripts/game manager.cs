using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        player player1 =new player();
        player player2 = new player();
        player1.InitializPlayer("raed",100);
        player2.InitializPlayer("amin",90);
        player1.Heal(20);
        player2.Heal(true);
        player2.ShowPlayerCount();
        
    }
}
