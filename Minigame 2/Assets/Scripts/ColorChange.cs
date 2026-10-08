using UnityEngine;
using TMPro;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private int health = 4;

    private void Start()
    {
        _healthText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Here, we are going to change the value of 'health',
        // and, as a result, change the color of the prop and the text above the prop.

        // STEP 3
        health -= 1;

        // STEP 4
        float r = 1;

        // STEP 5
        if (health == 0)
        {
            gameObject.SetActive(false);
        }
        else if (health == 3)
        {
            r = 1.0f;
        }
        else if (health == 2)
        {
            r = 0.5f;
        }
        else if (health == 1)
        {
            r = 0.0f;
        }

        _spriteRenderer.color = new Color(r, 0.2f, 0.2f);

        _healthText.gameObject.SetActive(true);

        // STEP 6
        _healthText.text = "h = " + health;
    }
}