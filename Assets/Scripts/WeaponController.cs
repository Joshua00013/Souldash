using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class WeaponControlller : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private Transform weapon;
    [SerializeField] private float weaponDistance = 1.5f;
    // Update is called once per frame

    void LateUpdate()
    {
        HandleWeapon();
    }
    void Update()
    {

    



        if(Input.GetKeyDown(KeyCode.Mouse0))
            Attack();
    }

    public void Attack()
    {
        Debug.Log("Attack");
    }

    public void HandleWeapon()
    {
        if (weapon == null)
        {
            Debug.LogError("Weapon reference is missing! Check Inspector.");
            return;
        }

        Vector3 mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.transform.position.z * -1));
        Vector3 lookDir = mousePos - transform.position;

        weapon.rotation = Quaternion.Euler (new Vector3(0, 0, Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg));
        // Debug.Log(mousePos);
        
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        weapon.position = transform.position + Quaternion.Euler(0, 0, angle) * new Vector3(weaponDistance, 0, 0);
    }
}

