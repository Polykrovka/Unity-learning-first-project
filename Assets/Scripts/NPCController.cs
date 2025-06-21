using UnityEngine;

public class NPCController : MonoBehaviour
{
    private float speed = 7f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
