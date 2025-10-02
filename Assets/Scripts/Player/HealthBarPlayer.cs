using UnityEngine;
using UnityEngine.UI;

public class HealthBarPlayer : MonoBehaviour
{
    public Slider healthBarSlider;
    //public TextMeshProUGUI healthBarValueText;

    public int maxHealth;
    public int currentHealth;


    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        healthBarSlider.value = currentHealth;
        healthBarSlider.maxValue = maxHealth;
    }

    void TakeDamage(float damage)
    {
        healthBarSlider.value -= damage;
    }
}
