using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_machine_scale_set_packet_capture resource.
/// </summary>
public class AzurermVirtualMachineScaleSetPacketCapture : TerraformResource
{
    public AzurermVirtualMachineScaleSetPacketCapture(string name) : base("azurerm_virtual_machine_scale_set_packet_capture", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The maximum_bytes_per_packet attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumBytesPerPacket
    {
        get => GetProperty<TerraformProperty<double>>("maximum_bytes_per_packet");
        set => this.WithProperty("maximum_bytes_per_packet", value);
    }

    /// <summary>
    /// The maximum_bytes_per_session attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumBytesPerSession
    {
        get => GetProperty<TerraformProperty<double>>("maximum_bytes_per_session");
        set => this.WithProperty("maximum_bytes_per_session", value);
    }

    /// <summary>
    /// The maximum_capture_duration_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumCaptureDurationInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("maximum_capture_duration_in_seconds");
        set => this.WithProperty("maximum_capture_duration_in_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_watcher_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkWatcherId
    {
        get => GetProperty<TerraformProperty<string>>("network_watcher_id");
        set => this.WithProperty("network_watcher_id", value);
    }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualMachineScaleSetId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_scale_set_id");
        set => this.WithProperty("virtual_machine_scale_set_id", value);
    }

}
