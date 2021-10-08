using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggering : MonoBehaviour
{
    Color[] colors = new Color[6];

    // Start is called before the first frame update
    void Start()
    {
        colors[0] = Color.cyan;
        colors[1] = Color.red;
        colors[2] = Color.green;
        colors[3] = new Color(255, 165, 0);
        colors[4] = Color.yellow;
        colors[5] = Color.magenta;

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void OnTriggerEnter(Collider other) { 
        
        if (other.CompareTag("Player"))
        {
            Renderer render = GetComponent<Renderer>();
        render.material.color = colors[Random.Range(0, colors.Length)];

            Debug.Log(other.gameObject.name);
        }
    }

}
