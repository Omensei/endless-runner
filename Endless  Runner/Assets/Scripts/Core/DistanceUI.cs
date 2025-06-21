using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class DistanceUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI distanceText;

    [SerializeField] private DistanceTracker distanceTracker;

    private void Update()
    {
        distanceText.text = $"Miles: {Mathf.FloorToInt(distanceTracker.DistanceTraveled):N0}";
    }
}
