using UnityEngine;
using System.Collections;

public class AttackEnemy : MonoBehaviour
{
    private Renderer myRenderer;
    private BoxCollider hitBox;

	// Use this for initialization
	void Start ()
    {
        myRenderer = GetComponent<Renderer>();
        hitBox = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            //GetComponent<Animation>().Play();
            myRenderer.enabled = true;
            hitBox.enabled = true;
        }
        else
        {
            myRenderer.enabled = false;
            hitBox.enabled = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (/*Input.GetButton("Fire1") && */other.tag.Equals("Enemy"))
        {
            if(other.GetComponent<EnemyHealth>().TakeDamage(1))
            {
                //slash!
            }
            else
            {
                //ting!
            }
        }
    }
}
