using System;
using System.Runtime.InteropServices.ComTypes;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerCollection : MonoBehaviour
{
    private int score = 0;
    public TMP_Text scoreText;
    private Collider2D touching;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectable"))
        {
            touching = other;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other == touching)
        {
            touching = null;
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (touching != null)
        {
            AddScore(1);
                touching = null;
        }
    }

    private void AddScore(int points)
    {
        score = score + points;
        scoreText.text = $"<b>Score:</b> {score}";
    }
}
