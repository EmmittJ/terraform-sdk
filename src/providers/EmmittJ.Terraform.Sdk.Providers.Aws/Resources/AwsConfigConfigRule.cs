using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for evaluation_mode in .
/// Nesting mode: set
/// </summary>
public partial class AwsConfigConfigRuleEvaluationModeBlock : TerraformBlockBase
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for scope in .
/// Nesting mode: list
/// </summary>
public partial class AwsConfigConfigRuleScopeBlock : TerraformBlockBase
{
    /// <summary>
    /// The compliance_resource_id attribute.
    /// </summary>
    [TerraformProperty("compliance_resource_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ComplianceResourceId { get; set; }

    /// <summary>
    /// The compliance_resource_types attribute.
    /// </summary>
    [TerraformProperty("compliance_resource_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ComplianceResourceTypes { get; set; }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    [TerraformProperty("tag_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TagKey { get; set; }

    /// <summary>
    /// The tag_value attribute.
    /// </summary>
    [TerraformProperty("tag_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TagValue { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class AwsConfigConfigRuleSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    [TerraformProperty("owner")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Owner { get; set; }

    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    [TerraformProperty("source_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceIdentifier { get; set; }

}

/// <summary>
/// Manages a aws_config_config_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsConfigConfigRule : TerraformResource
{
    public AwsConfigConfigRule(string name) : base("aws_config_config_rule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The input_parameters attribute.
    /// </summary>
    [TerraformProperty("input_parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InputParameters { get; set; }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    [TerraformProperty("maximum_execution_frequency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaximumExecutionFrequency { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for evaluation_mode.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("evaluation_mode")]
    public partial TerraformSet<TerraformBlock<AwsConfigConfigRuleEvaluationModeBlock>>? EvaluationMode { get; set; }

    /// <summary>
    /// Block for scope.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scope block(s) allowed")]
    [TerraformProperty("scope")]
    public partial TerraformList<TerraformBlock<AwsConfigConfigRuleScopeBlock>>? Scope { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformProperty("source")]
    public partial TerraformList<TerraformBlock<AwsConfigConfigRuleSourceBlock>>? Source { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The rule_id attribute.
    /// </summary>
    [TerraformProperty("rule_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RuleId { get; }

}
