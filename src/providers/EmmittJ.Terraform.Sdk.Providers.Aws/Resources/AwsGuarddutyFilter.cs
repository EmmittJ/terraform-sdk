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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "equals").ResolveNodes(ctx));
        set => SetArgument("equals", value);
    }

    /// <summary>
    /// The field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    public required TerraformValue<string> Field
    {
        get => new TerraformReference<string>(this, "field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// The greater_than attribute.
    /// </summary>
    public TerraformValue<string>? GreaterThan
    {
        get => new TerraformReference<string>(this, "greater_than");
        set => SetArgument("greater_than", value);
    }

    /// <summary>
    /// The greater_than_or_equal attribute.
    /// </summary>
    public TerraformValue<string>? GreaterThanOrEqual
    {
        get => new TerraformReference<string>(this, "greater_than_or_equal");
        set => SetArgument("greater_than_or_equal", value);
    }

    /// <summary>
    /// The less_than attribute.
    /// </summary>
    public TerraformValue<string>? LessThan
    {
        get => new TerraformReference<string>(this, "less_than");
        set => SetArgument("less_than", value);
    }

    /// <summary>
    /// The less_than_or_equal attribute.
    /// </summary>
    public TerraformValue<string>? LessThanOrEqual
    {
        get => new TerraformReference<string>(this, "less_than_or_equal");
        set => SetArgument("less_than_or_equal", value);
    }

    /// <summary>
    /// The not_equals attribute.
    /// </summary>
    public TerraformList<string>? NotEquals
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "not_equals").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
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
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    public required TerraformValue<string> DetectorId
    {
        get => new TerraformReference<string>(this, "detector_id");
        set => SetArgument("detector_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The rank attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rank is required")]
    public required TerraformValue<double> Rank
    {
        get => new TerraformReference<double>(this, "rank");
        set => SetArgument("rank", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

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
