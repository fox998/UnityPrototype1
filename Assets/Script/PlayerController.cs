using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _Speed = 5.0f;
    public float _TurnSpeed = 5.0f;

    private float _HorizontalInput = 0;
    private float _ForvardInput = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _HorizontalInput = Input.GetAxis("Horizontal");
        _ForvardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * _Speed * _ForvardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * _TurnSpeed * _HorizontalInput);
    }
}
