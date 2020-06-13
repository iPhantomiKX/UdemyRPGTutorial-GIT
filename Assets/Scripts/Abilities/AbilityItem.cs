using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Abilities;

namespace RPG.Inventories
{
    [CreateAssetMenu(menuName = ("RPG/RPG.UI.InventorySystem/Ability Item"))]
    public class AbilityItem : ActionItem
    {
        [SerializeField] Ability abilitySpell;

        /// <summary>
        /// Trigger the use of this item. Override to provide functionality.
        /// </summary>
        /// <param name="user">The character that is using this action.</param>
        public override void Use(GameObject user)
        {
            base.Use(user);
            abilitySpell.Activate();
        }
    }
}

