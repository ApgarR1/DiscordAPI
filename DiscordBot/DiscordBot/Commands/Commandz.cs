using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.EventArgs;
using CommandAttribute = DSharpPlus.CommandsNext.Attributes.CommandAttribute;
using CommandContext = DSharpPlus.CommandsNext.CommandContext;
using var db = new BotContext();

namespace DiscordBot.commands
{
    internal class Commandz : BaseCommandModule
    {
        /*[Command("add")]
        public async Task Add(CommandContext ctx, int num1, int num2)
        {
            int result = num1 + num2;

            await ctx.Channel.SendMessageAsync(result.ToString());
        }*/

        [Command("help")]
        public async Task Help(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("```Commands: \n !new - Creates new profile \n !test - Tests bot```");
        }
        [Command("test")]
        public async Task Test(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Test");
        }

        [Command("new")]
        public async Task New(CommandContext ctx)
        {
            var profile = new Profile
            {
                Name = ctx.User.Username,
                DiscordID = ctx.User.Id,
                Backpack = "Wood",
                BackpackSpace = 100,
                Money = 100,
                Level = 0,
                Experience = 0
            };

            await ctx.Channel.SendMessageAsync("Profile created");
        }
    }
}