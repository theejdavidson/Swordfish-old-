using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Tests : MonoBehaviour {
    public UI_Behavior testedBehaviors;
	// Use this for initialization
	void Start () {
        testedBehaviors.newWaveNotification();
        testedBehaviors.updateEnemies(69);
        testedBehaviors.updateHP(18);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
