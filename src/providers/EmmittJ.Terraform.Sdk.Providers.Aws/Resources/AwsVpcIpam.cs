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
        get => GetRequiredArgument<TerraformValue<string>>("region_name");
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
    /// The enable_private_gua attribute.
    /// </summary>
    public TerraformValue<bool>? EnablePrivateGua
    {
        get => GetArgument<TerraformValue<bool>>("enable_private_gua");
        set => SetArgument("enable_private_gua", value);
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
    /// The metered_account attribute.
    /// </summary>
    public TerraformValue<string> MeteredAccount
    {
        get => GetArgument<TerraformValue<string>>("metered_account") ?? AsReference("metered_account");
        set => SetArgument("metered_account", value);
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
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string>? Tier
    {
        get => GetArgument<TerraformValue<string>>("tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The default_resource_discovery_association_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultResourceDiscoveryAssociationId
        => AsReference("default_resource_discovery_association_id");

    /// <summary>
    /// The default_resource_discovery_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultResourceDiscoveryId
        => AsReference("default_resource_discovery_id");

    /// <summary>
    /// The private_default_scope_id attribute.
    /// </summary>
    public TerraformValue<string> PrivateDefaultScopeId
        => AsReference("private_default_scope_id");

    /// <summary>
    /// The public_default_scope_id attribute.
    /// </summary>
    public TerraformValue<string> PublicDefaultScopeId
        => AsReference("public_default_scope_id");

    /// <summary>
    /// The scope_count attribute.
    /// </summary>
    public TerraformValue<double> ScopeCount
        => AsReference("scope_count");

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
