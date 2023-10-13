using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    private Player player;
    private float footStepTimer;
    private float footTimerMax = .1f;


    private void Awake()
    {
        player = GetComponent<Player>();
    }


    private void Update()
    {
        footStepTimer -= Time.deltaTime;

        if(footStepTimer < 0)
        {
            footStepTimer = footTimerMax;

            if (player.IsWalking())
            {
                float volume = 1f;
                SoundManager.Instance.PlayFootStepSound(player.transform.position, volume);
            }
            
        }
    }


}
