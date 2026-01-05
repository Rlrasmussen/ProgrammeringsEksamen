using System.Net.Sockets;
using System.Net;
using System.Text;

UdpClient udpClient = new UdpClient();
IPAddress serverIP = IPAddress.Parse("127.0.0.1");
int serverPort = 1234;
IPEndPoint EndPoint = new IPEndPoint(serverIP, serverPort);

while (true)
{
    Console.WriteLine("Skriv en besked til serveren:");
    string message = Console.ReadLine();
    byte[] sendData = Encoding.ASCII.GetBytes(message);
    udpClient.Send(sendData, EndPoint);

    //Answer from server! 
    byte[] receivedData = udpClient.Receive(ref EndPoint);
    string receivedMessage = Encoding.ASCII.GetString(receivedData);
    
    Console.WriteLine($"Svar fra serveren: {receivedMessage} på adresse: {EndPoint}");

}
