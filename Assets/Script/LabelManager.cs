using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelManager : MonoBehaviour {
    private bool showLabels = false;

    void ShowHideLabels()
    {
        showLabels = !showLabels;

        foreach (Transform childNode in this.transform)
        {
            if (!childNode.name.StartsWith("Edge"))
            {
                childNode.GetComponentInChildren<Canvas>().enabled = showLabels;
            }
        }
    }

}
