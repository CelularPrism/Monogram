using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    private bool _isActive;

    // Start is called before the first frame update
    void Start()
    {
        _isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isActive) 
            Debug.Log("Triggered");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered");
    }

    public void Enable() => _isActive = true;

    public void Disable() => _isActive = false;
}
