using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsVpcIpamPool.
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamPoolTimeoutsBlock : TerraformBlock
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
/// Represents a aws_vpc_ipam_pool Terraform resource.
/// Manages a aws_vpc_ipam_pool resource.
/// </summary>
public partial class AwsVpcIpamPool(string name) : TerraformResource("aws_vpc_ipam_pool", name)
{
    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressFamily is required")]
    public required TerraformValue<string> AddressFamily
    {
        get => GetArgument<TerraformValue<string>>("address_family");
        set => SetArgument("address_family", value);
    }

    /// <summary>
    /// The allocation_default_netmask_length attribute.
    /// </summary>
    public TerraformValue<double>? AllocationDefaultNetmaskLength
    {
        get => GetArgument<TerraformValue<double>>("allocation_default_netmask_length");
        set => SetArgument("allocation_default_netmask_length", value);
    }

    /// <summary>
    /// The allocation_max_netmask_length attribute.
    /// </summary>
    public TerraformValue<double>? AllocationMaxNetmaskLength
    {
        get => GetArgument<TerraformValue<double>>("allocation_max_netmask_length");
        set => SetArgument("allocation_max_netmask_length", value);
    }

    /// <summary>
    /// The allocation_min_netmask_length attribute.
    /// </summary>
    public TerraformValue<double>? AllocationMinNetmaskLength
    {
        get => GetArgument<TerraformValue<double>>("allocation_min_netmask_length");
        set => SetArgument("allocation_min_netmask_length", value);
    }

    /// <summary>
    /// The allocation_resource_tags attribute.
    /// </summary>
    public TerraformMap<string>? AllocationResourceTags
    {
        get => GetArgument<TerraformMap<string>>("allocation_resource_tags");
        set => SetArgument("allocation_resource_tags", value);
    }

    /// <summary>
    /// The auto_import attribute.
    /// </summary>
    public TerraformValue<bool>? AutoImport
    {
        get => GetArgument<TerraformValue<bool>>("auto_import");
        set => SetArgument("auto_import", value);
    }

    /// <summary>
    /// The aws_service attribute.
    /// </summary>
    public TerraformValue<string>? AwsService
    {
        get => GetArgument<TerraformValue<string>>("aws_service");
        set => SetArgument("aws_service", value);
    }

    /// <summary>
    /// The cascade attribute.
    /// </summary>
    public TerraformValue<bool>? Cascade
    {
        get => GetArgument<TerraformValue<bool>>("cascade");
        set => SetArgument("cascade", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The ipam_scope_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamScopeId is required")]
    public required TerraformValue<string> IpamScopeId
    {
        get => GetArgument<TerraformValue<string>>("ipam_scope_id");
        set => SetArgument("ipam_scope_id", value);
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformValue<string>? Locale
    {
        get => GetArgument<TerraformValue<string>>("locale");
        set => SetArgument("locale", value);
    }

    /// <summary>
    /// The public_ip_source attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpSource
    {
        get => GetArgument<TerraformValue<string>>("public_ip_source");
        set => SetArgument("public_ip_source", value);
    }

    /// <summary>
    /// The publicly_advertisable attribute.
    /// </summary>
    public TerraformValue<bool>? PubliclyAdvertisable
    {
        get => GetArgument<TerraformValue<bool>>("publicly_advertisable");
        set => SetArgument("publicly_advertisable", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceIpamPoolId
    {
        get => GetArgument<TerraformValue<string>>("source_ipam_pool_id");
        set => SetArgument("source_ipam_pool_id", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The ipam_scope_type attribute.
    /// </summary>
    public TerraformValue<string> IpamScopeType
        => AsReference("ipam_scope_type");

    /// <summary>
    /// The pool_depth attribute.
    /// </summary>
    public TerraformValue<double> PoolDepth
        => AsReference("pool_depth");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcIpamPoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcIpamPoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
