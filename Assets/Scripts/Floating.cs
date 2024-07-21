using UnityEngine;

public class Floating : MonoBehaviour
{
    public float amplitude = 0.5f; // Amplitud del movimiento vertical
    public float frequency = 1f; // Frecuencia del movimiento vertical

    private Vector3 startPosition;

    void Start()
    {
        // Guardar la posición inicial del objeto
        startPosition = transform.position;
    }

    void Update()
    {
        // Calcular la nueva posición usando una función senoidal
        float newY = startPosition.y + Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
