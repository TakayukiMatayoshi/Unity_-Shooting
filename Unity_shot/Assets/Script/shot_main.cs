using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot_main : MonoBehaviour
{
    float destroytime;

    void Update()
    {
        destroytime += Time.deltaTime;
        if (destroytime > 0.5f) Destroy(gameObject);

        transform.position += new Vector3(0, 0.5f, 0);
    }
}
