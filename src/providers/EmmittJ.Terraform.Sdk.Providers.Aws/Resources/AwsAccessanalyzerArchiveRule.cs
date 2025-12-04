using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsAccessanalyzerArchiveRule.
/// Nesting mode: set
/// </summary>
public class AwsAccessanalyzerArchiveRuleFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The contains attribute.
    /// </summary>
    public TerraformList<string>? ContainsAttribute
    {
        get => GetArgument<TerraformList<string>>("contains");
        set => SetArgument("contains", value);
    }

    /// <summary>
    /// The criteria attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    public required TerraformValue<string> Criteria
    {
        get => GetArgument<TerraformValue<string>>("criteria");
        set => SetArgument("criteria", value);
    }

    /// <summary>
    /// The eq attribute.
    /// </summary>
    public TerraformList<string>? Eq
    {
        get => GetArgument<TerraformList<string>>("eq");
        set => SetArgument("eq", value);
    }

    /// <summary>
    /// The exists attribute.
    /// </summary>
    public TerraformValue<string>? Exists
    {
        get => GetArgument<TerraformValue<string>>("exists");
        set => SetArgument("exists", value);
    }

    /// <summary>
    /// The neq attribute.
    /// </summary>
    public TerraformList<string>? Neq
    {
        get => GetArgument<TerraformList<string>>("neq");
        set => SetArgument("neq", value);
    }

}


/// <summary>
/// Represents a aws_accessanalyzer_archive_rule Terraform resource.
/// Manages a aws_accessanalyzer_archive_rule resource.
/// </summary>
public partial class AwsAccessanalyzerArchiveRule(string name) : TerraformResource("aws_accessanalyzer_archive_rule", name)
{
    /// <summary>
    /// The analyzer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AnalyzerName is required")]
    public required TerraformValue<string> AnalyzerName
    {
        get => GetArgument<TerraformValue<string>>("analyzer_name");
        set => SetArgument("analyzer_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformValue<string> RuleName
    {
        get => GetArgument<TerraformValue<string>>("rule_name");
        set => SetArgument("rule_name", value);
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    public required TerraformSet<AwsAccessanalyzerArchiveRuleFilterBlock> Filter
    {
        get => GetRequiredArgument<TerraformSet<AwsAccessanalyzerArchiveRuleFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
