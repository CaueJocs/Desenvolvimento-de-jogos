using UnityEngine;


public class ballMove : MonoBehaviour
{   
    private Rigidbody2D rb2d;
    public AudioSource source;

    
    void GoBall(){                      
        float rand = Random.Range(0f, 2f);
        if(rand < 1f){
            rb2d.AddForce(new Vector2(0, -15));
        } else {
            rb2d.AddForce(new Vector2(0, 15));
        }
    }

    public float getBallX(){
        return transform.position.x;
    }
    public float getBallY(){
        return transform.position.y;
    }


    void OnCollisionEnter2D (Collision2D coll) {
        source.Play();
    }


    void Start()
    {
        source = GetComponent<AudioSource>();
        rb2d = GetComponent<Rigidbody2D>(); // Inicializa o objeto bola
        Invoke("GoBall", 2);    // Chama a função GoBall após 2 segundos
    }
    
    void ResetBall(){
        rb2d.linearVelocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    // Reinicializa o jogo
    void RestartGame(){
        ResetBall();
        Invoke("GoBall", 1);
    }


    void Update()
    {
        
    }
}
