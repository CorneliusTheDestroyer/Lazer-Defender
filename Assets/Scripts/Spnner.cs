using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spnner : MonoBehaviour
{
    [SerializeField] float speedOfSpin = 1f;

    void Update()
    {
        transform.Rotate(0, 0, speedOfSpin * Time.deltaTime);
    }
}
