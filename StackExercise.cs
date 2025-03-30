using System.Collections;
using UnityEngine;

public class StackExercise : MonoBehaviour
{
    private void Awake()
    {
        Stack stack = new Stack();

        for (int i = 0; i < 5; ++i)
        {
            stack.Push(i);
        }

        Debug.Log($"Stack Count : {stack.Count}");
        Debug.Log($"�������� �߰��� ��� : {stack.Peek()}");
        Debug.Log($"Stack Count : {stack.Count}");

        object data = stack.Pop();
        Debug.Log($"���ÿ��� �������� ������ : {data}");
        Debug.Log($"Stack Count : {stack.Count}");

        stack.Clear();
        Debug.Log($"Stack Count : {stack.Count}");


    }
}
