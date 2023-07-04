/*
    Exercise 8 Sierpinski's Triangle:
        In this exercise, there are three objects - three points (empty) placed randomly to mark the vertices of a triangle. 
    The objective is to create Sierpinski's Triangle by following these steps. First, draw the three points. Second, 
    randomly choose one of the points as the starting point. Third, loop through Sierpinksi's triangle algorithm. The
    number of loop iterations should be a high number like 5000. After looping the algorithm through many iterations, 
    Sierpinski's triangle should form. 
        In the algorithm, start by randomly choosing one of the three points as the target point. Next, you calculate the 
    mid point between the current point and the target point. Take into consideration that vector math yields a raw vector.
    Then, you draw the mid point and set the midpoint as the current point.
*/

using UnityEngine;

public class SierpinksiTriangle : MonoBehaviour {
    [SerializeField] [Range(0, 5000)] int iterations = 100;
    [SerializeField] GameObject[] trianglePoints;
    bool isFinished;
    Vector3 currentPoint;
    Vector3 midPoint;
    Vector3 targetPoint;
    void OnDrawGizmos() {
        // Randomly choose a starting point
        currentPoint = trianglePoints[Random.Range(0, trianglePoints.Length)].transform.position;

        // Loop through Sierpinski's triangle algorithm
        Gizmos.color = Color.white;
        for (int i = 0; i < iterations; i ++) {
            // Randomly choose between the three triangle points
            targetPoint = trianglePoints[Random.Range(0, trianglePoints.Length)].transform.position;

            // Calculate and draw the mid point between the current point and target point
            midPoint = currentPoint + ((targetPoint - currentPoint) / 2);
            Gizmos.DrawSphere(midPoint, .03f);

            // Set the mid point as the current point
            currentPoint = midPoint;
        }
    }
}
