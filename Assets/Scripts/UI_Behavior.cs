using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Behavior : MonoBehaviour {
    public Text waveCounter, enemyCounter;
    public Slider HP;
    //WaveDelay is how long the "Wave X" text stays on screen, in frames
    public int maxHP, waveDelay;
    private int waveNumber, wDCounter;
    private float waveTextOpacity;
    private bool isNewWave, isTextFadingIn;

    // Use this for initialization
    void Start () {
        waveNumber = 0;
	} 
	
	// Update is called once per frame
	void Update () {
		if(isNewWave)
        {
            if (isTextFadingIn)
            {
                waveTextOpacity += 0.01F;
                if(waveTextOpacity >= 1)
                {
                    wDCounter++;
                        if(wDCounter >= waveDelay)
                    {
                        isTextFadingIn = false;
                    }
                }
            }
            else
            {
                waveTextOpacity -= +0.01F;
            }
            waveCounter.color = new Color(0.2535F, 0.5540F, 0.6981F, waveTextOpacity);
            if (waveTextOpacity <= 0)
            {
                isNewWave = false;
            }
        }
	}

    public void updateHP(int newHp)
    {
        HP.value = newHp / maxHP;
    }

    public void newWaveNotification()
    {
        waveNumber++;
        waveCounter.text = "Wave " + waveNumber;
        isNewWave = true;
        isTextFadingIn = true;
    }

    public void updateEnemies(int newEnemyNum)
    { 
    
        enemyCounter.text = "" + newEnemyNum;
    }
}
