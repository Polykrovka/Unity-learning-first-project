using Unity.VisualScripting;
using UnityEngine;

public class FollowPlayer: MonoBehaviour
{
    public GameObject player;
    private Vector3 offset1 = new Vector3(0, 2, 1);
    private Vector3 offset2 = new Vector3(0, 5, -10);
    private bool isViewButtonPressed = false;

// Update is called once per frame
void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            isViewButtonPressed = !isViewButtonPressed;
        }

        if(isViewButtonPressed)
        {
            transform.position = player.transform.position + offset1;
        }
        else
        {
            transform.position = player.transform.position + offset2;
        }
        
        

    }
}
