using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsVpcIpv4CidrBlockAssociation.
/// Nesting mode: single
/// </summary>
public class AwsVpcIpv4CidrBlockAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a aws_vpc_ipv4_cidr_block_association Terraform resource.
/// Manages a aws_vpc_ipv4_cidr_block_association resource.
/// </summary>
public partial class AwsVpcIpv4CidrBlockAssociation(string name) : TerraformResource("aws_vpc_ipv4_cidr_block_association", name)
{
    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string> CidrBlock
    {
        get => new TerraformReference<string>(this, "cidr_block");
        set => SetArgument("cidr_block", value);
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
    /// The ipv4_ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? Ipv4IpamPoolId
    {
        get => new TerraformReference<string>(this, "ipv4_ipam_pool_id");
        set => SetArgument("ipv4_ipam_pool_id", value);
    }

    /// <summary>
    /// The ipv4_netmask_length attribute.
    /// </summary>
    public TerraformValue<double>? Ipv4NetmaskLength
    {
        get => new TerraformReference<double>(this, "ipv4_netmask_length");
        set => SetArgument("ipv4_netmask_length", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcIpv4CidrBlockAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcIpv4CidrBlockAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
