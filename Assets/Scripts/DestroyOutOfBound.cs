using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float TopBound = 30;
    private float LowerBound = -10;
    private float RightBound = 24;
    private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > TopBound)
        {
            
            Destroy(gameObject);
        }
        else if(transform.position.z <LowerBound)
        {
            gameManager.AddLive(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > RightBound || transform.position.x < -RightBound)
        {
            gameManager.AddLive(-1);
            Destroy(gameObject);
        }
      
        
    }
}
