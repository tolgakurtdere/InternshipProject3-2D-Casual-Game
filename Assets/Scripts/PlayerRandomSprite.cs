using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRandomSprite : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] sprites;
    public SpriteRenderer outline;
    void Start()
    {
        Sprite r = sprites[Random.Range(0, sprites.Length)];
        GetComponent<SpriteRenderer>().sprite = r;
        outline.sprite = r;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
