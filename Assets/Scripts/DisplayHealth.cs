using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using StarterAssets;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour
{
    
    public GameObject player;
    public TMP_Text display;
    PlayerHealth healthSystem;
    private Image healthBarImage;

    void Start()
    {
        healthSystem = player.GetComponent<PlayerHealth>();
        healthBarImage = GetComponent<Image>();
    }

    void Update()
    {
        display.text = healthSystem.health.ToString();
        healthBarImage.material.color = new Vector4(Mathf.Round((100f - healthSystem.health) * 2.55f),Mathf.Round(healthSystem.health * 2.55f),0,100);
    }
}