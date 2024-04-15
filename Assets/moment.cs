using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class moment : MonoBehaviour
    {
        public float moveSpeed = 3f;
        
        void Start()
        {

        }

        
        void Update()
        {
           
            transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
                       transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
        }
    }
