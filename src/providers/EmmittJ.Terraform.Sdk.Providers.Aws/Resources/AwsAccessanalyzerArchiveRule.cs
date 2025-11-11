using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsAccessanalyzerArchiveRuleFilterBlock
{
    /// <summary>
    /// The contains attribute.
    /// </summary>
    [TerraformPropertyName("contains")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> Contains { get; set; } = default!;

    /// <summary>
    /// The criteria attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [TerraformPropertyName("criteria")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Criteria { get; set; }

    /// <summary>
    /// The eq attribute.
    /// </summary>
    [TerraformPropertyName("eq")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> Eq { get; set; } = default!;

    /// <summary>
    /// The exists attribute.
    /// </summary>
    [TerraformPropertyName("exists")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Exists { get; set; } = default!;

    /// <summary>
    /// The neq attribute.
    /// </summary>
    [TerraformPropertyName("neq")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> Neq { get; set; } = default!;

}

/// <summary>
/// Manages a aws_accessanalyzer_archive_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAccessanalyzerArchiveRule : TerraformResource
{
    public AwsAccessanalyzerArchiveRule(string name) : base("aws_accessanalyzer_archive_rule", name)
    {
    }

    /// <summary>
    /// The analyzer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AnalyzerName is required")]
    [TerraformPropertyName("analyzer_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AnalyzerName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    [TerraformPropertyName("rule_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RuleName { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsAccessanalyzerArchiveRuleFilterBlock>>? Filter { get; set; }

}
