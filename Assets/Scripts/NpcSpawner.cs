using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    [SerializeField] private NPC _npc;
    [SerializeField] private Transform _spawnPoints;
    [SerializeField] private Transform _targetPoint;

    private Transform[] _points;

    private int _spawnDelay = 2;
    private int _currentPoint;
    private int _npcCount = 10;

    private void Start()
    {
        _points = new Transform[_spawnPoints.childCount];

        for (int i = 0; i < _spawnPoints.childCount; i++)
        {
            _points[i] = _spawnPoints.GetChild(i);
        }

        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var waitForSeconds = new WaitForSeconds(_spawnDelay);

        for (int i = 0; i < _npcCount; i++)
        {
            Transform point = _points[_currentPoint];
            NPC npc = Instantiate(_npc, _points[_currentPoint].position, Quaternion.identity);
            npc.Init(_targetPoint);
            _currentPoint++;

            if (_currentPoint == _points.Length)
            {
                _currentPoint = 0;
            }

            yield return waitForSeconds;
        }
    }
}
