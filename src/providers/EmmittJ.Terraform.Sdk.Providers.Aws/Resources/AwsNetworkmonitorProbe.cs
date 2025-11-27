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
        get => new TerraformReference<string>(this, "destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    public TerraformValue<double>? DestinationPort
    {
        get => new TerraformReference<double>(this, "destination_port");
        set => SetArgument("destination_port", value);
    }

    /// <summary>
    /// The monitor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorName is required")]
    public required TerraformValue<string> MonitorName
    {
        get => new TerraformReference<string>(this, "monitor_name");
        set => SetArgument("monitor_name", value);
    }

    /// <summary>
    /// The packet_size attribute.
    /// </summary>
    public TerraformValue<double> PacketSize
    {
        get => new TerraformReference<double>(this, "packet_size");
        set => SetArgument("packet_size", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
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
    /// The source_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceArn is required")]
    public required TerraformValue<string> SourceArn
    {
        get => new TerraformReference<string>(this, "source_arn");
        set => SetArgument("source_arn", value);
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
    /// The address_family attribute.
    /// </summary>
    public TerraformValue<string> AddressFamily
    {
        get => new TerraformReference<string>(this, "address_family");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    public TerraformValue<string> ProbeId
    {
        get => new TerraformReference<string>(this, "probe_id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

}
