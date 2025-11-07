using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_packet_capture resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermNetworkPacketCapture : TerraformResource
{
    public AzurermNetworkPacketCapture(string name) : base("azurerm_network_packet_capture", name)
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
    /// The maximum_capture_duration attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumCaptureDuration
    {
        get => GetProperty<TerraformProperty<double>>("maximum_capture_duration");
        set => this.WithProperty("maximum_capture_duration", value);
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
    /// The network_watcher_name attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkWatcherName
    {
        get => GetProperty<TerraformProperty<string>>("network_watcher_name");
        set => this.WithProperty("network_watcher_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetResourceId
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

}
