/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool inventoryEnabled;
    public GameObject inventory;

    private int allSlots;
    private int enabledSlots;
    private GameObject[] slot;

    public GameObject slotHoldedr;
    void Start()
    {
        allSlots = 20;
        slot = new GameObject[allSlots];
        for(int i=0; i<allSlots; i++)
        {
            slot[i] = slotHoldedr.transform.GetChild(i);
        }
    }

    void Update()
    {
        if (Input.GetDown(KeyCode.I))
            inventoryEnabled = !inventoryEnabled;
        if (inventoryEnabled == true)
        {
            inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }


    }
}
*/