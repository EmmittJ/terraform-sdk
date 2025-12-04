using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_networkmonitor_probe Terraform resource.
/// Manages a aws_networkmonitor_probe resource.
/// </summary>
public partial class AwsNetworkmonitorProbe(string name) : TerraformResource("aws_networkmonitor_probe", name)
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformValue<string> Destination
    {
        get => GetArgument<TerraformValue<string>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    public TerraformValue<double>? DestinationPort
    {
        get => GetArgument<TerraformValue<double>>("destination_port");
        set => SetArgument("destination_port", value);
    }

    /// <summary>
    /// The monitor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorName is required")]
    public required TerraformValue<string> MonitorName
    {
        get => GetArgument<TerraformValue<string>>("monitor_name");
        set => SetArgument("monitor_name", value);
    }

    /// <summary>
    /// The packet_size attribute.
    /// </summary>
    public TerraformValue<double>? PacketSize
    {
        get => GetArgument<TerraformValue<double>>("packet_size");
        set => SetArgument("packet_size", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceArn is required")]
    public required TerraformValue<string> SourceArn
    {
        get => GetArgument<TerraformValue<string>>("source_arn");
        set => SetArgument("source_arn", value);
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
    /// The address_family attribute.
    /// </summary>
    public TerraformValue<string> AddressFamily
        => AsReference("address_family");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    public TerraformValue<string> ProbeId
        => AsReference("probe_id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

}
