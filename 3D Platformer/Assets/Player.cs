using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;

    public void TakeDamage(int damage)
    {
        if (health > 0) ;
        {
            health -= damage;
            audioSource.PlayOneShot(damageSound);
        }
        else
        }
             int sceneIndex = sceneManager.GetActiveScene().buildIndex;
             sceneManager.LoadScene(sceneIndex);
        }
public AudioSource audioSource;

public AudioClip damageSound;