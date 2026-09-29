using UnityEngine;
using TMPro;
public class SciptEjercicio3 : MonoBehaviour
{
    private Transform position;
    private TMP_Text text_box;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = GetComponent<Transform>();
        text_box = GetComponentInChildren<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = position.position;
        if(text_box != null)
        {
            text_box.text = $"Position: {pos.x:F2}, {pos.y:F2}, {pos.z:F2}";
        }
    }
}
