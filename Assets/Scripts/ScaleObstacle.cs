using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObstacle : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private float _scale;
    private float _angle;    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        _scale = 2;
    }

    // Update is called once per frame
    void Update()
    {
        var scale = transform.localScale;
        scale.y = 1 + Mathf.Abs(Mathf.Cos(_angle)) * (_scale);
        scale.x = 1 + Mathf.Abs(Mathf.Cos(_angle)) * (_scale);
        _angle += Time.deltaTime * _moveSpeed;
        transform.localScale = scale;
    }
}
