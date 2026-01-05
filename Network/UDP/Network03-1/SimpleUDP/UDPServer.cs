using System.Net;
using System.Net.Sockets;
using System.Text;

UdpClient udpServer = new UdpClient(1234);
Console.WriteLine("Serveren er klar til at modtage data...");
while (true)
{
    IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
    byte[] receivedData = udpServer.Receive(ref clientEndPoint);

    string receivedMessage = Encoding.ASCII.GetString(receivedData);

    Console.WriteLine($"Modtaget: {receivedMessage} fra {clientEndPoint}");

    string responseMessage = "Tak for beskeden!";
    byte[] responseData = Encoding.ASCII.GetBytes(responseMessage);
    udpServer.Send(responseData, clientEndPoint);
}