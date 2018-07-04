using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (menuName ="Enemy/EnemyA")]
public class EnemyA : Enemy {

    public float Attack;
    public float Health;
    public float Speed;

    public enemyMovement enemy;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public override void Spawn(GameObject obj)
    {
        enemy = obj.GetComponent<enemyMovement>();
        enemy.Attack = Attack;
        enemy.Health = Health;
        enemy.Speed = Speed;
        aSprite = enemy.sprite;
        aBasecooldown = enemy.attackCooldown;



    }

   
}
