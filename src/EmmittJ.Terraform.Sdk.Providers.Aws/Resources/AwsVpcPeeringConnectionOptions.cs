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
        get => GetProperty<TerraformProperty<bool>>("allow_remote_vpc_dns_resolution");
        set => WithProperty("allow_remote_vpc_dns_resolution", value);
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
        get => GetProperty<TerraformProperty<bool>>("allow_remote_vpc_dns_resolution");
        set => WithProperty("allow_remote_vpc_dns_resolution", value);
    }

}

/// <summary>
/// Manages a aws_vpc_peering_connection_options resource.
/// </summary>
public class AwsVpcPeeringConnectionOptions : TerraformResource
{
    public AwsVpcPeeringConnectionOptions(string name) : base("aws_vpc_peering_connection_options", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcPeeringConnectionId is required")]
    public required TerraformProperty<string> VpcPeeringConnectionId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_peering_connection_id");
        set => this.WithProperty("vpc_peering_connection_id", value);
    }

    /// <summary>
    /// Block for accepter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Accepter block(s) allowed")]
    public List<AwsVpcPeeringConnectionOptionsAccepterBlock>? Accepter
    {
        get => GetProperty<List<AwsVpcPeeringConnectionOptionsAccepterBlock>>("accepter");
        set => this.WithProperty("accepter", value);
    }

    /// <summary>
    /// Block for requester.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Requester block(s) allowed")]
    public List<AwsVpcPeeringConnectionOptionsRequesterBlock>? Requester
    {
        get => GetProperty<List<AwsVpcPeeringConnectionOptionsRequesterBlock>>("requester");
        set => this.WithProperty("requester", value);
    }

}
