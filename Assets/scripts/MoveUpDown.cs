using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    public float movementDistance = 3f;
    public float speed = 2f;
    public bool isActive = true;

    private Vector3 startPosition;
    private bool goingUp = true;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (!isActive)
            return;

        if (goingUp)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);

            if (transform.position.y >= startPosition.y + movementDistance)
            {
     

                goingUp = false;
            }
        }
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);

            if (transform.position.y <= startPosition.y)
            {

                goingUp = true;
            }
        }
    }
}
