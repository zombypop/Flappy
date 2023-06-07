using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;
    private List<GameObject> pool = new List<GameObject>();
    private int amountPool = 15;
    [SerializeField]
    private GameObject bulletPrefab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
    }

    public void StartPool()
    {
        for (int i = 0; i < amountPool; i++)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    public GameObject GetPoolObject()
    {
        for(int i = 0;i < pool.Count ;i++)
        {
            if (!pool[i].activeInHierarchy)
            {
                return pool[i];
            }
        }
        return null;
    }
}
