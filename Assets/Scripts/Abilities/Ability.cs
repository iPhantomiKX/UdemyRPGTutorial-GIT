using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Combat;

namespace RPG.Abilities
{
    public class Ability : MonoBehaviour
    {
        public virtual void Activate()
        {   
            print(this.name + " is activated");
        }
    }
}

