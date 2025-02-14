using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] int damage = 10;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Player>().GetHurt(damage);
            Destroy(this.gameObject);
        }
        else
        {
            other.gameObject.GetComponent<Ally>().GetHurt(damage);
            Destroy(this.gameObject);
        }

    }
}
