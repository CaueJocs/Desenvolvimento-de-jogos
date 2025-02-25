using UnityEngine;

public class playerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var pos = transform.position;
        pos.x = mousePos.x;
        pos.y = mousePos.y;
        Debug.Log(pos.y);
        if (pos.y> 0f) {
            pos.y = 0f;
        }
        if (pos.y< -8.5f) {
            pos.y = -8.5f;
        }
        if (pos.x > 8.1f){
            pos.x = 8.1f;
        }
        if (pos.x < -8.1f){
            pos.x = -8.1f;
        }
        transform.position = pos;

    }
}
