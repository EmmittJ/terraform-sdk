using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsVpcIpv6CidrBlockAssociation.
/// Nesting mode: single
/// </summary>
public class AwsVpcIpv6CidrBlockAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a aws_vpc_ipv6_cidr_block_association Terraform resource.
/// Manages a aws_vpc_ipv6_cidr_block_association resource.
/// </summary>
public partial class AwsVpcIpv6CidrBlockAssociation(string name) : TerraformResource("aws_vpc_ipv6_cidr_block_association", name)
{
    /// <summary>
    /// The assign_generated_ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<bool> AssignGeneratedIpv6CidrBlock
    {
        get => GetArgument<TerraformValue<bool>>("assign_generated_ipv6_cidr_block") ?? AsReference("assign_generated_ipv6_cidr_block");
        set => SetArgument("assign_generated_ipv6_cidr_block", value);
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
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string> Ipv6CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("ipv6_cidr_block") ?? AsReference("ipv6_cidr_block");
        set => SetArgument("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The ipv6_ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6IpamPoolId
    {
        get => GetArgument<TerraformValue<string>>("ipv6_ipam_pool_id");
        set => SetArgument("ipv6_ipam_pool_id", value);
    }

    /// <summary>
    /// The ipv6_netmask_length attribute.
    /// </summary>
    public TerraformValue<double>? Ipv6NetmaskLength
    {
        get => GetArgument<TerraformValue<double>>("ipv6_netmask_length");
        set => SetArgument("ipv6_netmask_length", value);
    }

    /// <summary>
    /// The ipv6_pool attribute.
    /// </summary>
    public TerraformValue<string> Ipv6Pool
    {
        get => GetArgument<TerraformValue<string>>("ipv6_pool") ?? AsReference("ipv6_pool");
        set => SetArgument("ipv6_pool", value);
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
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The ip_source attribute.
    /// </summary>
    public TerraformValue<string> IpSource
        => AsReference("ip_source");

    /// <summary>
    /// The ipv6_address_attribute attribute.
    /// </summary>
    public TerraformValue<string> Ipv6AddressAttribute
        => AsReference("ipv6_address_attribute");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcIpv6CidrBlockAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcIpv6CidrBlockAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
