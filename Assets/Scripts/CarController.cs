using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    private int delta;
    private float movement;
    //  public Rigidbody2D CarBody;
    //  public Rigidbody2D FrontWheel;
    //   public Rigidbody2D RearWheel;
    //  public float Speed = 100;
    //  public float CarTorque = 100;
    //   private Transform trans;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // movement = -Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {

        if (transform.rotation.eulerAngles.z > 180 && transform.rotation.eulerAngles.z < 320 ) 
        {
            print(transform.rotation.eulerAngles.z);
            SceneManager.LoadScene("sa");
        }
        //  FrontWheel.AddTorque(movement * Speed * Time.fixedDeltaTime);   
        // RearWheel.AddTorque(movement * Speed * Time.fixedDeltaTime);   
        //  CarBody.AddTorque(movement * CarTorque * Time.fixedDeltaTime);  
    }


}
