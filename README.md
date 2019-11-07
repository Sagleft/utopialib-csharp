
# utopialib-csharp
C# library for Utopia Network API.

### Install

[Download](https://github.com/Sagleft/utopialib-csharp/releases) the finished library or compile from source.
For assembly used SharpDevelop 4.4.2

### Example usage

```csharp
Client client = new UtopiaLib.Client(host, port, token);
//client.getSystemInfo();

decimal balance = client.getBalance();
string sticker_airship = client.getImageSticker();
client.enableMining();
```
![libtest screenshot](https://sagleft.ru/projects/utopia/lib-charp/screen.png)
