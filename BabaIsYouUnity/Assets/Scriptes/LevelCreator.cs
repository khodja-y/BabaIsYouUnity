using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ElementType
{
    Empty = 0,
    Poop,
    Wall,
    Toilet,
    PQ,
    Water,

    IsWord = 99,
    PoopWord = 100,
    WallWord,
    PQWord,
    ToiletWord,
    WaterWord,



    YouWord = 200,
    PushWord,
    WinWord,
    StopWord,
    SinkWord,

}

/*[System.Serializable]
public class Ligne
{
    [SerializeField]
    public List<ElementType> ligne = new List<ElementType>();
}
*/
[CreateAssetMenu()]
[System.Serializable]
public class LevelCreator : ScriptableObject
{


    [SerializeField]
    public List<ElementType> level = new List<ElementType>();
    // public List<Ligne> level = new List<Ligne>();


    public LevelCreator()
    {
        level = new List<ElementType>();
    }
}
