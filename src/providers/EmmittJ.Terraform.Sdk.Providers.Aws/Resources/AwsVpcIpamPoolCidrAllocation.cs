using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpc_ipam_pool_cidr_allocation Terraform resource.
/// Manages a aws_vpc_ipam_pool_cidr_allocation resource.
/// </summary>
public partial class AwsVpcIpamPoolCidrAllocation(string name) : TerraformResource("aws_vpc_ipam_pool_cidr_allocation", name)
{
    /// <summary>
    /// The cidr attribute.
    /// </summary>
    public TerraformValue<string> Cidr
    {
        get => new TerraformReference<string>(this, "cidr");
        set => SetArgument("cidr", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The disallowed_cidrs attribute.
    /// </summary>
    public TerraformSet<string>? DisallowedCidrs
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "disallowed_cidrs").ResolveNodes(ctx));
        set => SetArgument("disallowed_cidrs", value);
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
    /// The ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamPoolId is required")]
    public required TerraformValue<string> IpamPoolId
    {
        get => new TerraformReference<string>(this, "ipam_pool_id");
        set => SetArgument("ipam_pool_id", value);
    }

    /// <summary>
    /// The netmask_length attribute.
    /// </summary>
    public TerraformValue<double> NetmaskLength
    {
        get => new TerraformReference<double>(this, "netmask_length");
        set => SetArgument("netmask_length", value);
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
    /// The ipam_pool_allocation_id attribute.
    /// </summary>
    public TerraformValue<string> IpamPoolAllocationId
    {
        get => new TerraformReference<string>(this, "ipam_pool_allocation_id");
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
    }

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    public TerraformValue<string> ResourceOwner
    {
        get => new TerraformReference<string>(this, "resource_owner");
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
    }

}
