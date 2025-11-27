using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for operating_regions in AwsVpcIpam.
/// Nesting mode: set
/// </summary>
public class AwsVpcIpamOperatingRegionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operating_regions";

    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    public required TerraformValue<string> RegionName
    {
        get => new TerraformReference<string>(this, "region_name");
        set => SetArgument("region_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVpcIpam.
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamTimeoutsBlock : TerraformBlock
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
/// Represents a aws_vpc_ipam Terraform resource.
/// Manages a aws_vpc_ipam resource.
/// </summary>
public partial class AwsVpcIpam(string name) : TerraformResource("aws_vpc_ipam", name)
{
    /// <summary>
    /// The cascade attribute.
    /// </summary>
    public TerraformValue<bool>? Cascade
    {
        get => new TerraformReference<bool>(this, "cascade");
        set => SetArgument("cascade", value);
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
    /// The enable_private_gua attribute.
    /// </summary>
    public TerraformValue<bool>? EnablePrivateGua
    {
        get => new TerraformReference<bool>(this, "enable_private_gua");
        set => SetArgument("enable_private_gua", value);
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
    /// The metered_account attribute.
    /// </summary>
    public TerraformValue<string> MeteredAccount
    {
        get => new TerraformReference<string>(this, "metered_account");
        set => SetArgument("metered_account", value);
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
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string>? Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The default_resource_discovery_association_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultResourceDiscoveryAssociationId
    {
        get => new TerraformReference<string>(this, "default_resource_discovery_association_id");
    }

    /// <summary>
    /// The default_resource_discovery_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultResourceDiscoveryId
    {
        get => new TerraformReference<string>(this, "default_resource_discovery_id");
    }

    /// <summary>
    /// The private_default_scope_id attribute.
    /// </summary>
    public TerraformValue<string> PrivateDefaultScopeId
    {
        get => new TerraformReference<string>(this, "private_default_scope_id");
    }

    /// <summary>
    /// The public_default_scope_id attribute.
    /// </summary>
    public TerraformValue<string> PublicDefaultScopeId
    {
        get => new TerraformReference<string>(this, "public_default_scope_id");
    }

    /// <summary>
    /// The scope_count attribute.
    /// </summary>
    public TerraformValue<double> ScopeCount
    {
        get => new TerraformReference<double>(this, "scope_count");
    }

    /// <summary>
    /// OperatingRegions block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatingRegions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OperatingRegions block(s) required")]
    public required TerraformSet<AwsVpcIpamOperatingRegionsBlock> OperatingRegions
    {
        get => GetRequiredArgument<TerraformSet<AwsVpcIpamOperatingRegionsBlock>>("operating_regions");
        set => SetArgument("operating_regions", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcIpamTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcIpamTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
