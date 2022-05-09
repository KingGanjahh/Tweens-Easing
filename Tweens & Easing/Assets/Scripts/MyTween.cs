using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTween : MonoBehaviour
{

    [SerializeField] private AnimationCurve curve;

    [SerializeField] private float duration = 5;
    
    [SerializeField] private Vector3 startPosition, endPosition;
    
    private void Update()
    {
        var t = Time.time / duration;
        transform.position = Vector3.LerpUnclamped(startPosition, endPosition, curve.Evaluate(t));
    }

    private float EaseInOutCirc (float x)
    {
        return x < 0.5f ? (1 - Mathf.Sqrt(1f - Mathf.Pow(2 * x, 2))) / 2 :
            (Mathf.Sqrt(1f - Mathf.Pow(-2f * x + 2, 2)) + 1) / 2;
    }
}
