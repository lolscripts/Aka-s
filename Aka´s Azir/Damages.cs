﻿
using AddonTemplate;
using EloBuddy;
using EloBuddy.SDK;

namespace AddonTemplate
{
    class Damages
    {
        public static float GetComboDamage(Obj_AI_Base target)
        {
            var damage = 0d;
            if (SpellManager.Q.IsReady())
            {
                damage += ObjectManager.Player.GetSpellDamage(target, SpellSlot.Q);
            }

            if (SpellManager.E.IsReady())
            {
                damage += ObjectManager.Player.GetSpellDamage(target, SpellSlot.E);
            }

            if (SpellManager.R.IsReady())
            {
                damage += ObjectManager.Player.GetSpellDamage(target, SpellSlot.R);
            }

            if (SpellManager.Ignite.IsReady())
            {
                damage += ObjectManager.Player.GetSummonerSpellDamage(target, DamageLibrary.SummonerSpells.Ignite);
            }

            damage += Orbwalker.AzirSoldiers.Count * ObjectManager.Player.GetSpellDamage(target, SpellSlot.W);

            return (float)damage;
        }

    }
}