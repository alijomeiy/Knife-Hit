using System;
using UnityEngine;

namespace Knife_Hit
{
    public class KnifeController : MonoBehaviour
    {
        [SerializeField] private GameObject knife;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ShootAKnife();
            }
        }

        private void ShootAKnife()
        {
            Instantiate(knife, transform.position, Quaternion.identity);
        }
    }
}