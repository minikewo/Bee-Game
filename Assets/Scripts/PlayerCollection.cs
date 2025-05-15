using System.Runtime.InteropServices.ComTypes;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerCollection : MonoBehaviour
{
    private int score = 0;
    public TMP_Text scoreText;

    private void OnTrggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            AddScore(points: 1);
            Destroy(other.gameObject);
        }
    }

    private void AddScore(int points)
    {
        score = score + points;
        scoreText.text = $"<b>Score:</b> {score}";
    }
}
