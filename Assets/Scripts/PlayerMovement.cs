using JetBrains.Annotations;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 5500f;
    public float sidewaysForce = 95f;
    // FixedUpdate bc we use it for physics
    void FixedUpdate()
    {


        if (Settings.casuals == false)
        {
            sidewaysForce += 30f;
            forwardForce += 200f;
        }
        // add a forward force  
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (rb.position.y < -1f)
        {
            FindFirstObjectByType<GameManager>().EndGame(1f);
        }
        if (rb.position.y > 1.5f)
        {
            rb.AddForce(0, -300f * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        
    }
    
}
