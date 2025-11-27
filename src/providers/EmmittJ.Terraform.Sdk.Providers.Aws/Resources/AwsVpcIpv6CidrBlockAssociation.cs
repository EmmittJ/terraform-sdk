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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
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
        get => new TerraformReference<bool>(this, "assign_generated_ipv6_cidr_block");
        set => SetArgument("assign_generated_ipv6_cidr_block", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string> Ipv6CidrBlock
    {
        get => new TerraformReference<string>(this, "ipv6_cidr_block");
        set => SetArgument("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The ipv6_ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6IpamPoolId
    {
        get => new TerraformReference<string>(this, "ipv6_ipam_pool_id");
        set => SetArgument("ipv6_ipam_pool_id", value);
    }

    /// <summary>
    /// The ipv6_netmask_length attribute.
    /// </summary>
    public TerraformValue<double>? Ipv6NetmaskLength
    {
        get => new TerraformReference<double>(this, "ipv6_netmask_length");
        set => SetArgument("ipv6_netmask_length", value);
    }

    /// <summary>
    /// The ipv6_pool attribute.
    /// </summary>
    public TerraformValue<string> Ipv6Pool
    {
        get => new TerraformReference<string>(this, "ipv6_pool");
        set => SetArgument("ipv6_pool", value);
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
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The ip_source attribute.
    /// </summary>
    public TerraformValue<string> IpSource
    {
        get => new TerraformReference<string>(this, "ip_source");
    }

    /// <summary>
    /// The ipv6_address_attribute attribute.
    /// </summary>
    public TerraformValue<string> Ipv6AddressAttribute
    {
        get => new TerraformReference<string>(this, "ipv6_address_attribute");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcIpv6CidrBlockAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcIpv6CidrBlockAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
