﻿using CommandSystem;
using MEC;
using System;

namespace FunnyGunsRecoded.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class eventControl : ICommand
    {
        public string Command => "fg_event";

        public string[] Aliases => null;

        public string Description => "Controls event, enter command without arguments to see all subcommands";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender.CheckPermission(PlayerPermissions.RoundEvents))
            {
                var args = arguments.Array;
                if (args.Length == 1)
                {
                    response = "<color=green>FunnyGuns -> fg_event</color> \n" +
                        "<color=yellow>fg_event</color> <color=green>start</color> - <color=green>Starts the event</color>\n" +
                        "<color=yellow>fg_event</color> <color=green>stop</color> - <color=green>Stops the event</color>";
                    return true;
                }
                if (args.Length == 2)
                {
                    switch (args[1].ToLower())
                    {
                        case "start":
                            if (!Plugin.isEngaged)
                            {
                                if (Qurre.API.Round.Started && !Qurre.API.Controllers.Alpha.Detonated)
                                {
                                    Plugin.isEngaged = true;
                                    Plugin.HowManyDeathSinceLastAssault = 0;
                                    Plugin.AssaultWasStaredHowManyTimes = 0;
                                    Timing.RunCoroutine(Coroutines.GameEvent.gameController(), "gameController");
                                    Timing.RunCoroutine(Coroutines.PlayerHUD.hudCoroutine(), "playerHUD");

                                    response = "Success! Event is now started!";
                                    return true;
                                }
                                else if (!Qurre.API.Round.Started)
                                {
                                    response = "Round is not started u sicko!";
                                    return false;
                                }
                                else if (Qurre.API.Controllers.Alpha.Detonated)
                                {
                                    response = "Warhead was detonated u sicko! Restart round!";
                                    return false;
                                }
                                else
                                {
                                    response = "Unknown check was failed. Restart round!";
                                    return false;
                                }
                            }
                            else
                            {
                                response = "Event is running already!";
                                return true;
                            }
                            break;
                        case "stop":
                            if (Plugin.isEngaged)
                            {
                                var ev = new Events();
                                ev.StopAllEventShit();
                                response = "Success! Event is now stopped!";
                                return true;
                            }
                            else
                            {
                                response = "Event is stopped already!";
                                return true;
                            }
                            break;
                        default:
                            if (Plugin.IsDebugEnabled)
                            {
                                response = "Arguments given: \n";
                                for (int i = 0; i < args.Length; i++)
                                {
                                    response += "ID: " + i + ". Argument: " + args[i] + "\n";
                                }

                                return true;
                            }
                            else
                            {
                                response = "Unknown argument(s). Check all subcommands using <color=yellow>fg_event</color>";
                                return false;
                            }
                            break;
                    }
                }
                else
                {
                    if (Plugin.IsDebugEnabled)
                    {
                        response = "Arguments given: \n";
                        for (int i = 0; i < args.Length; i++)
                        {
                            response += "ID: " + i + ". Argument: " + args[i] + "\n";
                        }

                        return true;
                    }
                    else
                    {
                        response = "Unknown argument(s). Check all subcommands using <color=yellow>fg_event</color>";
                        return false;
                    }
                }
            }
            else
            {
                response = "Not enough permissions! Required: RoundEvents.";
                return false;
            }
        }
    }
}
