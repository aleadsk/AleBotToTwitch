using TwitchLib.Client.Events;
using TwitchLib.Client.Interfaces;

namespace BotTwitch.Classes;

public class SendMessage {
    private readonly ITwitchClient _twitchClient;
    private readonly string channelName = "alekp1";
    private readonly int timeSocials = 18;

    public SendMessage(ITwitchClient twitchClient) {
        _twitchClient = twitchClient;
    }

    public void ClientOnJoinedChannel(object sender, OnJoinedChannelArgs e) {
        _twitchClient.SendMessage(e.Channel, "AleBot aqui! KappaPride");
    }

    public void SendAnyMessage(string message) {
        _twitchClient.SendMessage(channelName, message);
    }

    public void SendDiscordLink(object state) {
        SendAnyMessage("https://discord.gg/VnrJqS2C precio10Coracaozinpop");
    }

    public void SendFacebookLink(object state) {
        SendAnyMessage("https://www.facebook.com/preciousxsummer/?ref=py_c precio10Coracaozinpop");
    }

    public void SendInstagramLink(object state) {
        SendAnyMessage("https://www.instagram.com/precioussummeer/ precio10Coracaozinpop");
    }

    public void SendYouTubeLink(object state) {
        SendAnyMessage("https://www.youtube.com/channel/UCmv5S-bGBE6nGw0cL1QqsYQ precio10Coracaozinpop");
    }

    public void SendSocialLink(object state) {
        SendAnyMessage($"Instagram: {SendInstagramLink} YouTube: {SendYouTubeLink}" +
                       $"Facebook: {SendFacebookLink}");
    }

    public void SendDiscordLinkByAnyMinutes(object sender, OnConnectedArgs e) {
        Timer timer = new Timer(SendDiscordLink, null, TimeSpan.Zero, TimeSpan.FromMinutes(timeSocials));
    }

    public void SendFacebookLinkByAnyMinutes(object sender, OnConnectedArgs e) {
        Timer timer = new Timer(SendFacebookLink, null, TimeSpan.Zero, TimeSpan.FromMinutes(timeSocials));
    }

    public void SendInstagramLinkByAnyMinutes(object sender, OnConnectedArgs e) {
        Timer timer = new Timer(SendInstagramLink, null, TimeSpan.Zero, TimeSpan.FromMinutes(timeSocials));
    }

    public void SendYouTubeLinkByAnyMinutes(object sender, OnConnectedArgs e) {
        Timer timer = new Timer(SendYouTubeLink, null, TimeSpan.Zero, TimeSpan.FromMinutes(timeSocials));
    }
}