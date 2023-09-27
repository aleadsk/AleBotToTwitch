using TwitchLib.Client.Events;
using TwitchLib.Client.Interfaces;

namespace BotTwitch.Classes;

public class ReceiveMessage {
    private readonly ITwitchClient _twitchClient;

    public ReceiveMessage(ITwitchClient twitchClient) {
        _twitchClient = twitchClient;
    }

    public void ReceiveAnyMessage(object sender, OnMessageReceivedArgs e) {
        SendMessage _sendMessage = new(_twitchClient);
        string message = e.ChatMessage.Message.ToLower();

        switch (message) {
            case string m when m.Contains("!discord"):
                _sendMessage.SendDiscordLink();
                break;
            case string m when m.Contains("!facebook"):
                _sendMessage.SendFacebookLink();
                break;
            case string m when m.Contains("!instagram"):
                _sendMessage.SendInstagramLink();
                break;
        }
    }
}