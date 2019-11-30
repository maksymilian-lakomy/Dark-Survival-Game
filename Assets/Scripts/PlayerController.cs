using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour {

    private Rigidbody2D rigidbody2D;
    private Animator animator;

    public float speed = 1f;

    public bool IsMoving = false;

    [SerializeField] private Vector3 eyesPosition;
    [SerializeField] private float viewDistance = 1f;
    [SerializeField] private int direction = 1;
    
    private void Awake() {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    private void FixedUpdate() {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (Mathf.Abs(rigidbody2D.velocity.x) < speed)
            rigidbody2D.AddForce(new Vector2(input.x*5f, 0f));
        
        if (Mathf.Abs(rigidbody2D.velocity.y) < speed)
            rigidbody2D.AddForce(new Vector2(0f, input.y*5f));
        
        animator.SetFloat("movement", rigidbody2D.velocity.magnitude);
        if (rigidbody2D.velocity.magnitude > 0.1f)
            IsMoving = true;
        else
            IsMoving = false;

        if (input.x > 0)
            direction = 1;
        else if (input.x < 0)
            direction = -1;
        
        animator.SetInteger("direction", direction);
        
        if (input.x == 0f)
            rigidbody2D.velocity = Vector2.Lerp(rigidbody2D.velocity, new Vector2(0, rigidbody2D.velocity.y),
                                                Time.deltaTime * 5f);
        if (input.y == 0f)
            rigidbody2D.velocity = Vector2.Lerp(rigidbody2D.velocity, new Vector2(rigidbody2D.velocity.x, 0f),
                                                Time.deltaTime * 5f);
        
        
        RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position + eyesPosition, transform.right * direction, viewDistance);
        
        if (hits.Length == 0)
            WorldUIManager.i.CleanActiveObject();
        
        foreach (RaycastHit2D hit in hits) {
            if (hit.collider != null && hit.collider.isTrigger == false) {
                GameObject newActiveObject = hit.collider.gameObject;
                WorldUIManager.i.SetActiveObject(newActiveObject);
                break;
            }
        }
        Debug.DrawRay(transform.position + eyesPosition, transform.right * viewDistance * direction, Color.red);
    }
}
