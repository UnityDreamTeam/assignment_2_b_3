using UnityEngine;

public class Mover_Player2 : MonoBehaviour
{
    [Tooltip("Step size")]
    [SerializeField]
    float step = 0.10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    //Movement function using the arrow keys
    private void MovePlayer()
    {
        Vector3 move = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            move.y = step;
        }
        else if ((Input.GetKey(KeyCode.S)))
        {
            transform.position -= new Vector3(0, step, 0);
            move.y = -step;
        }
        else if ((Input.GetKey(KeyCode.D)))
        {
            move.x = step;
        }
        else if ((Input.GetKey(KeyCode.A)))
        {
            move.x = -step;
        }

        transform.position += move;
    }
}
