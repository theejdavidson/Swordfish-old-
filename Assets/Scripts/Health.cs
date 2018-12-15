using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public const int maxHP = 100;
    public int currentHP;
    Controls controls;
    bool isDead;
    bool damaged;
    UI_Behavior uI;
    // Use this for initialization
    void Awake()
    {
        controls = GetComponent<Controls>();
        currentHP = maxHP;
        uI = GameObject.FindGameObjectWithTag("UI").GetComponent<UI_Behavior>();
    }

    // Update is called once per frame
    void Update()
    {

        if(damaged)
        {
           
        }
        else
        {

        }
    }
    public void TakeDam(int amount)
    {
        damaged = true;
        currentHP -= amount;
        uI.updateHP(currentHP);
        if (currentHP <= 0 && !isDead)
        {
            Death();
        }
    }
    void Death()
    {
        isDead = true;
        controls.enabled = false;
    }
}