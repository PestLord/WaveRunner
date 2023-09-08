using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorisontalObstacle : MonoBehaviour
{
    [SerializeField] 
    private GameObject _gameManager;
    [SerializeField] private float _moveSpeed;
    private float _mapWidth;
    private float _angle;

    // Start is called before the first frame update
    void Start()
    {
        _mapWidth = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        // Движение игрока из стороны в сторону
        position.x = Mathf.Cos(_angle) * (_mapWidth * 0.45f);
        
        _angle += Time.deltaTime * _moveSpeed;
        transform.position = position;
    }
}
