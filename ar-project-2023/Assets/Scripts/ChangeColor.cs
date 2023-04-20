using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer _renderer;

    void Start()
    {
        _renderer = transform.GetComponent<Renderer>();
    }

    public void OnMouseDOw()
    {
        var color = _renderer.material.color == Color.red ? Color.blue : Color.red;
        _renderer.material.color = color;
    }
}
