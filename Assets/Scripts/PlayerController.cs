using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * turnSpeed);
    }
}
