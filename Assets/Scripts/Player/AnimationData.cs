using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AnimationData
{
    [SerializeField] private string isground = "@Ground";
    [SerializeField] private string isidle = "IsIdle";
    [SerializeField] private string iswalking = "IsWalking";
    [SerializeField] private string isrunning = "IsRunning";

    [SerializeField] private string isair = "@Air";
    [SerializeField] private string jump = "Jump";
    [SerializeField] private string isfall = "IsFall";

    [SerializeField] private string attack = "@Attack";
    [SerializeField] private string comboAttack = "ComboAttack";


    public int IsIdle { get; private set; }
    public int IsGround { get; private set; }
    public int IsWalking { get; private set; }
    public int IsRunning { get; private set; }

    public int IsAir { get; private set; }
    public int Jump { get; private set; }
    public int IsFall { get; private set; }

    public int Attack { get; private set; }
    public int ComboAttack { get; private set; }

    public void Initialize()
    {
        IsIdle = Animator.StringToHash(isidle);
        Debug.Log(Animator.StringToHash(isidle));
        Debug.Log(Animator.StringToHash("IsIdle"));
        Debug.Log(isidle);

        IsGround = Animator.StringToHash(isground);
        IsWalking = Animator.StringToHash(iswalking);
        IsRunning = Animator.StringToHash(isrunning);
        IsAir = Animator.StringToHash(isair);
        Jump = Animator.StringToHash(jump);
        IsFall = Animator.StringToHash(isfall);
        Attack = Animator.StringToHash(attack);
        ComboAttack = Animator.StringToHash(comboAttack);

    }
}