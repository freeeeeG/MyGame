using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillDataBase
{
    string skillName;
    string skillDescription;
    Sprite skillIcon;
    Object skillEffects;

    public SkillDataBase(SkillData skillData)
    {
        skillName = skillData.skillName;
        skillDescription = skillData.skillDescription;
        skillIcon = skillData.skillIcon;
        skillEffects = skillData.skillEffects;
    }
}
