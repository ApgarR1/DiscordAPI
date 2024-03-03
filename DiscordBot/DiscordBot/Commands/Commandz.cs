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
using CommandAttribute = DSharpPlus.CommandsNext.Attributes.CommandAttribute;
using CommandContext = DSharpPlus.CommandsNext.CommandContext;

namespace DiscordBot.commands
{
    internal class Commandz : BaseCommandModule
    {
        [Command("add")]
        public async Task Add(CommandContext ctx, int num1, int num2)
        {
            int result = num1 + num2;

            await ctx.Channel.SendMessageAsync(result.ToString());
        }

        [Command("test")]
        public async Task Test(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Test");
        }
    }
}