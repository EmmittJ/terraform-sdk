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
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The downlink_bandwidth_bits attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DownlinkBandwidthBits
    {
        get => GetProperty<TerraformLiteralProperty<double>>("downlink_bandwidth_bits");
        set => this.WithProperty("downlink_bandwidth_bits", value);
    }

    /// <summary>
    /// The downlink_delay_ms attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DownlinkDelayMs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("downlink_delay_ms");
        set => this.WithProperty("downlink_delay_ms", value);
    }

    /// <summary>
    /// The downlink_jitter_ms attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DownlinkJitterMs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("downlink_jitter_ms");
        set => this.WithProperty("downlink_jitter_ms", value);
    }

    /// <summary>
    /// The downlink_loss_percent attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DownlinkLossPercent
    {
        get => GetProperty<TerraformLiteralProperty<double>>("downlink_loss_percent");
        set => this.WithProperty("downlink_loss_percent", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProjectArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project_arn");
        set => this.WithProperty("project_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The uplink_bandwidth_bits attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? UplinkBandwidthBits
    {
        get => GetProperty<TerraformLiteralProperty<double>>("uplink_bandwidth_bits");
        set => this.WithProperty("uplink_bandwidth_bits", value);
    }

    /// <summary>
    /// The uplink_delay_ms attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? UplinkDelayMs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("uplink_delay_ms");
        set => this.WithProperty("uplink_delay_ms", value);
    }

    /// <summary>
    /// The uplink_jitter_ms attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? UplinkJitterMs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("uplink_jitter_ms");
        set => this.WithProperty("uplink_jitter_ms", value);
    }

    /// <summary>
    /// The uplink_loss_percent attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? UplinkLossPercent
    {
        get => GetProperty<TerraformLiteralProperty<double>>("uplink_loss_percent");
        set => this.WithProperty("uplink_loss_percent", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
