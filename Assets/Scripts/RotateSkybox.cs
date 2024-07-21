using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    public float rotationSpeed = 5f; // Velocidad de rotación del skybox

    void Update()
    {
        // Rotar el skybox alrededor del eje X
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
    }
}
