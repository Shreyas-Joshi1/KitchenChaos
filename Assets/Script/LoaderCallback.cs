using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderCallback : MonoBehaviour
{
    private bool isFirstupdate = true;

    private void Update()
    {
        if (isFirstupdate)
        {
            isFirstupdate = false;

            Loader.LoaderCallback();
        }
    }
}
