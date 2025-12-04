using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in AwsEcrLifecyclePolicyDocumentDataSource.
/// Nesting mode: list
/// </summary>
public class AwsEcrLifecyclePolicyDocumentDataSourceRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// Action block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEcrLifecyclePolicyDocumentDataSourceRuleBlockActionBlock>? Action
    {
        get => GetArgument<TerraformList<AwsEcrLifecyclePolicyDocumentDataSourceRuleBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Selection block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEcrLifecyclePolicyDocumentDataSourceRuleBlockSelectionBlock>? Selection
    {
        get => GetArgument<TerraformList<AwsEcrLifecyclePolicyDocumentDataSourceRuleBlockSelectionBlock>>("selection");
        set => SetArgument("selection", value);
    }

}

/// <summary>
/// Block type for action in AwsEcrLifecyclePolicyDocumentDataSourceRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcrLifecyclePolicyDocumentDataSourceRuleBlockActionBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for selection in AwsEcrLifecyclePolicyDocumentDataSourceRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcrLifecyclePolicyDocumentDataSourceRuleBlockSelectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selection";

    /// <summary>
    /// The count_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountNumber is required")]
    public required TerraformValue<double> CountNumber
    {
        get => GetArgument<TerraformValue<double>>("count_number");
        set => SetArgument("count_number", value);
    }

    /// <summary>
    /// The count_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountType is required")]
    public required TerraformValue<string> CountType
    {
        get => GetArgument<TerraformValue<string>>("count_type");
        set => SetArgument("count_type", value);
    }

    /// <summary>
    /// The count_unit attribute.
    /// </summary>
    public TerraformValue<string>? CountUnit
    {
        get => GetArgument<TerraformValue<string>>("count_unit");
        set => SetArgument("count_unit", value);
    }

    /// <summary>
    /// The tag_pattern_list attribute.
    /// </summary>
    public TerraformList<string>? TagPatternList
    {
        get => GetArgument<TerraformList<string>>("tag_pattern_list");
        set => SetArgument("tag_pattern_list", value);
    }

    /// <summary>
    /// The tag_prefix_list attribute.
    /// </summary>
    public TerraformList<string>? TagPrefixList
    {
        get => GetArgument<TerraformList<string>>("tag_prefix_list");
        set => SetArgument("tag_prefix_list", value);
    }

    /// <summary>
    /// The tag_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagStatus is required")]
    public required TerraformValue<string> TagStatus
    {
        get => GetArgument<TerraformValue<string>>("tag_status");
        set => SetArgument("tag_status", value);
    }

}


/// <summary>
/// Represents a aws_ecr_lifecycle_policy_document Terraform data source.
/// Retrieves information about a aws_ecr_lifecycle_policy_document.
/// </summary>
public partial class AwsEcrLifecyclePolicyDocumentDataSource(string name) : TerraformDataSource("aws_ecr_lifecycle_policy_document", name)
{
    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformValue<string> Json
        => AsReference("json");

    /// <summary>
    /// Rule block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEcrLifecyclePolicyDocumentDataSourceRuleBlock>? Rule
    {
        get => GetArgument<TerraformList<AwsEcrLifecyclePolicyDocumentDataSourceRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}
