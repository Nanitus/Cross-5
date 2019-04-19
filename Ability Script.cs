using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_AbilityGain : MonoBehaviour
{

    private Animator Animation;     // Enables animations

    private void Start()
    {
        // What object needs to be animated to look for
        Animation = GameObject.FindWithTag("Player").GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If player collides with ability orb, give ability to player
        if (collision.gameObject.tag == "AbilityPowerUp")
        {
            Animation.SetBool("DashPower", true);
        }
    }
}