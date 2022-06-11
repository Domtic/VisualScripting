using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class Character : MonoBehaviour
{
    private Rigidbody2D _rb2D;
    private SpriteRenderer _sprite;
    private Animator _anim;
    [SerializeField, Range(0.01f, 15f)]
    private float _moveSpeed;
    [SerializeField, Range(0.01f, 15f)]
    private float _jumpForce;

    public float MoveSpeed { get => _moveSpeed; set => _moveSpeed = value; }
    public float JumpForce { get => _jumpForce; set => _jumpForce = value; }

    private void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();

    }

    public Rigidbody2D RigidBodi2D => _rb2D;
    public SpriteRenderer Spr { get => _sprite; set => _sprite = value; }
    public Animator Animator { get => _anim; set => _anim = value; }
}
