using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for accepter in .
/// Nesting mode: list
/// </summary>
public class AwsVpcPeeringConnectionOptionsAccepterBlock : TerraformBlock
{
    /// <summary>
    /// The allow_remote_vpc_dns_resolution attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowRemoteVpcDnsResolution
    {
        set => SetProperty("allow_remote_vpc_dns_resolution", value);
    }

}

/// <summary>
/// Block type for requester in .
/// Nesting mode: list
/// </summary>
public class AwsVpcPeeringConnectionOptionsRequesterBlock : TerraformBlock
{
    /// <summary>
    /// The allow_remote_vpc_dns_resolution attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowRemoteVpcDnsResolution
    {
        set => SetProperty("allow_remote_vpc_dns_resolution", value);
    }

}

/// <summary>
/// Manages a aws_vpc_peering_connection_options resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVpcPeeringConnectionOptions : TerraformResource
{
    public AwsVpcPeeringConnectionOptions(string name) : base("aws_vpc_peering_connection_options", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("region");
        SetOutput("vpc_peering_connection_id");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcPeeringConnectionId is required")]
    public required TerraformProperty<string> VpcPeeringConnectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_peering_connection_id");
        set => SetProperty("vpc_peering_connection_id", value);
    }

    /// <summary>
    /// Block for accepter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Accepter block(s) allowed")]
    public List<AwsVpcPeeringConnectionOptionsAccepterBlock>? Accepter
    {
        set => SetProperty("accepter", value);
    }

    /// <summary>
    /// Block for requester.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Requester block(s) allowed")]
    public List<AwsVpcPeeringConnectionOptionsRequesterBlock>? Requester
    {
        set => SetProperty("requester", value);
    }

}
