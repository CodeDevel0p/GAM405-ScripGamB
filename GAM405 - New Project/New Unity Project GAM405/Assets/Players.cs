using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : Actor, ITakesDamage
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Transform>().Translate(Vector3.forward * 10 * Time.smoothDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Transform>().Translate(Vector3.back * 10 * Time.smoothDeltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       

        Actor actor = collision.gameObject.GetComponent<Players>();
        if (actor == null)
        {
            actor.health--;
        }
    }

    public void TakeDamage(float x)
    {
        GameManager.instance.OnPlayerDamage();
    }
}
