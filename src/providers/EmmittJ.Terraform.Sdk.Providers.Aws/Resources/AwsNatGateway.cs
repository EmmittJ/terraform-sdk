using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsNatGateway.
/// Nesting mode: single
/// </summary>
public class AwsNatGatewayTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_nat_gateway Terraform resource.
/// Manages a aws_nat_gateway resource.
/// </summary>
public partial class AwsNatGateway(string name) : TerraformResource("aws_nat_gateway", name)
{
    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformValue<string>? AllocationId
    {
        get => new TerraformReference<string>(this, "allocation_id");
        set => SetArgument("allocation_id", value);
    }

    /// <summary>
    /// The connectivity_type attribute.
    /// </summary>
    public TerraformValue<string>? ConnectivityType
    {
        get => new TerraformReference<string>(this, "connectivity_type");
        set => SetArgument("connectivity_type", value);
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
    /// The private_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateIp
    {
        get => new TerraformReference<string>(this, "private_ip");
        set => SetArgument("private_ip", value);
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
    /// The secondary_allocation_ids attribute.
    /// </summary>
    public TerraformSet<string> SecondaryAllocationIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "secondary_allocation_ids").ResolveNodes(ctx));
        set => SetArgument("secondary_allocation_ids", value);
    }

    /// <summary>
    /// The secondary_private_ip_address_count attribute.
    /// </summary>
    public TerraformValue<double> SecondaryPrivateIpAddressCount
    {
        get => new TerraformReference<double>(this, "secondary_private_ip_address_count");
        set => SetArgument("secondary_private_ip_address_count", value);
    }

    /// <summary>
    /// The secondary_private_ip_addresses attribute.
    /// </summary>
    public TerraformSet<string> SecondaryPrivateIpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "secondary_private_ip_addresses").ResolveNodes(ctx));
        set => SetArgument("secondary_private_ip_addresses", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationId
    {
        get => new TerraformReference<string>(this, "association_id");
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "network_interface_id");
    }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformValue<string> PublicIp
    {
        get => new TerraformReference<string>(this, "public_ip");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNatGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNatGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
