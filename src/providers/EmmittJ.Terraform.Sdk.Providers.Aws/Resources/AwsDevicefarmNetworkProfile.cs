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
        SetOutput("arn");
        SetOutput("description");
        SetOutput("downlink_bandwidth_bits");
        SetOutput("downlink_delay_ms");
        SetOutput("downlink_jitter_ms");
        SetOutput("downlink_loss_percent");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project_arn");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("type");
        SetOutput("uplink_bandwidth_bits");
        SetOutput("uplink_delay_ms");
        SetOutput("uplink_jitter_ms");
        SetOutput("uplink_loss_percent");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The downlink_bandwidth_bits attribute.
    /// </summary>
    public TerraformProperty<double> DownlinkBandwidthBits
    {
        get => GetRequiredOutput<TerraformProperty<double>>("downlink_bandwidth_bits");
        set => SetProperty("downlink_bandwidth_bits", value);
    }

    /// <summary>
    /// The downlink_delay_ms attribute.
    /// </summary>
    public TerraformProperty<double> DownlinkDelayMs
    {
        get => GetRequiredOutput<TerraformProperty<double>>("downlink_delay_ms");
        set => SetProperty("downlink_delay_ms", value);
    }

    /// <summary>
    /// The downlink_jitter_ms attribute.
    /// </summary>
    public TerraformProperty<double> DownlinkJitterMs
    {
        get => GetRequiredOutput<TerraformProperty<double>>("downlink_jitter_ms");
        set => SetProperty("downlink_jitter_ms", value);
    }

    /// <summary>
    /// The downlink_loss_percent attribute.
    /// </summary>
    public TerraformProperty<double> DownlinkLossPercent
    {
        get => GetRequiredOutput<TerraformProperty<double>>("downlink_loss_percent");
        set => SetProperty("downlink_loss_percent", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectArn is required")]
    public required TerraformProperty<string> ProjectArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project_arn");
        set => SetProperty("project_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The uplink_bandwidth_bits attribute.
    /// </summary>
    public TerraformProperty<double> UplinkBandwidthBits
    {
        get => GetRequiredOutput<TerraformProperty<double>>("uplink_bandwidth_bits");
        set => SetProperty("uplink_bandwidth_bits", value);
    }

    /// <summary>
    /// The uplink_delay_ms attribute.
    /// </summary>
    public TerraformProperty<double> UplinkDelayMs
    {
        get => GetRequiredOutput<TerraformProperty<double>>("uplink_delay_ms");
        set => SetProperty("uplink_delay_ms", value);
    }

    /// <summary>
    /// The uplink_jitter_ms attribute.
    /// </summary>
    public TerraformProperty<double> UplinkJitterMs
    {
        get => GetRequiredOutput<TerraformProperty<double>>("uplink_jitter_ms");
        set => SetProperty("uplink_jitter_ms", value);
    }

    /// <summary>
    /// The uplink_loss_percent attribute.
    /// </summary>
    public TerraformProperty<double> UplinkLossPercent
    {
        get => GetRequiredOutput<TerraformProperty<double>>("uplink_loss_percent");
        set => SetProperty("uplink_loss_percent", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
