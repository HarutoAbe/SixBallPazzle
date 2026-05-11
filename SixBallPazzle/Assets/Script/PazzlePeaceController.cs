using UnityEngine;

public class PazzlePeaceController : MonoBehaviour
{
    [Header("RigidbodyÇÃê›íË")]
    [SerializeField] private Rigidbody playerRigidbody = default;

    [Header("ínñ Ç…Ç¬Ç¢ÇΩÇ©Ç«Ç§Ç©ÇÃîªíË")]
    [SerializeField] private bool isGrounded = false;

    private void Start()
    {
        //GameObject gameObject = GameObject.Find("PazzlePeace");

        //transform.DetachChildren();

        //Destroy(gameObject);


    }

    private void Update()
    {


        if (!isGrounded)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 2.0f);

            Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

            playerRigidbody.linearVelocity = input * 5f;

        }





    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
