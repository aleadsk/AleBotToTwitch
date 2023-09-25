// See https://aka.ms/new-console-template for more information
using BotTwitch.Classes;

Console.WriteLine("Inicializando!");

Connections connect = new();

var values = connect.GetParamsToConnect();

Bot bot = new(values.Item1, values.Item2);

bot.Connect(true);
bot.Disconnect();