using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdmovement1 : MonoBehaviour
{
    // Start is called before the first frame update*
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed = 5f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    void Start()
    {
        if (_rigidbody == null)
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = Vector2.zero;
            _rigidbody.AddForce(new Vector2(0f, _speed), ForceMode2D.Impulse);
        }
      
    }
}
