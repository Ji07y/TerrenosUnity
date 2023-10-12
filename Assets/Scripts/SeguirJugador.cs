using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public Transform objetivo; // El GameObject al que quieres seguir

    public float suavizado = 5f; // La velocidad de suavizado de la cámara

    private Vector3 offset; // La diferencia de posición entre la cámara y el objetivo

    void Start()
    {
        // Calcula el offset inicial entre la cámara y el objetivo
        offset = transform.position - objetivo.position;
    }

    void FixedUpdate()
    {
        // Calcula la posición objetivo de la cámara
        Vector3 posicionObjetivo = objetivo.position + offset;

        // Aplica suavizado para suavizar el movimiento de la cámara
        transform.position = Vector3.Lerp(transform.position, posicionObjetivo, suavizado * Time.deltaTime);
    }
   
}
