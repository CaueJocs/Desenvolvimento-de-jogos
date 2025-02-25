using UnityEngine;

public class enemyScript : MonoBehaviour
{
    private float posicaoX = 0f;
    private bool hitRight = true;
    private bool hitLeft = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        var pos = transform.position;

        if(hitRight){
            posicaoX += 0.008f;
        }
        if(hitLeft){
            posicaoX -= 0.008f;
        }
        
        pos.x = posicaoX;
        
        if (posicaoX > 8.1f){
            hitRight = false;
            hitLeft = true;
        }
        if (posicaoX < -8.1f){
            hitRight = true;
            hitLeft = false;
        }

        transform.position = pos;
    }
}
