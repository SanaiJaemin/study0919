using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector3 movevec;
    public PlayerInput _playerInput;
    [SerializeField]
    private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        movevec = new Vector3(_playerInput.X, 0f, _playerInput.Z).normalized;

        transform.position += (movevec * moveSpeed) * Time.deltaTime;
    }
}
