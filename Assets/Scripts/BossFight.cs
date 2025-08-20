using System;
using UnityEngine;

public class BossFight : MonoBehaviour
{
    public static int BossHP = 3;
    public Transform player;
    public Vector3 offset;
    public GameObject Boss;
    public GameObject RedEye1;
    public GameObject RedEye2;
    public Collider BossCollider;
    public Material BombMat;
    public Rigidbody rb;
    public Collider PlayerCollider;
    public GameObject PlayerGO;


    private void FixedUpdate()
    {
        
    }
    void Update()
    {
        Debug.Log(BossFight.BossHP);
        if (BossFight.BossHP > 0)
        {
            Boss.transform.position = player.position + offset;
        }
        else
        {
            BossCollider.isTrigger = false;
            player.GetComponent<Renderer>().material = BombMat;
            PlayerCollider.transform.localScale = new Vector3(2, 2, 2);
            PlayerCollider.transform.localScale = new Vector3(3, 3, 3);
            PlayerCollider.transform.localScale = new Vector3(4, 4, 4);
            PlayerCollider.transform.localScale = new Vector3(5, 5, 5);
            rb.AddForce(0, 0, 500f * Time.deltaTime, ForceMode.Impulse);
        }
    }
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Bomb") && PlayerCollision.Attack)
        {
            BossFight.BossHP--;
            Evil();
            Invoke("Neutral", 1f);
            PlayerCollision.Attack = false;
        }
        
        if (other.tag == "Obstacle")
        {
            Evil(); 
        }
        if (other.tag == "Gem")
        {
            Neutral();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Boss")
        {
            Invoke("Kill", 0.5f);
        }
    }

    private void Evil()
    {
        RedEye1.SetActive(true);
        RedEye2.SetActive(true);
    }
    private void Neutral()
    {
        RedEye1.SetActive(false);
        RedEye2.SetActive(false);
    }
    private void Kill()
    {
        Boss.SetActive(false);
    }
}
