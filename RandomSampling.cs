using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RandomSampling
{
    public static List<T> RandomSample<T>(this List<T> list, int length)
    {
        int count = list.Count;
        List<T> result = new();

        for (int i = 0; i < count; i++)
        {
            float probability = (length - result.Count) / (float)(count - i);

            float rnd = Random.Range(0f, 1f);

            if (rnd <= probability) result.Add(list[i]);
        }
        return result;
    }
}
