using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skill Data", menuName = "Skill Data")]
public class SkillData : ScriptableObject
{
    public string skillName;
    public string skillDescription;
    public Sprite skillIcon;
    public Object skillEffects;
}
