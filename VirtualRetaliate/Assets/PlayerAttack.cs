using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

	public Camera cam;
	public GameObject Hand;
	public Weapon myWeapon;
    // Start is called before the first frame update
    void Start()
    {
        myWeapon = Hand.GetComponentInChildren<Weapon>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0)){
        	DoAttack();
        }
    }

    private void DoAttack(){
    	Ray ray = cam.ScreenPointToRay(Input.mousePosition);
    	RaycastHit hit;

    	if(Physics.Raycast(ray, out hit, myWeapon.attackRange)){
    		if(hit.collider.tag == "Enemy"){
    			EnemyHealth eHealth = hit.collider.GetComponent<EnemyHealth>();
    			eHealth.TakeDamage(myWeapon.attackDamage);
    		}
    	}
    }
}
