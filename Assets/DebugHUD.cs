using UnityEngine;
using UnityEngine.UI;

public class DebugHUD : MonoBehaviour
{
    public Text text;

	private void Start()
    {
        text.text =
            "Device:\n" +
            "    Name: " + (SystemInfo.deviceName ?? "Unavailable") + "\n" +
            "    Model: " + (SystemInfo.deviceModel ?? "Unavailable") + "\n" +
            "    UUID: " + (SystemInfo.deviceUniqueIdentifier ?? "Unavailable") + "\n" +
            "    Battery Level: " + (SystemInfo.batteryLevel.ToString() ?? "Unavailable") + "\n" +
            "Operating System:\n" +
            "    OS: " + (SystemInfo.operatingSystem ?? "Unavailable") + "\n" +
            "    DataPath: " + Application.dataPath + "\n" +
            "Specification:\n" +
            "    Processor:\n" +
            "        Type: " + (SystemInfo.processorType ?? "Unavailable") + "\n" +
            "        Frequency: " + (SystemInfo.processorFrequency.ToString() ?? "?") + "MHz\n" +
            "        Count: " + (SystemInfo.processorCount.ToString() ?? "Unavailable") + "\n" +
            "    Memory:\n" +
            "        Size: " + (SystemInfo.systemMemorySize.ToString() ?? "?") + "MB\n" +
            "    Graphics:\n" +
            "        ID: " + (SystemInfo.graphicsDeviceID.ToString() ?? "Unavailable") + "\n" +
            "        Type: " + (SystemInfo.graphicsDeviceType.ToString() ?? "Unavailable") + "\n" +
            "        Name: " + (SystemInfo.graphicsDeviceName ?? "Unavailable") + "\n" +
            "        Version: " + (SystemInfo.graphicsDeviceVersion ?? "Unavailable") + "\n" +
            "        Vendor:\n" +
            "            ID: " + (SystemInfo.graphicsDeviceVendorID.ToString() ?? "Unavailable") + "\n" +
            "            Vendor: " + (SystemInfo.graphicsDeviceVendor ?? "Unavailable") + "\n" +
            "        MemSize: " + (SystemInfo.graphicsMemorySize.ToString() ?? "?") + "MB\n" +
            "";
    }
}
