using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using DG.Tweening;

[RequireComponent(typeof(Button))]
public class GenericButtons : MonoBehaviour
{
    public Action onClick;
    public bool animate = true;

    public void OnClick()
    {
        onClick?.Invoke();

        if (animate) Animate();
    }

    public void Animate() => transform.DOPunchScale(-Vector3.one * 0.2f, 0.2f);
}
