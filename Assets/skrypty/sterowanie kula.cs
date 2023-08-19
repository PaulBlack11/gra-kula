using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("Control Settings")]

    [SerializeField]
    private float speed = 1f;

   
    private Rigidbody rb;
    private bool isRigidbody;



    // Start is called before the first frame update
    void Start()
    {
        isRigidbody = TryGetComponent<Rigidbody>(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        float Hdirection;
        float Vdirection;


        if (isRigidbody && (Hdirection = Input.GetAxis("Horizontal")) != 0)
         
        {
            rb.AddTorque(0, 0, -Hdirection * Time.deltaTime * speed);
        }

        if (isRigidbody && (Vdirection = Input.GetAxis("Vertical")) != 0)


        {
            rb.AddTorque(Vdirection * Time.deltaTime * speed, 0, 0);
        }



    }
}
