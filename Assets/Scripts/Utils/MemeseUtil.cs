using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using DG.Tweening;

public static class MemeseUtil 
{
    public static void Scale(this Transform t, float size = 1.2f)
        {
            t.localScale = Vector3.one * size;
        }
   
    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    public static T GetRandomButNotSame<T>(this List<T> list, T unique)
    {
        if(list.Count == 1)
            return unique;

        int RandomIndex = Random.Range(0, list.Count);
        return list[RandomIndex];
    }
    
}
