using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsAccessanalyzerArchiveRuleFilterBlock() : TerraformBlock("filter")
{
    /// <summary>
    /// The contains attribute.
    /// </summary>
    [TerraformProperty("contains")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Contains { get; set; }

    /// <summary>
    /// The criteria attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [TerraformProperty("criteria")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Criteria { get; set; }

    /// <summary>
    /// The eq attribute.
    /// </summary>
    [TerraformProperty("eq")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Eq { get; set; }

    /// <summary>
    /// The exists attribute.
    /// </summary>
    [TerraformProperty("exists")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Exists { get; set; }

    /// <summary>
    /// The neq attribute.
    /// </summary>
    [TerraformProperty("neq")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Neq { get; set; }

}

/// <summary>
/// Manages a aws_accessanalyzer_archive_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAccessanalyzerArchiveRule : TerraformResource
{
    public AwsAccessanalyzerArchiveRule(string name) : base("aws_accessanalyzer_archive_rule", name)
    {
    }

    /// <summary>
    /// The analyzer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AnalyzerName is required")]
    [TerraformProperty("analyzer_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AnalyzerName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    [TerraformProperty("rule_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RuleName { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [TerraformProperty("filter")]
    public required TerraformSet<AwsAccessanalyzerArchiveRuleFilterBlock> Filter { get; set; } = new();

}
