using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _spawnPoints;

    private Transform[] _points;
    private int _currentPoint;

    void Start()
    {
        _points = new Transform[_spawnPoints.childCount];

        for (int i = 0; i < _spawnPoints.childCount; i++)
        {
            _points[i] = _spawnPoints.GetChild(i);
        }

        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        var waitForSeconds = new WaitForSeconds(2);

        for (int i = 0; i < 10; i++)
        {
            Transform point = _points[_currentPoint];
            Instantiate(_template, _points[_currentPoint].position, Quaternion.identity);
            _currentPoint++;

            if (_currentPoint == _points.Length)
            {
                _currentPoint = 0;
            }

            yield return waitForSeconds;
        }
    }
}
