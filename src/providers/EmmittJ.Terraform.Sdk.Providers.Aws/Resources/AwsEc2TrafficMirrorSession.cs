using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ec2_traffic_mirror_session Terraform resource.
/// Manages a aws_ec2_traffic_mirror_session resource.
/// </summary>
public partial class AwsEc2TrafficMirrorSession(string name) : TerraformResource("aws_ec2_traffic_mirror_session", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformValue<string> NetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "network_interface_id");
        set => SetArgument("network_interface_id", value);
    }

    /// <summary>
    /// The packet_length attribute.
    /// </summary>
    public TerraformValue<double> PacketLength
    {
        get => new TerraformReference<double>(this, "packet_length");
        set => SetArgument("packet_length", value);
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
    /// The session_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionNumber is required")]
    public required TerraformValue<double> SessionNumber
    {
        get => new TerraformReference<double>(this, "session_number");
        set => SetArgument("session_number", value);
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
    /// The traffic_mirror_filter_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficMirrorFilterId is required")]
    public required TerraformValue<string> TrafficMirrorFilterId
    {
        get => new TerraformReference<string>(this, "traffic_mirror_filter_id");
        set => SetArgument("traffic_mirror_filter_id", value);
    }

    /// <summary>
    /// The traffic_mirror_target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficMirrorTargetId is required")]
    public required TerraformValue<string> TrafficMirrorTargetId
    {
        get => new TerraformReference<string>(this, "traffic_mirror_target_id");
        set => SetArgument("traffic_mirror_target_id", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<double> VirtualNetworkId
    {
        get => new TerraformReference<double>(this, "virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

}
