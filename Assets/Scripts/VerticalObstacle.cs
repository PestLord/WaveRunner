using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalObstacle : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] float _height;
    private float _angle;    // Start is called before the first frame update
    private GameObject _gameManager;
    private Vector2 _pos;

    void Start()
    {
        _pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        // Движение игрока из стороны в сторону
        position.y = _pos.y + Mathf.Cos(_angle) * (_height * 0.45f);
        
        _angle += Time.deltaTime * _moveSpeed;
        transform.position = position;
        
    }
}
