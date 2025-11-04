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
    /// The maximum_capture_duration attribute.
    /// </summary>
    public double? MaximumCaptureDuration
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_capture_duration")?.Value;
        set => this.WithProperty("maximum_capture_duration", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The network_watcher_name attribute.
    /// </summary>
    public string? NetworkWatcherName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_watcher_name")?.Value;
        set => this.WithProperty("network_watcher_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public string? TargetResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_id")?.Value;
        set => this.WithProperty("target_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
