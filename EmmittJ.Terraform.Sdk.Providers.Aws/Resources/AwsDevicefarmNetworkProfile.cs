using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_devicefarm_network_profile resource.
/// </summary>
public class AwsDevicefarmNetworkProfile : TerraformResource
{
    public AwsDevicefarmNetworkProfile(string name) : base("aws_devicefarm_network_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The downlink_bandwidth_bits attribute.
    /// </summary>
    public double? DownlinkBandwidthBits
    {
        get => GetProperty<TerraformLiteralProperty<double>>("downlink_bandwidth_bits")?.Value;
        set => this.WithProperty("downlink_bandwidth_bits", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The downlink_delay_ms attribute.
    /// </summary>
    public double? DownlinkDelayMs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("downlink_delay_ms")?.Value;
        set => this.WithProperty("downlink_delay_ms", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The downlink_jitter_ms attribute.
    /// </summary>
    public double? DownlinkJitterMs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("downlink_jitter_ms")?.Value;
        set => this.WithProperty("downlink_jitter_ms", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The downlink_loss_percent attribute.
    /// </summary>
    public double? DownlinkLossPercent
    {
        get => GetProperty<TerraformLiteralProperty<double>>("downlink_loss_percent")?.Value;
        set => this.WithProperty("downlink_loss_percent", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project_arn attribute.
    /// </summary>
    public string? ProjectArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project_arn")?.Value;
        set => this.WithProperty("project_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The uplink_bandwidth_bits attribute.
    /// </summary>
    public double? UplinkBandwidthBits
    {
        get => GetProperty<TerraformLiteralProperty<double>>("uplink_bandwidth_bits")?.Value;
        set => this.WithProperty("uplink_bandwidth_bits", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The uplink_delay_ms attribute.
    /// </summary>
    public double? UplinkDelayMs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("uplink_delay_ms")?.Value;
        set => this.WithProperty("uplink_delay_ms", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The uplink_jitter_ms attribute.
    /// </summary>
    public double? UplinkJitterMs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("uplink_jitter_ms")?.Value;
        set => this.WithProperty("uplink_jitter_ms", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The uplink_loss_percent attribute.
    /// </summary>
    public double? UplinkLossPercent
    {
        get => GetProperty<TerraformLiteralProperty<double>>("uplink_loss_percent")?.Value;
        set => this.WithProperty("uplink_loss_percent", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
