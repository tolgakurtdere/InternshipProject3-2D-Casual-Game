using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GeneratePlanets : MonoBehaviour
{

    public GameObject planet;
    private int Y;

    private bool isFirstPlanet = true;
    void Awake()
    {
        for (int i = 6; i < 27; i+=4)
        {
            float y_offset = Random.Range(-1f, 1f);

            if (isFirstPlanet)
            {
                if(y_offset <= 0) Instantiate(planet, new Vector2(Random.Range(-2f, -1f), i - 1), Quaternion.identity);
                else Instantiate(planet, new Vector2(Random.Range(1f, 2f), i - 1), Quaternion.identity);
                isFirstPlanet = false;
                continue;
            }

            Instantiate(planet, new Vector2(Random.Range(-2f, 2f),i+y_offset), Quaternion.identity);
        }
        Y = 30;
    }

   

    internal void PoolMe(GameObject gameObject)
    {
        gameObject.SetActive(false);
        gameObject.SetActive(true);


        float y_offset = Random.Range(-1f, 1f);
        gameObject.transform.position = new Vector3(Random.Range(-2f, 2f),Y+y_offset);
        Y += 4;
    }
}
