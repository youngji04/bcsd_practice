using System.Collections;
using UnityEngine;

public class HashtableExercise : MonoBehaviour
{
    private void Awake()
    {
        Hashtable hash = new Hashtable();

        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        hash["Goblin"] = goblin;
        hash.Add("Slime", slime);
        hash.Add(1, "����");
        hash.Add(1.2f, "�Ǽ�");
        hash.Add("�ȳ��ϼ���.", "���ڿ�");

        foreach (object key in hash.Keys)
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        }

        if (hash.ContainsKey("Slime"))
        {
            Debug.Log($"Slime Ű ����");
        }

        if (hash.ContainsValue(goblin))
        {
            Debug.Log($"{goblin} �� ����");
        }

        Debug.Log($"Hashtable Count : {hash.Count}");

        hash.Remove("Slime");

        Debug.Log($"Hashtable Count : {hash.Count}");

        hash.Clear();

        Debug.Log($"Hashtable Count : {hash.Count}");
    }
}
