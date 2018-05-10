using UnityEngine;
using System.Collections;

public class PiggyRotLock : MonoBehaviour
{
    float lockPos = 0;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
    }

}
