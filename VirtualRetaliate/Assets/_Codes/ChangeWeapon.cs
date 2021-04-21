using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
    public int selectedWeapon;
    public void setWeapon(int newWeapon) 
    {
        selectedWeapon = newWeapon; // FIXME!
        Debug.Log("Select Weapon called : setWeapon " + newWeapon);
        Player.setWeapon(selectedWeapon);

    }

    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
        Debug.Log("Select Weapon called");
    }

    // Update is called once per frame
    void Update()
    {
        int prevSelectedWeapon = selectedWeapon;
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        { //index of weapon > max weapon under transform = go to index 0
            if (selectedWeapon >= transform.childCount - 1)
                selectedWeapon = 0;
            else
                ++selectedWeapon;
                
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        { //when index less than 0, go to the last index
            if (selectedWeapon <= 0)
                selectedWeapon = transform.childCount - 1;
            else
                --selectedWeapon;
        }

        //could also configure with keyboard sth like below 
        if (Input.GetKeyDown(KeyCode.Alpha0))
            selectedWeapon = 0;
        if (Input.GetKeyDown(KeyCode.Alpha1))
            selectedWeapon = 1;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            selectedWeapon = 2;
        if (Input.GetKeyDown(KeyCode.Alpha3))
            selectedWeapon = 3;
        if (Input.GetKeyDown(KeyCode.Alpha4))
            selectedWeapon = 4;

        if (prevSelectedWeapon != selectedWeapon)
             SelectWeapon(); 
    }//end update

    void SelectWeapon()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
                ++i;
        }
    }
    //from: https://www.youtube.com/watch?v=Dn_BUIVdAPg
}
