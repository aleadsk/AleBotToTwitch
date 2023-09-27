using TwitchLib.Client.Events;
using TwitchLib.Client.Interfaces;

namespace BotTwitch.Classes;

public class SendMessage {
    private readonly ITwitchClient _twitchClient;
    private readonly string channelName = "alekp1";

    public SendMessage(ITwitchClient twitchClient) {
        _twitchClient = twitchClient;
    }

    public void ClientOnJoinedChannel(object sender, OnJoinedChannelArgs e) {
        _twitchClient.SendMessage(e.Channel, "AleBot aqui! KappaPride");
    }

    public void SendAnyMessage(string message) {
        _twitchClient.SendMessage(channelName, message);
    }

    public void SendDiscordLink() {
        SendAnyMessage("https://discord.gg/VnrJqS2C");
    }

    public void SendFacebookLink() {
        SendAnyMessage("Facebook");
    }

    public void SendInstagramLink() {
        SendAnyMessage("Instagram");
    }

    private void NotifyDiscordLink(object sender, OnSendReceiveDataArgs e) {
        _twitchClient.SendMessage(e.Data, "https://discord.gg/VnrJqS2C");
    }
}