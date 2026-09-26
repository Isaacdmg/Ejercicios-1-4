using UnityEngine;

public class ScriptEjercicio1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int framesToWait = 120;
    private int counter = 0;
    private Renderer objectRenderer;
    public Vector3 colorVector3 = new Vector3();
    private void ApplyColor()
    {
        Color newColor = new Color(colorVector3.x, colorVector3.y, colorVector3.z);

        objectRenderer.material.color = newColor;
    }
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        colorVector3.x = Random.Range(0f, 1f);
        colorVector3.y = Random.Range(0f, 1f);
        colorVector3.z = Random.Range(0f, 1f);

        ApplyColor();
    }

    // Update is called once per frame
    void Update()
    {
        counter++;

        if (counter >= framesToWait)
        {
            counter = 0;
            int randomIndex = Random.Range(0, 3);
            colorVector3[randomIndex] = Random.Range(0f, 1f);
            ApplyColor();
        }
        
    }
}
