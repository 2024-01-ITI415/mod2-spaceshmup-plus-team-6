using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            DestroyAllEnemies();
            SetInactive();
        }
    }

    void DestroyAllEnemies()
    {
        GameObject[] enemeys = GameObject.FindGameObjectsWithTag("Enemy");


        foreach (GameObject enemy in enemeys)
        {
            Destroy(enemy);
        }
    }

    void SetInactive()
    {
        gameObject.SetActive(false);
    }
}
