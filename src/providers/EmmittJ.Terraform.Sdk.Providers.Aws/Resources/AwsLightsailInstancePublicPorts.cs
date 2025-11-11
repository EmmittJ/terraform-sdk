using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for port_info in .
/// Nesting mode: set
/// </summary>
public class AwsLightsailInstancePublicPortsPortInfoBlock
{
    /// <summary>
    /// The cidr_list_aliases attribute.
    /// </summary>
    [TerraformPropertyName("cidr_list_aliases")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> CidrListAliases { get; set; } = default!;

    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    [TerraformPropertyName("cidrs")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Cidrs { get; set; } = default!;

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    [TerraformPropertyName("from_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> FromPort { get; set; }

    /// <summary>
    /// The ipv6_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidrs")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Ipv6Cidrs { get; set; } = default!;

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    [TerraformPropertyName("to_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ToPort { get; set; }

}

/// <summary>
/// Manages a aws_lightsail_instance_public_ports resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLightsailInstancePublicPorts : TerraformResource
{
    public AwsLightsailInstancePublicPorts(string name) : base("aws_lightsail_instance_public_ports", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    [TerraformPropertyName("instance_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for port_info.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortInfo block(s) required")]
    [TerraformPropertyName("port_info")]
    public TerraformSet<TerraformBlock<AwsLightsailInstancePublicPortsPortInfoBlock>>? PortInfo { get; set; }

}
