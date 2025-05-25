using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerCollection : MonoBehaviour
{
    private int _score = 0;
    public TMP_Text scoreText;
    public TMP_Text hiveText;
    private Collider2D _touching;
    public ParticleSystem beeParticles;
    

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
        
        // spawn one bee every 10 points
        int remainder = _score % 10; // will give back the remainder of score/10
        if (remainder == 0)
        {
            beeParticles.Emit(1);
           
        }
        
        scoreText.text = $"<b>HONEY :</b> {_score}";
        
    }
    
}
