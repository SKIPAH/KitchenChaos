using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerAnimator : NetworkBehaviour
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
        if (!IsOwner)
        {
            return;
        }
        animator.SetBool(IS_WALKING, player.IsWalking());
    }


}
