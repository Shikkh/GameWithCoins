using UnityEngine;

public class GameEnding : MonoBehaviour
{
    [SerializeField]private GameManager gameManager;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            gameManager.GameEnding();
        }
    }
    public void FixedUpdate()
    {
        if (transform.position.y < -5f)
        {
            gameManager.GameEnding();
        }
    }
}
