    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Item : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        void OnTriggerEnter2D(Collider2D col) //1
        { 
            Debug.Log("Collision");
            if (col.gameObject.tag == "player") //2
            {
                Destroy(gameObject); //3
            }
        }
    }
