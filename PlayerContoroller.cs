using UnityEngine;

public class PlayerContoroller : MonoBehaviour
{
    public float wallkspeed = 10f;
    public Rigidbody wallk;
    public float jumpForce = 20f;
    
    void Start()
    {
        wallk = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            wallk.AddForce(-wallkspeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            wallk.AddForce(wallkspeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            wallk.AddForce(0, 0, wallkspeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            wallk.AddForce(0, 0, -wallkspeed);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            wallk.AddForce(0, jumpForce, 0);
        }
    }
}
