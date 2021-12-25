using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject _Player;
    public Vector3 _ShiftFromTarget = new Vector3(0, 5, -7); 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _Player.transform.position + _ShiftFromTarget;
    }
}
