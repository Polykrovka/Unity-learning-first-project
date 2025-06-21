using UnityEngine;

public class PropellerRotation : MonoBehaviour
{   
    private float rotationSpeed = 500f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
    }
}
