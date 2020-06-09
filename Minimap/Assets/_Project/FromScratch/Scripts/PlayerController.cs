﻿using UnityEngine;

namespace FromScratch.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public float speed = 10f;
        public float rotateSpeed = 10f;

        private Vector3 movement;
        private float rotation;

        void Update()
        {
            movement.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        }

        void FixedUpdate()
        {
            transform.Translate(movement, Space.Self);
            transform.Rotate(0f, rotation, 0f);
        }
    }
}