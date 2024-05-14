using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tecla : MonoBehaviour
{
    [SerializeField] private GameObject Pausa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Pausa.SetActive(true);
        }
    }

    //public void Prender Menu()
    //{
       // Pausa.SetActive(false);
    //}
}
