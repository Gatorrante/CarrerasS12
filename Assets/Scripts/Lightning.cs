using UnityEngine;

public class Lightning : MonoBehaviour
{
    public Color emissionColor = Color.white; // Color de emisión, ajustable en el Inspector
    public float emissionIntensity = 1.0f; // Intensidad de la emisión, ajustable en el Inspector

    void Start()
    {
        // Obtener el Renderer del objeto
        Renderer renderer = GetComponent<Renderer>();

        // Verificar si el objeto tiene materiales
        if (renderer != null && renderer.materials != null)
        {
            foreach (Material mat in renderer.materials)
            {
                // Habilitar la propiedad de emisión del material
                mat.EnableKeyword("_EMISSION");
                mat.globalIlluminationFlags = MaterialGlobalIlluminationFlags.RealtimeEmissive;

                // Establecer el color de emisión del material
                mat.SetColor("_EmissionColor", emissionColor * emissionIntensity);

                // Aplicar el material de vuelta al Renderer
                renderer.material = mat;

                // Debug para verificar que el material se ha actualizado
                Debug.Log($"Material {mat.name} actualizado con emisión color {emissionColor * emissionIntensity}");
            }
        }
        else
        {
            Debug.LogWarning("No se encontró un Renderer o materiales en el objeto.");
        }
    }
}

