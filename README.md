# CYRUS_SIM800L Library

The CYRUS_SIM800L library is a C# .NET Core library that simplifies sending SMS messages using the SIM800L module, particularly suited for Raspberry Pi projects. With this library, you can easily integrate SMS functionality into your C# applications running on Raspberry Pi devices.

## Features

- **Easy Integration**: Simple API for sending SMS messages with just a few lines of code.
- **Raspberry Pi Compatibility**: Designed to work seamlessly with Raspberry Pi devices running .NET Core.
- **Error Handling**: Built-in error handling ensures reliable communication with the SIM800L module.
- **Versatile**: Can be used in various C# projects, including IoT applications, monitoring systems, and more.

## Installation

You can install the CYRUS_SIM800L library via NuGet Package Manager or by downloading the DLL from the [releases](releases) section of this repository.

### NuGet Package Manager

```bash
dotnet add package CYRUS_SIM800L
```

## Usage

### Initialization

First, initialize an instance of the `SIM800L` class with the appropriate COM port where the SIM800L module is connected:

```csharp
using CYRUS_SIM800L;

// Initialize SIM800L instance with COM port
SIM800L sim800L = new SIM800L("COM18");
```

### Sending SMS

Sending an SMS message is straightforward. Simply call the `SendTextMessage` method with the message content and recipient phone number:

```csharp
// Send SMS message
bool success = sim800L.SendTextMessage("Hello from CYRUS_SIM800L!", "+1234567890");
if (success)
{
    Console.WriteLine("SMS sent successfully!");
}
else
{
    Console.WriteLine("Failed to send SMS. Check your connection.");
}
```

## Sample Application

Check out the [sample application](usages) provided in this repository for a complete example of how to use the CYRUS_SIM800L library in your projects.

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](https://opensource.org/licenses/MIT) file for details.

## Acknowledgments

Special thanks to [contributors](https://github.com/cyrus-ireri) who have helped improve this library.

---

**Note**: This library assumes basic familiarity with C# programming and Raspberry Pi setup. Make sure to connect the SIM800L module to your Raspberry Pi correctly before using this library.
