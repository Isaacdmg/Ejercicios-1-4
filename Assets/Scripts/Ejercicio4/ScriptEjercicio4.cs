using UnityEngine;

public class ScriptEjercicio4 : MonoBehaviour
{
    private string tagCubo = "Cubo";
    private string tagCilindro = "Cilindro";

    private Transform cuboTransform;
    private Transform cilindroTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject cuboObj = GameObject.FindGameObjectWithTag(tagCubo);
        GameObject cilindroObj = GameObject.FindGameObjectWithTag(tagCilindro);

        if (cuboObj != null)
        {
            cuboTransform = cuboObj.transform;
        }
        else
        {
            Debug.LogWarning("No se encontró ningún objeto con la etiqueta 'Cubo'.");
        }

        if (cilindroObj != null)
        {
            cilindroTransform = cilindroObj.transform;
        }
        else
        {
            Debug.LogWarning("No se encontró ningún objeto con la etiqueta 'Cilindro'.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (cuboTransform != null)
        {
            float distCubo = Vector3.Distance(cuboTransform.position, transform.position);
            Debug.Log($"Distancia al Cubo: {distCubo:F2}");
        }

        if (cilindroTransform != null)
        {
            float distCilindro = Vector3.Distance(cilindroTransform.position, transform.position);
            Debug.Log($"Distancia al Cilindro: {distCilindro:F2}");
        }
    }
}
