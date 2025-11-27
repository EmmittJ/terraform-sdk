using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_devicefarm_network_profile Terraform resource.
/// Manages a aws_devicefarm_network_profile resource.
/// </summary>
public partial class AwsDevicefarmNetworkProfile(string name) : TerraformResource("aws_devicefarm_network_profile", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The downlink_bandwidth_bits attribute.
    /// </summary>
    public TerraformValue<double>? DownlinkBandwidthBits
    {
        get => new TerraformReference<double>(this, "downlink_bandwidth_bits");
        set => SetArgument("downlink_bandwidth_bits", value);
    }

    /// <summary>
    /// The downlink_delay_ms attribute.
    /// </summary>
    public TerraformValue<double>? DownlinkDelayMs
    {
        get => new TerraformReference<double>(this, "downlink_delay_ms");
        set => SetArgument("downlink_delay_ms", value);
    }

    /// <summary>
    /// The downlink_jitter_ms attribute.
    /// </summary>
    public TerraformValue<double>? DownlinkJitterMs
    {
        get => new TerraformReference<double>(this, "downlink_jitter_ms");
        set => SetArgument("downlink_jitter_ms", value);
    }

    /// <summary>
    /// The downlink_loss_percent attribute.
    /// </summary>
    public TerraformValue<double>? DownlinkLossPercent
    {
        get => new TerraformReference<double>(this, "downlink_loss_percent");
        set => SetArgument("downlink_loss_percent", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectArn is required")]
    public required TerraformValue<string> ProjectArn
    {
        get => new TerraformReference<string>(this, "project_arn");
        set => SetArgument("project_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The uplink_bandwidth_bits attribute.
    /// </summary>
    public TerraformValue<double>? UplinkBandwidthBits
    {
        get => new TerraformReference<double>(this, "uplink_bandwidth_bits");
        set => SetArgument("uplink_bandwidth_bits", value);
    }

    /// <summary>
    /// The uplink_delay_ms attribute.
    /// </summary>
    public TerraformValue<double>? UplinkDelayMs
    {
        get => new TerraformReference<double>(this, "uplink_delay_ms");
        set => SetArgument("uplink_delay_ms", value);
    }

    /// <summary>
    /// The uplink_jitter_ms attribute.
    /// </summary>
    public TerraformValue<double>? UplinkJitterMs
    {
        get => new TerraformReference<double>(this, "uplink_jitter_ms");
        set => SetArgument("uplink_jitter_ms", value);
    }

    /// <summary>
    /// The uplink_loss_percent attribute.
    /// </summary>
    public TerraformValue<double>? UplinkLossPercent
    {
        get => new TerraformReference<double>(this, "uplink_loss_percent");
        set => SetArgument("uplink_loss_percent", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
