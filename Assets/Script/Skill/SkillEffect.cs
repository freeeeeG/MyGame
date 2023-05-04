using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DamageType
{
    Physical,
    Magic,
    Real
}

public enum EffectType
{
    Damage,
    Heal,
    Buff,
    Debuff
}

public class SkillEffect : MonoBehaviour
{
    public float durationTime;
    public float intervalTime;
    public float damage;
    public int damageCount;
    public float damageRange;
    public DamageType damageType;
    public List<GameObject> damageTarget;
    public GameObject damageSource;


}
