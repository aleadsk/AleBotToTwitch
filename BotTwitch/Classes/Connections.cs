using System.Resources;
using System.Reflection;

namespace BotTwitch.Classes;

public class Connections {
    public Tuple<string, string> GetParamsToConnect() {
        ResourceManager resxReader = new("BotTwitch.Files.TwitchInfo", 
            Assembly.GetExecutingAssembly());

        string channelName = resxReader.GetString("ChannelName");
        string tokenTwitch = resxReader.GetString("TwitchToken");

        return Tuple.Create(channelName, tokenTwitch);
    }
}