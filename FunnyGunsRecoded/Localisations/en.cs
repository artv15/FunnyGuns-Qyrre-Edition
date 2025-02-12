﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyGunsRecoded.Localisations
{
    public class en : Interfaces.ILocalisation
    {
        public string PrepStage_HUD_START { get; set; } = "<color=yellow> Preparation stage. Event begins in</color><color=green> ";
        public string PrepStage_HUD_END { get; set; } = "</color> second(s)" + "\n" +
                            "<color=green>Your task in a nutshell</color>: Eliminate the enemy team. During the event, some mutators will be added. They change the rules of the game\n" +
                            "<color=green>Elevators are disabled during preparation stage</color>\n" +
                            "<color=blue>Info about the event and credits are avaliable at .fg_info (~ console)</color>";
        public string InstantDeathHUD { get; set; } = "<color=red>Instant death!</color>\n<color=yellow>All alive players will be damaged by 4 hp every second! Kill the enemy team to win or be the last one standing!</color>";
        public string AlivePlayers_HUD_ALIVE { get; set; } = "Alive: ";
        public string AlivePlayers_HUD_MTF { get; set; } = "MTF Units";
        public string AlivePlayers_HUD_CI { get; set; } = "CI Agents";
        public string Stage_HUD_CURRENTSTAGE { get; set; } = "Current stage: ";
        public string Stage_HUD_TIMEBEFORENEXTSTAGE { get; set; } = "Until the next stage ";
        public string Stage_HUD_SECONDSTRANSLATION { get; set; } = "second(s)";
        public string LCZLockdown_HUD { get; set; } = "LCZ Lockdown on the next stage!";
        public string HCZLockdown_HUD { get; set; } = "HCZ Lockdown on the next stage!";
        public string CurrentMutatorsText_HUD { get; set; } = "Current Mutators: ";
        public string TutorialAssaultBaseName { get; set; } = "Tutorial Assault";
        public string TutorialAssaultPrep { get; set; } = "Preparation";
        public string TutorialAssaultAnticipation { get; set; } = "Anticipation";
        public string TutorialAssaultAssault { get; set; } = "In Progress";
        public string TutorialAssaultFade { get; set; } = "Fading";
        public string EventEnd { get; set; } = "<color=green>Event ended.</color> Victorious team is";
        public string EventEnd_CI_WIN { get; set; } = "<color=green>CI</color>";
        public string EventEnd_MTF_WIN { get; set; } = "<color=blue>MTF</color>";
        public string LocdownDeathReason { get; set; } = "Zone was locked down";
        public string InfoCommandText { get; set; } = "\n<color=green>[ Funny Guns => info ]</color>\n" +
                "<color=green>-- Developers --</color>\n" +
                "<color=yellow>Treeshold#0001 (aka Star Butterfly) - Developer</color>\n" +
                "<color=yellow>Dlorka#9909 (aka Tushkanchik) - Tester</color>\n\n" +
                "<color=green>-- About --</color>\n" +
                "<color=yellow>Team deathmatch. Your goal is to eliminate the enemy team.</color>\n" +
                "<color=yellow>During the event, mutators will be added, they will alter the gameplay.</color>\n\n" +
                "<color=grey>Let the strongest team win!</color>";
        public string StormDeathReason { get; set; } = "You froze to death.";
        public string StormBroadcastText { get; set; } = "<color=#6cd4dd>It's too cold outside! Get back in the facility!</color>";
        public void OnInit()
        {
            Plugin.MutatorLocaleDict.Add("passiveRegen", "<color=green>Passive regeneration</color>");
            Plugin.MutatorLocaleDict.Add("fogOfWar", "<color=orange>Dense fog</color>");
            Plugin.MutatorLocaleDict.Add("lightsOut", "<color=orange>Lights out</color>");
            Plugin.MutatorLocaleDict.Add("speed++", "<color=green>Movement speed is increased</color>");
            Plugin.MutatorLocaleDict.Add("noTeslaGates", "<color=orange>Tesla gates are disabled</color>");
            Plugin.MutatorLocaleDict.Add("legalWH", "<color=green>X-RAY vision</color>");
            Plugin.MutatorLocaleDict.Add("bleeding", "<color=red>Bleeding gun wounds</color>");
            Plugin.MutatorLocaleDict.Add("badBullets", "<color=red>Blank catridges</color>");
            Plugin.MutatorLocaleDict.Add("theInevitable", "<color=#6cd4dd>The great storm</color>");
            Plugin.MutatorLocaleDict.Add("poob", "<color=#6cd4dd>#poob 4 life</color>");
            //Plugin.MutatorLocaleDict.Add("", "");
        }
    }
}
