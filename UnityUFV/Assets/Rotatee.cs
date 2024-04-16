using UnityEngine;

public class RotacionInfinita : MonoBehaviour
{
    // Velocidad de rotación
    public float velocidadRotacion = 30f;

    void Update()
    {
        // Rotar el objeto en torno al eje Y
        transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);
    }
}