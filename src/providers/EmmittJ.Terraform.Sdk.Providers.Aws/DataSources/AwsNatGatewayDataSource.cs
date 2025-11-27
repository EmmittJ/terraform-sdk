using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsNatGatewayDataSource.
/// Nesting mode: set
/// </summary>
public class AwsNatGatewayDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsNatGatewayDataSource.
/// Nesting mode: single
/// </summary>
public class AwsNatGatewayDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_nat_gateway Terraform data source.
/// Retrieves information about a aws_nat_gateway.
/// </summary>
public partial class AwsNatGatewayDataSource(string name) : TerraformDataSource("aws_nat_gateway", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformValue<string> AllocationId
    {
        get => new TerraformReference<string>(this, "allocation_id");
    }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationId
    {
        get => new TerraformReference<string>(this, "association_id");
    }

    /// <summary>
    /// The connectivity_type attribute.
    /// </summary>
    public TerraformValue<string> ConnectivityType
    {
        get => new TerraformReference<string>(this, "connectivity_type");
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "network_interface_id");
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateIp
    {
        get => new TerraformReference<string>(this, "private_ip");
    }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformValue<string> PublicIp
    {
        get => new TerraformReference<string>(this, "public_ip");
    }

    /// <summary>
    /// The secondary_allocation_ids attribute.
    /// </summary>
    public TerraformList<string> SecondaryAllocationIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "secondary_allocation_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The secondary_private_ip_address_count attribute.
    /// </summary>
    public TerraformValue<double> SecondaryPrivateIpAddressCount
    {
        get => new TerraformReference<double>(this, "secondary_private_ip_address_count");
    }

    /// <summary>
    /// The secondary_private_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> SecondaryPrivateIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "secondary_private_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNatGatewayDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsNatGatewayDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNatGatewayDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNatGatewayDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
