using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// WaypointPath is a class that controls waypoints.
public class WaypointPath : MonoBehaviour
{
    // This function gets the Transform of a waypoint at the given index.
    public Transform GetWaypoint(int waypointIndex)
    {
        // Find the waypoint at the specified index.
        return transform.GetChild(waypointIndex);
    }

    // This function figures out the index of the next waypoint.
    public int GetNextWaypointIndex(int currentWaypointIndex)
    {
        // Increment the current index to get the next waypoint's index.
        int nextWaypointIndex = currentWaypointIndex + 1;

        // If the next index is out of bounds, loop back to the first waypoint.
        if (nextWaypointIndex == transform.childCount)
        {
            nextWaypointIndex = 0;
        }

        // Return the index of the next waypoint.
        return nextWaypointIndex;
    }
}
