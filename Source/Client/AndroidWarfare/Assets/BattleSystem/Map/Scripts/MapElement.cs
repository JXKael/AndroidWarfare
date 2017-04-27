using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapElement : MonoBehaviour
{
    public enum EType
    {
        tree,
        land,
        desert,
        sea
    }

    [SerializeField]
    protected EType _type;
    [SerializeField]
    protected MeshRenderer _meshRenderer;

    protected virtual void OnCharacterIn()
    {

    }

    protected virtual void OnCharacterOut()
    {

    }
}
