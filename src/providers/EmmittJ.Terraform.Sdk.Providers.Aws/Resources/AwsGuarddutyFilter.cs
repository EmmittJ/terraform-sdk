using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for finding_criteria in AwsGuarddutyFilter.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyFilterFindingCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "finding_criteria";

    /// <summary>
    /// Criterion block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criterion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criterion block(s) required")]
    public required TerraformSet<AwsGuarddutyFilterFindingCriteriaBlockCriterionBlock> Criterion
    {
        get => GetRequiredArgument<TerraformSet<AwsGuarddutyFilterFindingCriteriaBlockCriterionBlock>>("criterion");
        set => SetArgument("criterion", value);
    }

}

/// <summary>
/// Block type for criterion in AwsGuarddutyFilterFindingCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsGuarddutyFilterFindingCriteriaBlockCriterionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "criterion";

    /// <summary>
    /// The equals attribute.
    /// </summary>
    public TerraformList<string>? EqualsAttribute
    {
        get => GetArgument<TerraformList<string>>("equals");
        set => SetArgument("equals", value);
    }

    /// <summary>
    /// The field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    public required TerraformValue<string> Field
    {
        get => GetRequiredArgument<TerraformValue<string>>("field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// The greater_than attribute.
    /// </summary>
    public TerraformValue<string>? GreaterThan
    {
        get => GetArgument<TerraformValue<string>>("greater_than");
        set => SetArgument("greater_than", value);
    }

    /// <summary>
    /// The greater_than_or_equal attribute.
    /// </summary>
    public TerraformValue<string>? GreaterThanOrEqual
    {
        get => GetArgument<TerraformValue<string>>("greater_than_or_equal");
        set => SetArgument("greater_than_or_equal", value);
    }

    /// <summary>
    /// The less_than attribute.
    /// </summary>
    public TerraformValue<string>? LessThan
    {
        get => GetArgument<TerraformValue<string>>("less_than");
        set => SetArgument("less_than", value);
    }

    /// <summary>
    /// The less_than_or_equal attribute.
    /// </summary>
    public TerraformValue<string>? LessThanOrEqual
    {
        get => GetArgument<TerraformValue<string>>("less_than_or_equal");
        set => SetArgument("less_than_or_equal", value);
    }

    /// <summary>
    /// The not_equals attribute.
    /// </summary>
    public TerraformList<string>? NotEquals
    {
        get => GetArgument<TerraformList<string>>("not_equals");
        set => SetArgument("not_equals", value);
    }

}


/// <summary>
/// Represents a aws_guardduty_filter Terraform resource.
/// Manages a aws_guardduty_filter resource.
/// </summary>
public partial class AwsGuarddutyFilter(string name) : TerraformResource("aws_guardduty_filter", name)
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
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
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    public required TerraformValue<string> DetectorId
    {
        get => GetRequiredArgument<TerraformValue<string>>("detector_id");
        set => SetArgument("detector_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The rank attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rank is required")]
    public required TerraformValue<double> Rank
    {
        get => GetRequiredArgument<TerraformValue<double>>("rank");
        set => SetArgument("rank", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// FindingCriteria block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FindingCriteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FindingCriteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FindingCriteria block(s) allowed")]
    public required TerraformList<AwsGuarddutyFilterFindingCriteriaBlock> FindingCriteria
    {
        get => GetRequiredArgument<TerraformList<AwsGuarddutyFilterFindingCriteriaBlock>>("finding_criteria");
        set => SetArgument("finding_criteria", value);
    }

}
