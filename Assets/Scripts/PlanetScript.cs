using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlanetScript : MonoBehaviour
{
    // Start is called before the first frame update
    Material mat;
    GeneratePlanets generate_planets;
    Transform player;
    AtmosphereScript child;
    void Awake()
    {
        Renderer renderer = GetComponent<Renderer>();

        mat = renderer.material;
        child = GetComponentInChildren<AtmosphereScript>();

        generate_planets = GameObject.FindGameObjectWithTag("Generator").GetComponent<GeneratePlanets>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }
    void OnEnable()
    {
        Randomize();
    }
    private void Update()
    {
        Pool();
    }



    void Randomize()
    {
        Color water = RandomColor();
        Color earth = RandomColor();
        child.Atmosphere(water);

        mat.SetColor("Color_6EF27D29",water);//Color1
        mat.SetColor("Color_A48BFEE5", earth);//Color2
        mat.SetFloat("Vector1_56765CF7", Random.Range(15f, 30f));//NoiseScale
        mat.SetVector("Vector2_5F3ACFEF", new Vector2(Random.Range(0f, 100f), Random.Range(0f, 100f)));//Noise Offset


        transform.localScale = RandomScale();
        
    }

    private Vector2 RandomScale()
    {
        float s = Random.Range(0.5f, 1.5f);
        return new Vector2(s, s);
    }

    private Color RandomColor()
    {
        return new Color(Random.value,Random.value,Random.value,1f);

     }

    // Update is called once per frame
    

    private void Pool()
    {
        if (player.position.y -transform.position.y > 4f)
        {
            generate_planets.PoolMe(gameObject);
        }
    }
}
