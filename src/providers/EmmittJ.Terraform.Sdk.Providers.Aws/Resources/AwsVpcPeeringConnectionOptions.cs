using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for accepter in AwsVpcPeeringConnectionOptions.
/// Nesting mode: list
/// </summary>
public class AwsVpcPeeringConnectionOptionsAccepterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accepter";

    /// <summary>
    /// The allow_remote_vpc_dns_resolution attribute.
    /// </summary>
    public TerraformValue<bool>? AllowRemoteVpcDnsResolution
    {
        get => GetArgument<TerraformValue<bool>>("allow_remote_vpc_dns_resolution");
        set => SetArgument("allow_remote_vpc_dns_resolution", value);
    }

}


/// <summary>
/// Block type for requester in AwsVpcPeeringConnectionOptions.
/// Nesting mode: list
/// </summary>
public class AwsVpcPeeringConnectionOptionsRequesterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "requester";

    /// <summary>
    /// The allow_remote_vpc_dns_resolution attribute.
    /// </summary>
    public TerraformValue<bool>? AllowRemoteVpcDnsResolution
    {
        get => GetArgument<TerraformValue<bool>>("allow_remote_vpc_dns_resolution");
        set => SetArgument("allow_remote_vpc_dns_resolution", value);
    }

}


/// <summary>
/// Represents a aws_vpc_peering_connection_options Terraform resource.
/// Manages a aws_vpc_peering_connection_options resource.
/// </summary>
public partial class AwsVpcPeeringConnectionOptions(string name) : TerraformResource("aws_vpc_peering_connection_options", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcPeeringConnectionId is required")]
    public required TerraformValue<string> VpcPeeringConnectionId
    {
        get => GetArgument<TerraformValue<string>>("vpc_peering_connection_id");
        set => SetArgument("vpc_peering_connection_id", value);
    }

    /// <summary>
    /// Accepter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Accepter block(s) allowed")]
    public TerraformList<AwsVpcPeeringConnectionOptionsAccepterBlock>? Accepter
    {
        get => GetArgument<TerraformList<AwsVpcPeeringConnectionOptionsAccepterBlock>>("accepter");
        set => SetArgument("accepter", value);
    }

    /// <summary>
    /// Requester block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Requester block(s) allowed")]
    public TerraformList<AwsVpcPeeringConnectionOptionsRequesterBlock>? Requester
    {
        get => GetArgument<TerraformList<AwsVpcPeeringConnectionOptionsRequesterBlock>>("requester");
        set => SetArgument("requester", value);
    }

}
