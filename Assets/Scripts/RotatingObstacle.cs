using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private float _rotate;
    // Start is called before the first frame update
    void Start()
    {
        _rotate = 3;
    }

    // Update is called once per frame
    void Update()
    {
        var rotate = transform.rotation;
        rotate.z += Time.deltaTime * _moveSpeed;
        transform.Rotate(new Vector3(0,0,1),_moveSpeed);;
    }
}
