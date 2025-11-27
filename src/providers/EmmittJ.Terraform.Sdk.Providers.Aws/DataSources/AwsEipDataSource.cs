using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEipDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEipDataSourceFilterBlock : TerraformBlock
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
/// Block type for timeouts in AwsEipDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEipDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_eip Terraform data source.
/// Retrieves information about a aws_eip.
/// </summary>
public partial class AwsEipDataSource(string name) : TerraformDataSource("aws_eip", name)
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
    /// The public_ip attribute.
    /// </summary>
    public TerraformValue<string> PublicIp
    {
        get => new TerraformReference<string>(this, "public_ip");
        set => SetArgument("public_ip", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationId
    {
        get => new TerraformReference<string>(this, "association_id");
    }

    /// <summary>
    /// The carrier_ip attribute.
    /// </summary>
    public TerraformValue<string> CarrierIp
    {
        get => new TerraformReference<string>(this, "carrier_ip");
    }

    /// <summary>
    /// The customer_owned_ip attribute.
    /// </summary>
    public TerraformValue<string> CustomerOwnedIp
    {
        get => new TerraformReference<string>(this, "customer_owned_ip");
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string> CustomerOwnedIpv4Pool
    {
        get => new TerraformReference<string>(this, "customer_owned_ipv4_pool");
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
    }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string> IpamPoolId
    {
        get => new TerraformReference<string>(this, "ipam_pool_id");
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "network_interface_id");
    }

    /// <summary>
    /// The network_interface_owner_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceOwnerId
    {
        get => new TerraformReference<string>(this, "network_interface_owner_id");
    }

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformValue<string> PrivateDns
    {
        get => new TerraformReference<string>(this, "private_dns");
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateIp
    {
        get => new TerraformReference<string>(this, "private_ip");
    }

    /// <summary>
    /// The ptr_record attribute.
    /// </summary>
    public TerraformValue<string> PtrRecord
    {
        get => new TerraformReference<string>(this, "ptr_record");
    }

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    public TerraformValue<string> PublicDns
    {
        get => new TerraformReference<string>(this, "public_dns");
    }

    /// <summary>
    /// The public_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string> PublicIpv4Pool
    {
        get => new TerraformReference<string>(this, "public_ipv4_pool");
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEipDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEipDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEipDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEipDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
