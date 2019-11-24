using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthController : MonoBehaviour
{
    public Slider HealthbarSlider;
    public int CurrentHealth;
    public int MaxHealth;
    public Text healthText;
    bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthbarSlider.maxValue = MaxHealth;
        HealthbarSlider.value = CurrentHealth;
        healthText.text = CurrentHealth.ToString() + " /" + MaxHealth.ToString();


        if (CurrentHealth <= 0)
        {
            if (isDead)
            {
                return;

            }
            Dead();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CurrentHealth -= 10;
        }
    }

    void Dead()
    {
        isDead = true;
    }
}
