using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //camera follow karanna oni
    //ekata playerta variable ekak hadanawa
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //playerge position eka camera ekata samaana karanawa
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
