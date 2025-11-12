using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for port_info in .
/// Nesting mode: set
/// </summary>
public partial class AwsLightsailInstancePublicPortsPortInfoBlock() : TerraformBlock("port_info")
{
    /// <summary>
    /// The cidr_list_aliases attribute.
    /// </summary>
    [TerraformProperty("cidr_list_aliases")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> CidrListAliases { get; set; }

    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    [TerraformProperty("cidrs")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Cidrs { get; set; }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    [TerraformProperty("from_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> FromPort { get; set; }

    /// <summary>
    /// The ipv6_cidrs attribute.
    /// </summary>
    [TerraformProperty("ipv6_cidrs")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Ipv6Cidrs { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    [TerraformProperty("to_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ToPort { get; set; }

}

/// <summary>
/// Manages a aws_lightsail_instance_public_ports resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLightsailInstancePublicPorts : TerraformResource
{
    public AwsLightsailInstancePublicPorts(string name) : base("aws_lightsail_instance_public_ports", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    [TerraformProperty("instance_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for port_info.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortInfo block(s) required")]
    [TerraformProperty("port_info")]
    public required TerraformSet<AwsLightsailInstancePublicPortsPortInfoBlock> PortInfo { get; set; } = new();

}
