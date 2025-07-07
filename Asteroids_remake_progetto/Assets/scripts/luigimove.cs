using UnityEngine;

public class luigi_move : MonoBehaviour
{
    public float V = 100;
    private bool isGrounded = true;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 3);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 3);
        }

        if (Input.GetKey(KeyCode.UpArrow) && isGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * V * Time.deltaTime, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // This assumes anything Luigi collides with is ground. You can customize with tags.
        isGrounded = true;
    }
}