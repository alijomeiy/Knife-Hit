using System;
using UnityEngine;

namespace Knife_Hit
{
    public class Target : MonoBehaviour
    {
        [SerializeField] private Vector3 velocity;
        private void Update()
        {
            transform.Rotate(velocity);
        }
    }
}
