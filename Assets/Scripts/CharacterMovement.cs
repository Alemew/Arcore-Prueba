using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    private Transform _player;
    [SerializeField] 
    private float _distance = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        _player = Camera.main.transform;
    }

    public void ChangePosition()
    {
        transform.position = new Vector3(
            Random.insideUnitSphere.x * _distance,
            transform.position.y,
            Random.insideUnitSphere.z * _distance
        );
        transform.LookAt(_player);
    }
}
