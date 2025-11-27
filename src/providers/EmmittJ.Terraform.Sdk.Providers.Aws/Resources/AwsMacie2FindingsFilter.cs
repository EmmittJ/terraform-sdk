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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "eq").ResolveNodes(ctx));
        set => SetArgument("eq", value);
    }

    /// <summary>
    /// The eq_exact_match attribute.
    /// </summary>
    public TerraformSet<string>? EqExactMatch
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "eq_exact_match").ResolveNodes(ctx));
        set => SetArgument("eq_exact_match", value);
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
    /// The gt attribute.
    /// </summary>
    public TerraformValue<string>? Gt
    {
        get => new TerraformReference<string>(this, "gt");
        set => SetArgument("gt", value);
    }

    /// <summary>
    /// The gte attribute.
    /// </summary>
    public TerraformValue<string>? Gte
    {
        get => new TerraformReference<string>(this, "gte");
        set => SetArgument("gte", value);
    }

    /// <summary>
    /// The lt attribute.
    /// </summary>
    public TerraformValue<string>? Lt
    {
        get => new TerraformReference<string>(this, "lt");
        set => SetArgument("lt", value);
    }

    /// <summary>
    /// The lte attribute.
    /// </summary>
    public TerraformValue<string>? Lte
    {
        get => new TerraformReference<string>(this, "lte");
        set => SetArgument("lte", value);
    }

    /// <summary>
    /// The neq attribute.
    /// </summary>
    public TerraformSet<string>? Neq
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "neq").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "create");
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
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    public TerraformValue<double> Position
    {
        get => new TerraformReference<double>(this, "position");
        set => SetArgument("position", value);
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
