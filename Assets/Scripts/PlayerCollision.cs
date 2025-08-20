using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class PlayerCollision : MonoBehaviour

{
    public GameManager gameManager;
    public static int LifeCounter = 2;
    public static int LocalGems = 0;
    public static bool Attack = false;
    public AudioSource audioSource;
    public AudioSource audioSource2;

    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        audioSource.Play();
        
        if (PlayerCollision.LifeCounter <= 0)
        {
            GetComponent<PlayerMovement>().enabled = false;
            FindAnyObjectByType<GameManager>().EndGame(1f);
        }
        if (collisionInfo.collider.tag == "Ice")
        {
            collisionInfo.rigidbody.AddForce(0, 4000f * Time.deltaTime, 0, ForceMode.Impulse);
            Destroy(collisionInfo.gameObject, 1.5f);
        }
        if (collisionInfo.collider.tag == "Bomb")
        {
            collisionInfo.rigidbody.AddForce(0, -500f*Time.deltaTime, 8500f * Time.deltaTime, ForceMode.Impulse);
            Destroy(collisionInfo.gameObject, 1f);
            PlayerCollision.Attack = true;
            
        }
        if (collisionInfo.collider.tag == "Obstacle")
        {
            PlayerCollision.LifeCounter--;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gem")
        {

            audioSource2.Play();
            PlayerCollision.LocalGems++;
            Destroy(other.gameObject);
        }
    }
}
