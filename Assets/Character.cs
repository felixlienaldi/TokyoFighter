using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character {

    [SerializeField] private float _attack, _health, _stamina;


    public float attack {
        get {
            return _attack;
        }
        set {
            _attack = value;
        }
    }

    public float health {
        get {
            return _health;
        }
        set {
            _health = value;
        }
    }

    public float stamina {
        get {
            return _stamina;
        }
        set {
            _stamina = value;
        }
    }
}
