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
        get => new TerraformReference<string>(this, "read");
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "allocation_resource_tags").ResolveNodes(ctx));
        set => SetArgument("allocation_resource_tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? IpamPoolId
    {
        get => new TerraformReference<string>(this, "ipam_pool_id");
        set => SetArgument("ipam_pool_id", value);
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
    /// The address_family attribute.
    /// </summary>
    public TerraformValue<string> AddressFamily
    {
        get => new TerraformReference<string>(this, "address_family");
    }

    /// <summary>
    /// The allocation_default_netmask_length attribute.
    /// </summary>
    public TerraformValue<double> AllocationDefaultNetmaskLength
    {
        get => new TerraformReference<double>(this, "allocation_default_netmask_length");
    }

    /// <summary>
    /// The allocation_max_netmask_length attribute.
    /// </summary>
    public TerraformValue<double> AllocationMaxNetmaskLength
    {
        get => new TerraformReference<double>(this, "allocation_max_netmask_length");
    }

    /// <summary>
    /// The allocation_min_netmask_length attribute.
    /// </summary>
    public TerraformValue<double> AllocationMinNetmaskLength
    {
        get => new TerraformReference<double>(this, "allocation_min_netmask_length");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The auto_import attribute.
    /// </summary>
    public TerraformValue<bool> AutoImport
    {
        get => new TerraformReference<bool>(this, "auto_import");
    }

    /// <summary>
    /// The aws_service attribute.
    /// </summary>
    public TerraformValue<string> AwsService
    {
        get => new TerraformReference<string>(this, "aws_service");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The ipam_scope_id attribute.
    /// </summary>
    public TerraformValue<string> IpamScopeId
    {
        get => new TerraformReference<string>(this, "ipam_scope_id");
    }

    /// <summary>
    /// The ipam_scope_type attribute.
    /// </summary>
    public TerraformValue<string> IpamScopeType
    {
        get => new TerraformReference<string>(this, "ipam_scope_type");
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformValue<string> Locale
    {
        get => new TerraformReference<string>(this, "locale");
    }

    /// <summary>
    /// The pool_depth attribute.
    /// </summary>
    public TerraformValue<double> PoolDepth
    {
        get => new TerraformReference<double>(this, "pool_depth");
    }

    /// <summary>
    /// The publicly_advertisable attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAdvertisable
    {
        get => new TerraformReference<bool>(this, "publicly_advertisable");
    }

    /// <summary>
    /// The source_ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string> SourceIpamPoolId
    {
        get => new TerraformReference<string>(this, "source_ipam_pool_id");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

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
