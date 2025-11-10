using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for port_info in .
/// Nesting mode: set
/// </summary>
public class AwsLightsailInstancePublicPortsPortInfoBlock : ITerraformBlock
{
    /// <summary>
    /// The cidr_list_aliases attribute.
    /// </summary>
    [TerraformPropertyName("cidr_list_aliases")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> CidrListAliases { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "cidr_list_aliases");

    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    [TerraformPropertyName("cidrs")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Cidrs { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "cidrs");

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    [TerraformPropertyName("from_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> FromPort { get; set; }

    /// <summary>
    /// The ipv6_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidrs")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Ipv6Cidrs { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "ipv6_cidrs");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    [TerraformPropertyName("to_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ToPort { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    [TerraformPropertyName("instance_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for port_info.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortInfo block(s) required")]
    [TerraformPropertyName("port_info")]
    public TerraformSet<TerraformBlock<AwsLightsailInstancePublicPortsPortInfoBlock>>? PortInfo { get; set; } = new();

}
