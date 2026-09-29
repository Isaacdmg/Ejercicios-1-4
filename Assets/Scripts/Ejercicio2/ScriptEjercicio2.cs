using UnityEngine;

public class ScriptEjercicio2 : MonoBehaviour
{
    public Vector3 myVector1;
    public Vector3 myVector2;

    private Vector3 previousVector1;
    private Vector3 previousVector2;
    private float magnitude1;
    private float magnitude2;
    private float angle;
    private float distance;
    private string HighestVector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(myVector1 != previousVector1 || myVector2 != previousVector2)
        {
            previousVector1 = myVector1;
            previousVector2 = myVector2;
            magnitude1 = myVector1.magnitude;
            magnitude2 = myVector2.magnitude;

            angle = Vector3.Angle(myVector1, myVector2);
            distance = Vector3.Distance(myVector1, myVector2);

            if (myVector1.y > myVector2.y)
            {
                HighestVector = "El vector 1 es el más alto";
            }
            else if (myVector2.y > myVector1.y)
            {
                HighestVector = "El vector 2 es el más alto";
            }
            else
            {
                HighestVector = "Los vectores tienen la misma altura";
            }
        
        
            Debug.Log($"Magnitud del vector 1: {magnitude1}");
            Debug.Log($"Magnitud del vector 2: {magnitude2}");
            Debug.Log($"Ángulo entre los vectores: {angle}");
            Debug.Log($"Distancia entre los vectores: {distance}");
            Debug.Log(HighestVector);
        }
       
    }
}
