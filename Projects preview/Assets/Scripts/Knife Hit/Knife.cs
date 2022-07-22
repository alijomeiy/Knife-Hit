using System.Collections.Generic;
using System;
using UnityEngine;


namespace Knife_Hit
{
    public class Knife : MonoBehaviour
    {
        //ali.jomeiy@gmail.com
        [SerializeField] private float velocity;
        [SerializeField] private Vector3 speed;
        private List<string> testList = new List<string>() {"car", "salam"};
        private KnifeState state;
        private Transform target;

        private void Awake()
        {
            state = KnifeState.Generated;
            target = GameObject.FindGameObjectWithTag("Parent").transform;
            for (int i = 0; i < testList.Count; i++)
            {
                Debug.Log( ": " + testList[i]);
            }
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0) && state == KnifeState.Generated)
            {
                state = KnifeState.InMove;
            }

            if (state == KnifeState.InMove)
            {
                // transform.position += Vector3.up * velocity;
                transform.position += speed;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            string t = other.gameObject.tag;
            switch (t)
            {
                case "Knife" when transform.parent == target:
                    state = KnifeState.CollidedWithOtherKnife;
                    Debug.Log("Knife! --- ");
                    break;
                case "Target":
                    transform.parent = target;
                    state = KnifeState.Collided;
                    Debug.Log("Target --- " + other.name);
                    break;
            }
            Debug.LogError("Enter: " + other.name, other.gameObject);
        }

        private void OnTriggerStay(Collider other)
        {
            Debug.Log("Stay!");
        }

        private void OnTriggerExit(Collider other)
        {
            Debug.Log("Exit");
        }

        private enum KnifeState
        {
            Generated,
            InMove,
            Collided,
            CollidedWithOtherKnife
        }
    }
}