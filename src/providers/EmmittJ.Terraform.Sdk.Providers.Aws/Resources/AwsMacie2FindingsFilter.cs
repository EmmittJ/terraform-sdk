using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for finding_criteria in AwsMacie2FindingsFilter.
/// Nesting mode: list
/// </summary>
public class AwsMacie2FindingsFilterFindingCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "finding_criteria";

    /// <summary>
    /// Criterion block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsMacie2FindingsFilterFindingCriteriaBlockCriterionBlock>? Criterion
    {
        get => GetArgument<TerraformSet<AwsMacie2FindingsFilterFindingCriteriaBlockCriterionBlock>>("criterion");
        set => SetArgument("criterion", value);
    }

}

/// <summary>
/// Block type for criterion in AwsMacie2FindingsFilterFindingCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsMacie2FindingsFilterFindingCriteriaBlockCriterionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "criterion";

    /// <summary>
    /// The eq attribute.
    /// </summary>
    public TerraformSet<string>? Eq
    {
        get => GetArgument<TerraformSet<string>>("eq");
        set => SetArgument("eq", value);
    }

    /// <summary>
    /// The eq_exact_match attribute.
    /// </summary>
    public TerraformSet<string>? EqExactMatch
    {
        get => GetArgument<TerraformSet<string>>("eq_exact_match");
        set => SetArgument("eq_exact_match", value);
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
    /// The gt attribute.
    /// </summary>
    public TerraformValue<string>? Gt
    {
        get => GetArgument<TerraformValue<string>>("gt");
        set => SetArgument("gt", value);
    }

    /// <summary>
    /// The gte attribute.
    /// </summary>
    public TerraformValue<string>? Gte
    {
        get => GetArgument<TerraformValue<string>>("gte");
        set => SetArgument("gte", value);
    }

    /// <summary>
    /// The lt attribute.
    /// </summary>
    public TerraformValue<string>? Lt
    {
        get => GetArgument<TerraformValue<string>>("lt");
        set => SetArgument("lt", value);
    }

    /// <summary>
    /// The lte attribute.
    /// </summary>
    public TerraformValue<string>? Lte
    {
        get => GetArgument<TerraformValue<string>>("lte");
        set => SetArgument("lte", value);
    }

    /// <summary>
    /// The neq attribute.
    /// </summary>
    public TerraformSet<string>? Neq
    {
        get => GetArgument<TerraformSet<string>>("neq");
        set => SetArgument("neq", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsMacie2FindingsFilter.
/// Nesting mode: single
/// </summary>
public class AwsMacie2FindingsFilterTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_macie2_findings_filter Terraform resource.
/// Manages a aws_macie2_findings_filter resource.
/// </summary>
public partial class AwsMacie2FindingsFilter(string name) : TerraformResource("aws_macie2_findings_filter", name)
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
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? AsReference("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    public TerraformValue<double> Position
    {
        get => GetArgument<TerraformValue<double>>("position") ?? AsReference("position");
        set => SetArgument("position", value);
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
    public required TerraformList<AwsMacie2FindingsFilterFindingCriteriaBlock> FindingCriteria
    {
        get => GetRequiredArgument<TerraformList<AwsMacie2FindingsFilterFindingCriteriaBlock>>("finding_criteria");
        set => SetArgument("finding_criteria", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMacie2FindingsFilterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMacie2FindingsFilterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
