using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public WaypointPath _waypointPath; // The path the obstacle follows.
    public float _speed; // Speed of the obstacle's movement.

    private int _targetWaypointIndex; // Index of the waypoint the obstacle is moving toward.

    private Transform _previousWaypoint; // Last targeted waypoint.
    private Transform _targetWaypoint; // Current targeted waypoint.

    private float _timeToWaypoint; // Time to reach the current waypoint.
    private float _elapsedTime; // Time since reaching the previous waypoint.

    void Start()
    {
        // Begin by targeting the first waypoint.
        TargetNextWaypoint();
    }

    void Update()
    {
        _elapsedTime += Time.deltaTime;

        // Calculate how far the obstacle is to the next waypoint.
        float elapsedPercentage = _elapsedTime / _timeToWaypoint;

        // Move the obstacle smoothly between waypoints.
        transform.position = Vector3.Lerp(_previousWaypoint.position, _targetWaypoint.position, elapsedPercentage);

        // When the obstacle reaches the waypoint, switch to the next one.
        if (elapsedPercentage >= 1)
        {
            TargetNextWaypoint();
        }
    }

    private void TargetNextWaypoint()
    {
        // Update previous waypoint.
        _previousWaypoint = _waypointPath.GetWaypoint(_targetWaypointIndex);

        // Get the index and Transform of the next waypoint.
        _targetWaypointIndex = _waypointPath.GetNextWaypointIndex(_targetWaypointIndex);
        _targetWaypoint = _waypointPath.GetWaypoint(_targetWaypointIndex);

        // Reset time and calculate time to reach the next waypoint.
        _elapsedTime = 0;
        float distanceToWaypoint = Vector3.Distance(_previousWaypoint.position, _targetWaypoint.position);
        _timeToWaypoint = distanceToWaypoint / _speed;

        // Note: This method changes the target to the next waypoint.
    }
}
