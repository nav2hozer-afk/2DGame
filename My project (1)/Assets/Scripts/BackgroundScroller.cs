using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float speed = 5f; 

    void Update()
    {
        
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}