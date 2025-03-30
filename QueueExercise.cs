using System.Collections;
using UnityEngine;

public class QueueExercise : MonoBehaviour
{
    private void Awake()
    {
        Queue queue = new Queue();

        for (int i = 0; i < 5; i++)
        {
            queue.Enqueue(i);
        }

        Debug.Log($"Queue Count : {queue.Count}");
        Debug.Log($"���� �� �� ��� : {queue.Peek()}");
        Debug.Log($"Queue Count : {queue.Count}");

        object data = queue.Dequeue();
        Debug.Log($"ť���� �������� ������ : {data}");
        Debug.Log($"Queue Count : {queue.Count}");

        queue.Clear();
        Debug.Log($"Queue Count : {queue.Count}");

        queue.Clear();

        Debug.Log($"Queue Count : {queue.Count}");
    }
}

