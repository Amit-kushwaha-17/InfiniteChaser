using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontolInput; //get Left/Right input from user  
    public float speed; //get Speed of Player
    public float Xrange= 10;
    public GameObject projectilePrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontolInput = Input.GetAxis("Horizontal");
        if (transform.position.x < -Xrange) //Putting condition so player don't go beyond -10
            //seting player to -10 position if he reach there
           transform.position = new Vector3(-10,transform.position.y,transform.position.z);

        if (transform.position.x > Xrange)
            transform.position = new Vector3(10, transform.position.y, transform.position.z);

        //set the Input Get from user between -1 to 1 
        transform.Translate(Vector3.right * horizontolInput * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //We Launch the projectile
            Instantiate(projectilePrefabs, transform.position, projectilePrefabs.transform.rotation);
          
        }

    }
}
