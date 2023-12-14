using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private ItemManager instance;
    [SerializeField] private List<Item> items;

    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }


}
