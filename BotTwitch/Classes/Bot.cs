using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;

namespace BotTwitch.Classes;

public class Bot {
    private static string channelName = "";

    private static string tokenTwitch = "";

    ConnectionCredentials creds = null;

    TwitchClient twitchClient = new();

    public Bot(string channelNameArg, string tokenTwitchArg) {
        channelName = channelNameArg;
        tokenTwitch = tokenTwitchArg;
        creds = new(channelName, tokenTwitch);
    }

    public void Connect(bool isLogging) {
        // twitchClient = new();
        twitchClient.Initialize(creds, channelName);

        if (isLogging) twitchClient.OnLog += ClientOnLog;

        twitchClient.Connect();
    }

    public void Disconnect() {
        twitchClient.Disconnect();
    }

    private void ClientOnLog(object sender, OnLogArgs e) {
        Console.WriteLine(e.Data);
    }
}