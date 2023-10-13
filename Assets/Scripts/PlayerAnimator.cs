using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private Player player;

    private const string IS_WALKING = "isWalking";
    private void Awake()
    {
        animator = GetComponent<Animator>();
       
    }

    private void Update()
    {
        animator.SetBool(IS_WALKING, player.IsWalking());
    }


}
