using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_kurukuru : MonoBehaviour
{
    public GameObject Parent_object;
    public GameObject Unitymark;
    float time_rotate;

    private void Start()
    {
        Unitymark.transform.parent = Parent_object.transform;
    }

    void Update()
    {
        time_rotate += Time.deltaTime*100;
        if (time_rotate >= 360) time_rotate = 0;

        Unitymark.transform.rotation = Quaternion.Euler(0, 0, time_rotate);
    }
}
