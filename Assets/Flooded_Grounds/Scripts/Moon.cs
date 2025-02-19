using UnityEngine;

public class Moon : MonoBehaviour
{
    public Light directionalLight;

    void Start()
    {
        if (directionalLight != null)
        {
            // Configura el color de la luz para que se parezca a la luz de la luna (tonalidad azulada)
            directionalLight.color = new Color(0.5f, 0.5f, 1f);

            // Reduce la intensidad de la luz para simular la luz nocturna
            directionalLight.intensity = 0.2f;

            // Cambia la dirección de la luz si es necesario
            directionalLight.transform.rotation = Quaternion.Euler(30f, 0f, 0f);  // Ajusta los valores según tus necesidades

            // Opcional: Configura el "Shadow Strength" (fuerza de las sombras)
            directionalLight.shadowStrength = 0.7f;
        }
    }
}
