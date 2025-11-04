using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_machine_packet_capture resource.
/// </summary>
public class AzurermVirtualMachinePacketCapture : TerraformResource
{
    public AzurermVirtualMachinePacketCapture(string name) : base("azurerm_virtual_machine_packet_capture", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maximum_bytes_per_packet attribute.
    /// </summary>
    public double? MaximumBytesPerPacket
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_bytes_per_packet")?.Value;
        set => this.WithProperty("maximum_bytes_per_packet", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The maximum_bytes_per_session attribute.
    /// </summary>
    public double? MaximumBytesPerSession
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_bytes_per_session")?.Value;
        set => this.WithProperty("maximum_bytes_per_session", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The maximum_capture_duration_in_seconds attribute.
    /// </summary>
    public double? MaximumCaptureDurationInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_capture_duration_in_seconds")?.Value;
        set => this.WithProperty("maximum_capture_duration_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_watcher_id attribute.
    /// </summary>
    public string? NetworkWatcherId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_watcher_id")?.Value;
        set => this.WithProperty("network_watcher_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public string? VirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_id")?.Value;
        set => this.WithProperty("virtual_machine_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
