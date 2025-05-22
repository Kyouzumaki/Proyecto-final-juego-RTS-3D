using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class DatabaseManager : MonoBehaviour
{
    public static DatabaseManager Instance { get; set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public ObjectsDatabseSO databaseSO;


}
