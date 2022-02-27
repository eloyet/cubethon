using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
  /*  void Start()
    {
        rb.useGravity = false;
    }
    */
    // Update is called once per frame

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  // forward force = 200 
    
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce* Time.deltaTime  ,0 ,0);
        }
            
            if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce* Time.deltaTime  ,0 ,0);
        }
    }
}
