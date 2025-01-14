using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int initialHealth = 100;
    [SerializeField] GameObject _displayHealth;
    int health;
    public int Health { get { return health; } private set { } }
    // Start is called before the first frame update
    void Start()
    {
        health = initialHealth;
        _displayHealth.GetComponent<HealthDisplay>().SetMaxHealth(initialHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GetHurt(int damage)
    {
        health = health - damage;
        _displayHealth.GetComponent<HealthDisplay>().SetHealth(health);

    }

}
