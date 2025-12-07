using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontolInput; //get Left/Right input from user  
    public float speed; //get Speed of Player
    private float Xrange= 10;
    private float Zminrange = -4;
    private float Zmaxrange= 6;
    public GameObject projectilePrefabs;
    private float verticalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontolInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if (transform.position.x < -Xrange) //Putting condition so player don't go beyond -10
            //seting player to -10 position if he reach there
           transform.position = new Vector3(-Xrange,transform.position.y,transform.position.z);
        if (transform.position.x > Xrange )
            transform.position = new Vector3(Xrange, transform.position.y, transform.position.z);
        //Vertical Position
        if (transform.position.z < Zminrange)
            transform.position = new Vector3(transform.position.x, transform.position.y, Zminrange);
        if(transform.position.z > Zmaxrange)
            transform.position = new Vector3(transform.position.x, transform.position.y, Zmaxrange);

        //set the Input Get from user between -1 to 1 
        transform.Translate(Vector3.right * horizontolInput * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //We Launch the projectile
            Vector3 placefood = new Vector3(transform.position.x, transform.position.y, transform.position.z+1);
            Instantiate(projectilePrefabs, placefood, projectilePrefabs.transform.rotation);
          
        }
     
    }
}
