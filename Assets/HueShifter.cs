using UnityEngine;
using UnityEngine.UI;

public class HueShifter : MonoBehaviour
{
    public float rainbowSpeed;
    public bool randomize;

    private float hue;
    private float sat;
    private float bri;
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        if (randomize)
        {
            hue = Random.Range(0f, 1f);
        }
        sat = 1;
        bri = 1;
        meshRenderer.material.color = Color.HSVToRGB(hue, sat, bri);
    }


    void Update()
    {
        Color.RGBToHSV(meshRenderer.material.color, out hue, out sat, out bri);
        hue += rainbowSpeed / 10000;
        if (hue >= 1)
        {
            hue= 0;
        }
        meshRenderer.material.color = Color.HSVToRGB(hue, sat, bri);
    }
}