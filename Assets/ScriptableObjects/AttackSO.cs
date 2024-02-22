using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultAttackData", menuName = "default", order = 1)]
public class AttackSO : ScriptableObject
{
    [Header("Attack Info")]
    private float speed;
    private float delay;
    private float power;
    public LayerMask target;
}
