using System;
using System.Runtime.InteropServices.ComTypes;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerCollection : MonoBehaviour
{
    private int _score = 0;
    public TMP_Text scoreText;
    private Collider2D _touching;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectable"))
        {
            _touching = other;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other == _touching)
        {
            _touching = null;
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (_touching != null)
        {
            AddScore(1);
                _touching = null;
        }
    }

    private void AddScore(int points)
    {
        _score = _score + points;
        scoreText.text = $"<b>Score:</b> {_score}";
    }
}
