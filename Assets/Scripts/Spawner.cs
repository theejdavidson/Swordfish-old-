using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public int max = 0;
    public int enemyNum = 0;
    private float timer = 0f;//initializes timer variable
    private float spawn = 2f;
    public static int wave;
    public GameObject enemy;
    public UI_Behavior uI;
   
    // Use this for initialization
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");

        wave = 0;
        uI = GameObject.FindGameObjectWithTag("UI").GetComponent<UI_Behavior>(); 
       
    }

    // Update is called once per frame
    void Update()
    {
        uI.updateEnemies(GameObject.FindGameObjectsWithTag("Enemy").Length);
        timer += Time.deltaTime;//smoothes timer by adding one per second
        
        if (timer >= spawn && max < 100)
        {
            SpawnEnemy();
            timer = 0f;
        }

    }

    void SpawnEnemy()
    {
        if (enemy != null)
        {
            var enemyClone = (GameObject)Instantiate(enemy, transform.position, transform.rotation);//this line makes a new enemy
            max++;
            enemyNum++;
            // wave++;
            //uI.newWaveNotification();

        }
    }
    void TrackKilled()//method to track the number of enemies killed within the wave
    {

    }

}