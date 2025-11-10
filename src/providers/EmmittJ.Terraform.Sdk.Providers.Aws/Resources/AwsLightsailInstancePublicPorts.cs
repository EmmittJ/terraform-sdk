using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for port_info in .
/// Nesting mode: set
/// </summary>
public class AwsLightsailInstancePublicPortsPortInfoBlock : TerraformBlock
{
    /// <summary>
    /// The cidr_list_aliases attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? CidrListAliases
    {
        set => SetProperty("cidr_list_aliases", value);
    }

    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Cidrs
    {
        set => SetProperty("cidrs", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformProperty<double> FromPort
    {
        set => SetProperty("from_port", value);
    }

    /// <summary>
    /// The ipv6_cidrs attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Ipv6Cidrs
    {
        set => SetProperty("ipv6_cidrs", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformProperty<double> ToPort
    {
        set => SetProperty("to_port", value);
    }

}

/// <summary>
/// Manages a aws_lightsail_instance_public_ports resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLightsailInstancePublicPorts : TerraformResource
{
    public AwsLightsailInstancePublicPorts(string name) : base("aws_lightsail_instance_public_ports", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("instance_name");
        SetOutput("region");
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
    /// The instance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    public required TerraformProperty<string> InstanceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_name");
        set => SetProperty("instance_name", value);
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
    /// Block for port_info.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortInfo block(s) required")]
    public HashSet<AwsLightsailInstancePublicPortsPortInfoBlock>? PortInfo
    {
        set => SetProperty("port_info", value);
    }

}
