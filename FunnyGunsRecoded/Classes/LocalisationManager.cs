﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyGunsRecoded.Classes
{
    public class LocalisationManager
    {
        public static void InitLocalisation(string locale)
        {
            Plugin.MutatorLocaleDict.Clear();
            Interfaces.ILocalisation Locale;
            switch (locale.ToLower())
            {
                case "ru":
                    Locale = new Localisations.ru();
                    Locale.OnInit();
                    Plugin.selectedLocale = Locale;
                    Qurre.Log.Info("Selected russian localization!");
                    break;
                case "en":
                    Locale = new Localisations.en();
                    Locale.OnInit();
                    Plugin.selectedLocale = Locale;
                    Qurre.Log.Info("Selected english localization!");
                    break;
                default:
                    Locale = new Localisations.en();
                    Locale.OnInit();
                    Plugin.selectedLocale = Locale;
                    Qurre.Log.Info("Unknown locale! Defaulted to english localization!");
                    break;
            }
        }
    }
}
