using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtmosphereScript : MonoBehaviour
{
    
   
    public void Atmosphere(Color water)
    {
        float H, S, V;
        Color.RGBToHSV(water,out H,out S ,out V);
        V = 1f;
        Color atmosphere_color = Color.HSVToRGB(H, S, V);
        GetComponent<Renderer>().material.SetColor("Color_48CA44DF", atmosphere_color);
        
    }
}
