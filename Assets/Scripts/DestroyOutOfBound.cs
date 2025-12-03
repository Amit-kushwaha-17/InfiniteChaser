using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float TopBound = 30;
    private float LowerBound = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
