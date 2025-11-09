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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The downlink_bandwidth_bits attribute.
    /// </summary>
    public TerraformProperty<double>? DownlinkBandwidthBits
    {
        get => GetProperty<TerraformProperty<double>>("downlink_bandwidth_bits");
        set => this.WithProperty("downlink_bandwidth_bits", value);
    }

    /// <summary>
    /// The downlink_delay_ms attribute.
    /// </summary>
    public TerraformProperty<double>? DownlinkDelayMs
    {
        get => GetProperty<TerraformProperty<double>>("downlink_delay_ms");
        set => this.WithProperty("downlink_delay_ms", value);
    }

    /// <summary>
    /// The downlink_jitter_ms attribute.
    /// </summary>
    public TerraformProperty<double>? DownlinkJitterMs
    {
        get => GetProperty<TerraformProperty<double>>("downlink_jitter_ms");
        set => this.WithProperty("downlink_jitter_ms", value);
    }

    /// <summary>
    /// The downlink_loss_percent attribute.
    /// </summary>
    public TerraformProperty<double>? DownlinkLossPercent
    {
        get => GetProperty<TerraformProperty<double>>("downlink_loss_percent");
        set => this.WithProperty("downlink_loss_percent", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ProjectArn
    {
        get => GetProperty<TerraformProperty<string>>("project_arn");
        set => this.WithProperty("project_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The uplink_bandwidth_bits attribute.
    /// </summary>
    public TerraformProperty<double>? UplinkBandwidthBits
    {
        get => GetProperty<TerraformProperty<double>>("uplink_bandwidth_bits");
        set => this.WithProperty("uplink_bandwidth_bits", value);
    }

    /// <summary>
    /// The uplink_delay_ms attribute.
    /// </summary>
    public TerraformProperty<double>? UplinkDelayMs
    {
        get => GetProperty<TerraformProperty<double>>("uplink_delay_ms");
        set => this.WithProperty("uplink_delay_ms", value);
    }

    /// <summary>
    /// The uplink_jitter_ms attribute.
    /// </summary>
    public TerraformProperty<double>? UplinkJitterMs
    {
        get => GetProperty<TerraformProperty<double>>("uplink_jitter_ms");
        set => this.WithProperty("uplink_jitter_ms", value);
    }

    /// <summary>
    /// The uplink_loss_percent attribute.
    /// </summary>
    public TerraformProperty<double>? UplinkLossPercent
    {
        get => GetProperty<TerraformProperty<double>>("uplink_loss_percent");
        set => this.WithProperty("uplink_loss_percent", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
