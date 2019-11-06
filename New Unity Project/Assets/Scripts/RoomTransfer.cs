using System.Collections.Generic;
using UnityEngine;

public class RoomTransfer : MonoBehaviour
{
    private Collider2D Collider2D;

    public string levelToLoad;

       
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D other) {


        if(other.gameObject.name == "Player")
        {
            Application.LoadLevel(levelToLoad);

        }
        }
    
}
