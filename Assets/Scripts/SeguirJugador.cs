using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public Transform objetivo; // El GameObject al que quieres seguir

    public float suavizado = 5f; // La velocidad de suavizado de la c�mara

    private Vector3 offset; // La diferencia de posici�n entre la c�mara y el objetivo

    void Start()
    {
        // Calcula el offset inicial entre la c�mara y el objetivo
        offset = transform.position - objetivo.position;
    }

    void FixedUpdate()
    {
        // Calcula la posici�n objetivo de la c�mara
        Vector3 posicionObjetivo = objetivo.position + offset;

        // Aplica suavizado para suavizar el movimiento de la c�mara
        transform.position = Vector3.Lerp(transform.position, posicionObjetivo, suavizado * Time.deltaTime);
    }
   
}
