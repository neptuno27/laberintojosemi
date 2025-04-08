using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour //monobehaviour significa que trabaja sólo en el juego
{
    public float speed = 4f; // velocidad
    public float speedJump = 15f; // velocidad de salto
    private Rigidbody playerb; // rigidbody
    private Vector3 moveInput; // el input en 3D
    void Start()
    {
        playerb = GetComponent<Rigidbody>(); // pillamos el rigidbody para poder movernos
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        moveInput = new Vector3(moveX, 0, moveZ);

    }
    private void FixedUpdate()
    {
        playerb.MovePosition(playerb.position + moveInput.normalized * speed * Time.fixedDeltaTime); // movimiento fluido
    }
}

