using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // ENCAPSULATION: Memanggil method publik yang dikontrol di ScoreManager
        if (other.CompareTag("Player"))
        {
            // Panggil method AddScore() via ScoreManager instance
            ScoreManager.Instance.AddScore(1);

            // Nonaktifkan collider agar tidak double-hit
            GetComponent<Collider2D>().enabled = false;
        }
    }
}