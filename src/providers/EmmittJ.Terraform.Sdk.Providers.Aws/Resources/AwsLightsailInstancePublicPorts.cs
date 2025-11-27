using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for port_info in AwsLightsailInstancePublicPorts.
/// Nesting mode: set
/// </summary>
public class AwsLightsailInstancePublicPortsPortInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_info";

    /// <summary>
    /// The cidr_list_aliases attribute.
    /// </summary>
    public TerraformSet<string> CidrListAliases
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cidr_list_aliases").ResolveNodes(ctx));
        set => SetArgument("cidr_list_aliases", value);
    }

    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    public TerraformSet<string> Cidrs
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cidrs").ResolveNodes(ctx));
        set => SetArgument("cidrs", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => new TerraformReference<double>(this, "from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The ipv6_cidrs attribute.
    /// </summary>
    public TerraformSet<string> Ipv6Cidrs
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ipv6_cidrs").ResolveNodes(ctx));
        set => SetArgument("ipv6_cidrs", value);
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
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformValue<double> ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

}


/// <summary>
/// Represents a aws_lightsail_instance_public_ports Terraform resource.
/// Manages a aws_lightsail_instance_public_ports resource.
/// </summary>
public partial class AwsLightsailInstancePublicPorts(string name) : TerraformResource("aws_lightsail_instance_public_ports", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    public required TerraformValue<string> InstanceName
    {
        get => new TerraformReference<string>(this, "instance_name");
        set => SetArgument("instance_name", value);
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
    /// PortInfo block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortInfo block(s) required")]
    public required TerraformSet<AwsLightsailInstancePublicPortsPortInfoBlock> PortInfo
    {
        get => GetRequiredArgument<TerraformSet<AwsLightsailInstancePublicPortsPortInfoBlock>>("port_info");
        set => SetArgument("port_info", value);
    }

}
