using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
   public Slider P1Fill;
   public float P1FillHealth;
    public Gradient gradient;
    public void SetMaxHealth(float p1HP)
    {
        P1Fill.maxValue = P1FillHealth;
        P1Fill.value = P1FillHealth;
    }
    public void SetHealth(){
        P1Fill.value = P1FillHealth;
    }

    internal void SetHealth(float p1CurrentHealth)
    {
        throw new NotImplementedException();
    }
}
