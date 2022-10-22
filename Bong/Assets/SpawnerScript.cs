using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] GameObject _ballPrefab;
    [SerializeField] float speed;
    [SerializeField] float size;
    void Start()
    {
        SpawnBall(Random.insideUnitSphere);
    }
    void Update()
    {
        
    }
    void SpawnBall(Vector3 direction)
    {
        GameObject ball = Instantiate(_ballPrefab, transform.position,Quaternion.identity);
        ball.GetComponent<BallMovement>().SpawnBall(direction.normalized, speed, size);
    }
}