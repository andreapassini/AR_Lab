using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAndReinstantiate : MonoBehaviour
{
    public GameObject[] items;
    public List<Transform> positions;

    private List<GameObject> _instantiatedItems;


    // Start is called before the first frame update
    void Start()
    {
        _instantiatedItems = new List<GameObject>();
        InstantiateAll();
    }

    void InstantiateAll()
    {
        for(int i = 0; i< items.Length; i++)
        {
            GameObject g = Instantiate(items[i], positions[i].position, positions[i].rotation);
            _instantiatedItems.Add(g);
            Debug.Log("Prefab Inst" + i);
        }

    }


    void DeleteAll()
    {
        foreach(var item in _instantiatedItems)
        {
            Destroy(item);
        }

        _instantiatedItems.Clear();
    }

    public void DeleteAndInstantiate()
    {
        DeleteAll();
        InstantiateAll();
    }

    public void Pressed()
    {
        Debug.Log("button pressed");

        DeleteAndInstantiate();
    }
}
