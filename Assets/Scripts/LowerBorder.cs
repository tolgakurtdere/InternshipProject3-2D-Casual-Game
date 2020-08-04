using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerBorder : MonoBehaviour
{
    private Transform player;
    private float initDis;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        initDis = player.transform.position.y - transform.position.y;
    }

    void Update()
    {
        if (PlayerControl.isConnected || player.gameObject.GetComponent<Rigidbody2D>().velocity.y > 0)
        {
            transform.position = new Vector3(transform.position.x, player.transform.position.y - initDis);
        }
    }

}
