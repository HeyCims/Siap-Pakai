using UnityEngine;

public class TestClickUnity : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Debug.Log("Test");
    }
private void OnMouseUp()
    {
        Debug.Log("Sprite click: " + gameObject.name);
    }
}

