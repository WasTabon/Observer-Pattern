using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObservableExample : MonoBehaviour
{
    private ObservableVariable<int> _observableVariableInt;
    private ObservableLogger _logger;
    
    private void Start()
    {
        _observableVariableInt = new ObservableVariable<int>(10);
        _logger = new ObservableLogger(_observableVariableInt);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            RandomizeInt();
    }

    private void RandomizeInt()
    {
        int randomInt = Random.Range(1, 100);
        _observableVariableInt.Value = randomInt;
    }
}