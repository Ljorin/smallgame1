using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update(
        float horizontal = Input.GetAxis("Horizontal");
        
        Vector2 movement = new Vector2(horizontal,0) * moveSpeed * Time.deltaTime;
        transform.translate(movement);
    )
}