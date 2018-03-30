//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Enemy : MonoBehaviour {

//    Character enemy = new Character();
//    public Player pl;
//    Rigidbody2D rb;

//    void Start() {
//        FindObjectOfType<Player>();
//        enemy.attack = 10f;
//        enemy.health = 10f;
//        Debug.Log(enemy.attack + " " + enemy.health);
//    }

//    void Update() {

//    }

//    void OnCollisionEnter2D() {
//        pl.player.health -= enemy.attack;
//        Debug.Log(pl.player.health + " " + pl.player.stamina);
//        Destroy(gameObject);
//    }

//}

using UnityEngine;

public abstract class Enemy : ScriptableObject
{
    public Sprite aSprite;
    public float aBasecooldown = 1f;
    public string aName = "New Enemy";

    public abstract void Spawn(GameObject obj);
  

}