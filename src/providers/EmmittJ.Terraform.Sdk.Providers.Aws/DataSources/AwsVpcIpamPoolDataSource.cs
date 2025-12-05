using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsVpcIpamPoolDataSource.
/// Nesting mode: set
/// </summary>
public class AwsVpcIpamPoolDataSourceFilterBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVpcIpamPoolDataSource.
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamPoolDataSourceTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_vpc_ipam_pool Terraform data source.
/// Retrieves information about a aws_vpc_ipam_pool.
/// </summary>
public partial class AwsVpcIpamPoolDataSource(string name) : TerraformDataSource("aws_vpc_ipam_pool", name)
{
    /// <summary>
    /// The allocation_resource_tags attribute.
    /// </summary>
    public TerraformMap<string> AllocationResourceTags
    {
        get => GetArgument<TerraformMap<string>>("allocation_resource_tags") ?? CreateReference("allocation_resource_tags");
        set => SetArgument("allocation_resource_tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? IpamPoolId
    {
        get => GetArgument<TerraformValue<string>>("ipam_pool_id");
        set => SetArgument("ipam_pool_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    public TerraformValue<string> AddressFamily
        => CreateReference("address_family");

    /// <summary>
    /// The allocation_default_netmask_length attribute.
    /// </summary>
    public TerraformValue<double> AllocationDefaultNetmaskLength
        => CreateReference("allocation_default_netmask_length");

    /// <summary>
    /// The allocation_max_netmask_length attribute.
    /// </summary>
    public TerraformValue<double> AllocationMaxNetmaskLength
        => CreateReference("allocation_max_netmask_length");

    /// <summary>
    /// The allocation_min_netmask_length attribute.
    /// </summary>
    public TerraformValue<double> AllocationMinNetmaskLength
        => CreateReference("allocation_min_netmask_length");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The auto_import attribute.
    /// </summary>
    public TerraformValue<bool> AutoImport
        => CreateReference("auto_import");

    /// <summary>
    /// The aws_service attribute.
    /// </summary>
    public TerraformValue<string> AwsService
        => CreateReference("aws_service");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The ipam_scope_id attribute.
    /// </summary>
    public TerraformValue<string> IpamScopeId
        => CreateReference("ipam_scope_id");

    /// <summary>
    /// The ipam_scope_type attribute.
    /// </summary>
    public TerraformValue<string> IpamScopeType
        => CreateReference("ipam_scope_type");

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformValue<string> Locale
        => CreateReference("locale");

    /// <summary>
    /// The pool_depth attribute.
    /// </summary>
    public TerraformValue<double> PoolDepth
        => CreateReference("pool_depth");

    /// <summary>
    /// The publicly_advertisable attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAdvertisable
        => CreateReference("publicly_advertisable");

    /// <summary>
    /// The source_ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string> SourceIpamPoolId
        => CreateReference("source_ipam_pool_id");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsVpcIpamPoolDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsVpcIpamPoolDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcIpamPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcIpamPoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
