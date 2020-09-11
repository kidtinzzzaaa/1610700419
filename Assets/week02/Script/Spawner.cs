using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    public GameObject monster;
    public UnityEvent OnSpawn;

    private void Start()
    {
        EventManager.instance.StartListening("Spawn", Spawn);
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }


    public void Spawn()
    {
        Instantiate(monster, this.transform.position, this.transform.rotation);
        OnSpawn.Invoke();
    }
    
}

