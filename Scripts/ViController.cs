using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViController : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;
    public AudioClip buttonSound;

    private int animationIndex = 0;
    private readonly string[] animations = { "Arm", "Punch", "Bored", "Threatening", "Standing", "Kiss" };

   public void PlayAnimation()
    {
        animationIndex++;

        if (animationIndex >= animations.Length)
        {
            animationIndex = 0;
        }

        PlayAnimationByName(animations[animationIndex]);
        PlayButtonSound();
    }

    private void PlayAnimationByName(string animationName)
    {
        ResetAnimations();
        if (animationName != "Idle")
        {
            animator.SetBool(animationName, true);
        }
    }

    private void ResetAnimations()
    {
        foreach (string animation in animations)
        {
            animator.SetBool(animation, false);
        }
    }

    private void PlayButtonSound()
    {
        if (audioSource != null && buttonSound != null)
        {
            audioSource.PlayOneShot(buttonSound);
        }
    }
}