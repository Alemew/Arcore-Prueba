using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    private Transform _player;
    [SerializeField] 
    private float _distance = 5f;

    private float minValue = 2;
    private float valueX;
    private float valueZ;
    
    // Start is called before the first frame update
    void Start()
    {
        _player = Camera.main.transform;
    }

   

    public void ChangePosition()
    {
        valueX = Random.insideUnitSphere.x;
        valueZ = Random.insideUnitSphere.z;
        if (valueX* _distance<0)
        {
            valueX = valueX*_distance-minValue;
        }
        else
        {
            valueX = valueX*_distance+minValue;
        }
        
        if (valueZ* _distance<0)
        {
            valueZ = valueZ*_distance-minValue;
            
        }
        else
        {
            valueZ = valueZ*_distance+minValue;
        }
        
        transform.position = new Vector3(
            valueX ,
            transform.position.y,
            valueZ 
        );
        transform.LookAt(_player);
        
    }
}
