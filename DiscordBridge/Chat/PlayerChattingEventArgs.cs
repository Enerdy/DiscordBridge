﻿using System;
using System.Collections.Generic;
using TShockAPI;
using Microsoft.Xna.Framework;

namespace DiscordBridge.Chat
{
	public class PlayerChattingEventArgs : EventArgs
	{
		public Dictionary<string, string> ChatFormatters { get; } = new Dictionary<string, string>();

		public Dictionary<string, Color?> ColorFormatters { get; } = new Dictionary<string, Color?>();

		public ChatMessageBuilder Message { get; set; }

		public TSPlayer Player { get; set; }

		public string RawText { get; }

		public PlayerChattingEventArgs(string text)
		{
			Message = ChatHandler.CreateMessage("{4}").SetText(text);
			RawText = text;
		}

		public PlayerChattingEventArgs(ChatMessageBuilder builder, TSPlayer player, string rawText)
		{
			Message = builder;
			Player = player;
			RawText = rawText;
		}
	}
}
