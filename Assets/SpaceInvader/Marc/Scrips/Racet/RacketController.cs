using UnityEngine;

public class RacketController : MonoBehaviour
{
    float input;

    public float movementSpeed = 5f;

    private Rigidbody2D rb2D; // default = null

    public float BulletOffset;
    public GameObject BulletObj;

    private IInput inputController;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        inputController = GetComponent<IInput>();
    }

    void Update()
    {
        input = inputController.GetInput();


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(BulletObj, new Vector3(transform.position.x, transform.position.y + BulletOffset), Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
        rb2D.velocity = Vector2.right * input * movementSpeed;
    }
}
