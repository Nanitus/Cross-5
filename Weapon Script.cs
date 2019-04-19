using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_WeaponGain : MonoBehaviour
{

    private Animator Animation;     // Enables animations

    private void Start()
    {
        // What object needs to be animated to look for
        Animation = GameObject.FindWithTag("Player").GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If player collides with weapon orb, give weapon to player
        if (collision.gameObject.tag == "WeaponPowerUp")
        {
            Animation.SetBool("WeaponPower", true);
        }
    }
}