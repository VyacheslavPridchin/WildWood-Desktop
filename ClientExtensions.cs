using OMTP;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WildWood_Desktop;
using WildWood_Desktop.Controls;

public static class ClientExtensions
{


    public static Handlers<OMTP_C.PacketHandler> serverPackets = new Handlers<OMTP_C.PacketHandler>
        {
            { "message", ClientHandler.MessageHandler },
            { "successfulAuth", ClientHandler.SuccessfulAuthHandler },
            { "invalidAuth", ClientHandler.InvalidAuthHandler },
            { "successfulReg", ClientHandler.SuccessfulRegHandler },
            { "invalidReg", ClientHandler.InvalidRegHandler },
            { "processedMaps", ClientHandler.ProcessedMapsHandler },
            { "favoriteList", ClientHandler.FavoriteListHandler },
            { "favorite", ClientHandler.FavoriteHandler },
        };

    static ClientPackets clientPackets = new ClientPackets
        {
        "auth",
        "register",
        "processMap",
        "addFavorite",
        "removeFavorite",
        "getFavoriteList",
        "getFavorite"

        };

    public static void Auth(this OMTP_C.Client client, string login, string password)
    {
        using (Packet packet = new Packet(clientPackets["auth"]))
        {
            packet.Write(login);
            packet.Write(password);
            client.SendTCPData(packet);
        }
    }

    public static void Register(this OMTP_C.Client client, string login, string password)
    {
        using (Packet packet = new Packet(clientPackets["register"]))
        {
            packet.Write(login);
            packet.Write(password);
            client.SendTCPData(packet);
        }
    }

    public static void ProcessMap(this OMTP_C.Client client, int greenSens, byte[] bytes, string token)
    {
        using (Packet packet = new Packet(clientPackets["processMap"]))
        {
            // TODO
            packet.Write(greenSens);
            packet.Write(bytes.Length);
            packet.Write(bytes);
            packet.Write(token);
            client.SendTCPData(packet);
        }
    }

    public static void AddFavorite(this OMTP_C.Client client, string token, string name, byte[] data)
    {
        using (Packet packet = new Packet(clientPackets["addFavorite"]))
        {
            packet.Write(token);
            packet.Write(name);
            packet.Write(data.Length);
            packet.Write(data);
            client.SendTCPData(packet);
        }
    }

    public static void RemoveFavorite(this OMTP_C.Client client, int idFavorite)
    {
        using (Packet packet = new Packet(clientPackets["removeFavorite"]))
        {
            packet.Write(idFavorite);
            client.SendTCPData(packet);
        }
    }

    public static void GetFavoriteList(this OMTP_C.Client client, string token)
    {
        using (Packet packet = new Packet(clientPackets["getFavoriteList"]))
        {
            packet.Write(token);
            client.SendTCPData(packet);
        }
    }

    public static void GetFavorite(this OMTP_C.Client client, string token, int id)
    {
        using (Packet packet = new Packet(clientPackets["getFavorite"]))
        {
            packet.Write(token);
            packet.Write(id);
            client.SendTCPData(packet);
        }
    }
    public static string login = "", password = "";
    public static Main main;
    public static Report report;

    private static class ClientHandler
    {

        public static void MessageHandler(Packet packet)
        {
            Console.WriteLine("Server message: " + packet.ReadString());
        }

        public static void SuccessfulAuthHandler(Packet packet)
        {
            var token = packet.ReadString();
            System.IO.File.WriteAllText("token", token);
            Console.WriteLine("Auth Token: " + token);
            WildWood_Desktop.Login.onAuth.Invoke();
        }

        public static void InvalidAuthHandler(Packet packet)
        {
            var msgError = packet.ReadString();
            Console.WriteLine("Error Auth:\n" + msgError);
        }

        public static void SuccessfulRegHandler(Packet packet)
        {
            Console.WriteLine("Successful Reg: ");
            Auth(WildWood_Desktop.Program.client, login, password);
        }

        public static void InvalidRegHandler(Packet packet)
        {
            var msgError = packet.ReadString();
            Console.WriteLine("Error Reg:\n" + msgError);
        }

        public static void ProcessedMapsHandler(Packet packet)
        {
            var mapsCount = packet.ReadInt();

            var ms1 = new MemoryStream(packet.ReadBytes(packet.ReadInt()));
            var im1 =  Image.FromStream(ms1);

            var ms2 = new MemoryStream(packet.ReadBytes(packet.ReadInt()));
            var im2 = Image.FromStream(ms2);

            float fillness = packet.ReadFloat();

            report.AddProcessedPhotos(im1, im2, fillness);
        }

        public static void FavoriteListHandler(Packet packet)
        {
            main.ClearFavorite();
            int count = packet.ReadInt();

            for (int i = 0; i < count; i++)
            {
                int id = packet.ReadInt();
                string name = packet.ReadString();
                main.SpawnFavorite(id, name);
            }

        }

        public static void FavoriteHandler(Packet packet)
        {
            main.ClearMapSet();

            int idFavorite = packet.ReadInt();
            string nameFavority = packet.ReadString();
            byte[] data = packet.ReadBytes(packet.ReadInt());
            Packet mapSets = new Packet(data);

            int count = mapSets.ReadInt();
            for (int i = 0; i < count; i++)
            {
                string name = mapSets.ReadString();
                string url = mapSets.ReadString();
                int sens = mapSets.ReadInt();
                var ms = new MemoryStream(mapSets.ReadBytes(mapSets.ReadInt()));
                Image image = Image.FromStream(ms);

                main.SpawnMapSet(name, url, sens, image);
            }
            // TODO
        }

    }
}