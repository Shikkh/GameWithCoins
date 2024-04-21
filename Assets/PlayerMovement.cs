using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;

    public float runSpeed = 5f;
    public float strafeSpeed = 5f;
    public float jumpForce = 7f;

   public void FixedUpdate()
   {
        transform.Translate(-runSpeed * Time.deltaTime, 0, 0);
   }
    public void OnLeftButtonDown()
    {
        rb.velocity = Vector3.back * strafeSpeed;
    }
    public void OnRightButtonDown()
    {
        rb.velocity = Vector3.forward * strafeSpeed;
    }
    public void OnJumpButtonDown()
    {
        rb.velocity = Vector3.up * jumpForce;
    }
}

