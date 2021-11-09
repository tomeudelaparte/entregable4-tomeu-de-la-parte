using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Al pulsar con el click izq. sobre el GameObject
    private void OnMouseDown()
    {
        // Cambiará a un color aleatorio
        GetComponent<MeshRenderer>().material.color = RandomColor();

        // Cambiará a una escala aleatoria
        transform.localScale = RandomScale();

        // Cambiará a una posición aleatoria
        transform.position = RandomPosition();
    }

    // Función que devolverá un color aleatorio de tipo Color
    public Color RandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    // Función que devolverá una escala aleatoria de tipo Vector3
    public Vector3 RandomScale()
    {
        return new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
    }

    // Función que devolverá una posición aleatoria de tipo Vector3
    public Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0f);
    }
}
