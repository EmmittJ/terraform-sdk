using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cidr_authorization_context in AwsVpcIpamPoolCidr.
/// Nesting mode: list
/// </summary>
public class AwsVpcIpamPoolCidrCidrAuthorizationContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cidr_authorization_context";

    /// <summary>
    /// The message attribute.
    /// </summary>
    public TerraformValue<string>? Message
    {
        get => GetArgument<TerraformValue<string>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// The signature attribute.
    /// </summary>
    public TerraformValue<string>? Signature
    {
        get => GetArgument<TerraformValue<string>>("signature");
        set => SetArgument("signature", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVpcIpamPoolCidr.
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamPoolCidrTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_vpc_ipam_pool_cidr Terraform resource.
/// Manages a aws_vpc_ipam_pool_cidr resource.
/// </summary>
public partial class AwsVpcIpamPoolCidr(string name) : TerraformResource("aws_vpc_ipam_pool_cidr", name)
{
    /// <summary>
    /// The cidr attribute.
    /// </summary>
    public TerraformValue<string> Cidr
    {
        get => GetArgument<TerraformValue<string>>("cidr") ?? AsReference("cidr");
        set => SetArgument("cidr", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamPoolId is required")]
    public required TerraformValue<string> IpamPoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("ipam_pool_id");
        set => SetArgument("ipam_pool_id", value);
    }

    /// <summary>
    /// The netmask_length attribute.
    /// </summary>
    public TerraformValue<double> NetmaskLength
    {
        get => GetArgument<TerraformValue<double>>("netmask_length") ?? AsReference("netmask_length");
        set => SetArgument("netmask_length", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The ipam_pool_cidr_id attribute.
    /// </summary>
    public TerraformValue<string> IpamPoolCidrId
        => AsReference("ipam_pool_cidr_id");

    /// <summary>
    /// CidrAuthorizationContext block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrAuthorizationContext block(s) allowed")]
    public TerraformList<AwsVpcIpamPoolCidrCidrAuthorizationContextBlock>? CidrAuthorizationContext
    {
        get => GetArgument<TerraformList<AwsVpcIpamPoolCidrCidrAuthorizationContextBlock>>("cidr_authorization_context");
        set => SetArgument("cidr_authorization_context", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcIpamPoolCidrTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcIpamPoolCidrTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
