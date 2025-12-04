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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("allocation_id");
        set => SetArgument("allocation_id", value);
    }

    /// <summary>
    /// The connectivity_type attribute.
    /// </summary>
    public TerraformValue<string>? ConnectivityType
    {
        get => GetArgument<TerraformValue<string>>("connectivity_type");
        set => SetArgument("connectivity_type", value);
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
    /// The private_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateIp
    {
        get => GetArgument<TerraformValue<string>>("private_ip") ?? AsReference("private_ip");
        set => SetArgument("private_ip", value);
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
    /// The secondary_allocation_ids attribute.
    /// </summary>
    public TerraformSet<string> SecondaryAllocationIds
    {
        get => GetArgument<TerraformSet<string>>("secondary_allocation_ids") ?? AsReference("secondary_allocation_ids");
        set => SetArgument("secondary_allocation_ids", value);
    }

    /// <summary>
    /// The secondary_private_ip_address_count attribute.
    /// </summary>
    public TerraformValue<double> SecondaryPrivateIpAddressCount
    {
        get => GetArgument<TerraformValue<double>>("secondary_private_ip_address_count") ?? AsReference("secondary_private_ip_address_count");
        set => SetArgument("secondary_private_ip_address_count", value);
    }

    /// <summary>
    /// The secondary_private_ip_addresses attribute.
    /// </summary>
    public TerraformSet<string> SecondaryPrivateIpAddresses
    {
        get => GetArgument<TerraformSet<string>>("secondary_private_ip_addresses") ?? AsReference("secondary_private_ip_addresses");
        set => SetArgument("secondary_private_ip_addresses", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationId
        => AsReference("association_id");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
        => AsReference("network_interface_id");

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformValue<string> PublicIp
        => AsReference("public_ip");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNatGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNatGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
