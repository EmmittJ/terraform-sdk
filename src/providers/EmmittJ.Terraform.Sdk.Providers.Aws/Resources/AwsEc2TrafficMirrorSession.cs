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
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformValue<string> NetworkInterfaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_interface_id");
        set => SetArgument("network_interface_id", value);
    }

    /// <summary>
    /// The packet_length attribute.
    /// </summary>
    public TerraformValue<double> PacketLength
    {
        get => GetArgument<TerraformValue<double>>("packet_length") ?? AsReference("packet_length");
        set => SetArgument("packet_length", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The session_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionNumber is required")]
    public required TerraformValue<double> SessionNumber
    {
        get => GetRequiredArgument<TerraformValue<double>>("session_number");
        set => SetArgument("session_number", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The traffic_mirror_filter_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficMirrorFilterId is required")]
    public required TerraformValue<string> TrafficMirrorFilterId
    {
        get => GetRequiredArgument<TerraformValue<string>>("traffic_mirror_filter_id");
        set => SetArgument("traffic_mirror_filter_id", value);
    }

    /// <summary>
    /// The traffic_mirror_target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficMirrorTargetId is required")]
    public required TerraformValue<string> TrafficMirrorTargetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("traffic_mirror_target_id");
        set => SetArgument("traffic_mirror_target_id", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<double> VirtualNetworkId
    {
        get => GetArgument<TerraformValue<double>>("virtual_network_id") ?? AsReference("virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

}
