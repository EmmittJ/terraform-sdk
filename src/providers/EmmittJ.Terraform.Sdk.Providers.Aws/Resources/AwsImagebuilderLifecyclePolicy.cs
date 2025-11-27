using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for policy_detail in AwsImagebuilderLifecyclePolicy.
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderLifecyclePolicyPolicyDetailBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_detail";

    /// <summary>
    /// Action block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsImagebuilderLifecyclePolicyPolicyDetailBlockActionBlock>? Action
    {
        get => GetArgument<TerraformList<AwsImagebuilderLifecyclePolicyPolicyDetailBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// ExclusionRules block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsImagebuilderLifecyclePolicyPolicyDetailBlockExclusionRulesBlock>? ExclusionRules
    {
        get => GetArgument<TerraformList<AwsImagebuilderLifecyclePolicyPolicyDetailBlockExclusionRulesBlock>>("exclusion_rules");
        set => SetArgument("exclusion_rules", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsImagebuilderLifecyclePolicyPolicyDetailBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AwsImagebuilderLifecyclePolicyPolicyDetailBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}

/// <summary>
/// Block type for action in AwsImagebuilderLifecyclePolicyPolicyDetailBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderLifecyclePolicyPolicyDetailBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// IncludeResources block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsImagebuilderLifecyclePolicyPolicyDetailBlockActionBlockIncludeResourcesBlock>? IncludeResources
    {
        get => GetArgument<TerraformList<AwsImagebuilderLifecyclePolicyPolicyDetailBlockActionBlockIncludeResourcesBlock>>("include_resources");
        set => SetArgument("include_resources", value);
    }

}

/// <summary>
/// Block type for include_resources in AwsImagebuilderLifecyclePolicyPolicyDetailBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderLifecyclePolicyPolicyDetailBlockActionBlockIncludeResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_resources";

    /// <summary>
    /// The amis attribute.
    /// </summary>
    public TerraformValue<bool> Amis
    {
        get => new TerraformReference<bool>(this, "amis");
        set => SetArgument("amis", value);
    }

    /// <summary>
    /// The containers attribute.
    /// </summary>
    public TerraformValue<bool> Containers
    {
        get => new TerraformReference<bool>(this, "containers");
        set => SetArgument("containers", value);
    }

    /// <summary>
    /// The snapshots attribute.
    /// </summary>
    public TerraformValue<bool> Snapshots
    {
        get => new TerraformReference<bool>(this, "snapshots");
        set => SetArgument("snapshots", value);
    }

}

/// <summary>
/// Block type for exclusion_rules in AwsImagebuilderLifecyclePolicyPolicyDetailBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderLifecyclePolicyPolicyDetailBlockExclusionRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion_rules";

    /// <summary>
    /// The tag_map attribute.
    /// </summary>
    public TerraformMap<string>? TagMap
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tag_map").ResolveNodes(ctx));
        set => SetArgument("tag_map", value);
    }

    /// <summary>
    /// Amis block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsImagebuilderLifecyclePolicyPolicyDetailBlockExclusionRulesBlockAmisBlock>? Amis
    {
        get => GetArgument<TerraformList<AwsImagebuilderLifecyclePolicyPolicyDetailBlockExclusionRulesBlockAmisBlock>>("amis");
        set => SetArgument("amis", value);
    }

}

/// <summary>
/// Block type for amis in AwsImagebuilderLifecyclePolicyPolicyDetailBlockExclusionRulesBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderLifecyclePolicyPolicyDetailBlockExclusionRulesBlockAmisBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amis";

    /// <summary>
    /// The is_public attribute.
    /// </summary>
    public TerraformValue<bool> IsPublic
    {
        get => new TerraformReference<bool>(this, "is_public");
        set => SetArgument("is_public", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformList<string>? Regions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "regions").ResolveNodes(ctx));
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// The shared_accounts attribute.
    /// </summary>
    public TerraformList<string>? SharedAccounts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "shared_accounts").ResolveNodes(ctx));
        set => SetArgument("shared_accounts", value);
    }

    /// <summary>
    /// The tag_map attribute.
    /// </summary>
    public TerraformMap<string>? TagMap
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tag_map").ResolveNodes(ctx));
        set => SetArgument("tag_map", value);
    }

    /// <summary>
    /// LastLaunched block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsImagebuilderLifecyclePolicyPolicyDetailBlockExclusionRulesBlockAmisBlockLastLaunchedBlock>? LastLaunched
    {
        get => GetArgument<TerraformList<AwsImagebuilderLifecyclePolicyPolicyDetailBlockExclusionRulesBlockAmisBlockLastLaunchedBlock>>("last_launched");
        set => SetArgument("last_launched", value);
    }

}

/// <summary>
/// Block type for last_launched in AwsImagebuilderLifecyclePolicyPolicyDetailBlockExclusionRulesBlockAmisBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderLifecyclePolicyPolicyDetailBlockExclusionRulesBlockAmisBlockLastLaunchedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "last_launched";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => new TerraformReference<double>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for filter in AwsImagebuilderLifecyclePolicyPolicyDetailBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderLifecyclePolicyPolicyDetailBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The retain_at_least attribute.
    /// </summary>
    public TerraformValue<double>? RetainAtLeast
    {
        get => new TerraformReference<double>(this, "retain_at_least");
        set => SetArgument("retain_at_least", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => new TerraformReference<double>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for resource_selection in AwsImagebuilderLifecyclePolicy.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderLifecyclePolicyResourceSelectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_selection";

    /// <summary>
    /// The tag_map attribute.
    /// </summary>
    public TerraformMap<string>? TagMap
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tag_map").ResolveNodes(ctx));
        set => SetArgument("tag_map", value);
    }

    /// <summary>
    /// Recipe block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsImagebuilderLifecyclePolicyResourceSelectionBlockRecipeBlock>? Recipe
    {
        get => GetArgument<TerraformSet<AwsImagebuilderLifecyclePolicyResourceSelectionBlockRecipeBlock>>("recipe");
        set => SetArgument("recipe", value);
    }

}

/// <summary>
/// Block type for recipe in AwsImagebuilderLifecyclePolicyResourceSelectionBlock.
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderLifecyclePolicyResourceSelectionBlockRecipeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recipe";

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
    /// The semantic_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SemanticVersion is required")]
    public required TerraformValue<string> SemanticVersion
    {
        get => new TerraformReference<string>(this, "semantic_version");
        set => SetArgument("semantic_version", value);
    }

}


/// <summary>
/// Represents a aws_imagebuilder_lifecycle_policy Terraform resource.
/// Manages a aws_imagebuilder_lifecycle_policy resource.
/// </summary>
public partial class AwsImagebuilderLifecyclePolicy(string name) : TerraformResource("aws_imagebuilder_lifecycle_policy", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    public required TerraformValue<string> ExecutionRole
    {
        get => new TerraformReference<string>(this, "execution_role");
        set => SetArgument("execution_role", value);
    }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// PolicyDetail block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsImagebuilderLifecyclePolicyPolicyDetailBlock>? PolicyDetail
    {
        get => GetArgument<TerraformSet<AwsImagebuilderLifecyclePolicyPolicyDetailBlock>>("policy_detail");
        set => SetArgument("policy_detail", value);
    }

    /// <summary>
    /// ResourceSelection block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsImagebuilderLifecyclePolicyResourceSelectionBlock>? ResourceSelection
    {
        get => GetArgument<TerraformList<AwsImagebuilderLifecyclePolicyResourceSelectionBlock>>("resource_selection");
        set => SetArgument("resource_selection", value);
    }

}
