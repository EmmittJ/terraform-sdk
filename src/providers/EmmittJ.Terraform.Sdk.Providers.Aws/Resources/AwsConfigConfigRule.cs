using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for evaluation_mode in .
/// Nesting mode: set
/// </summary>
public class AwsConfigConfigRuleEvaluationModeBlock
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Mode { get; set; } = default!;

}

/// <summary>
/// Block type for scope in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigRuleScopeBlock
{
    /// <summary>
    /// The compliance_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("compliance_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ComplianceResourceId { get; set; }

    /// <summary>
    /// The compliance_resource_types attribute.
    /// </summary>
    [TerraformPropertyName("compliance_resource_types")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ComplianceResourceTypes { get; set; }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    [TerraformPropertyName("tag_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TagKey { get; set; }

    /// <summary>
    /// The tag_value attribute.
    /// </summary>
    [TerraformPropertyName("tag_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TagValue { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigRuleSourceBlock
{
    /// <summary>
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    [TerraformPropertyName("owner")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Owner { get; set; }

    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    [TerraformPropertyName("source_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceIdentifier { get; set; }

}

/// <summary>
/// Manages a aws_config_config_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConfigConfigRule : TerraformResource
{
    public AwsConfigConfigRule(string name) : base("aws_config_config_rule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The input_parameters attribute.
    /// </summary>
    [TerraformPropertyName("input_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InputParameters { get; set; }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    [TerraformPropertyName("maximum_execution_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaximumExecutionFrequency { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for evaluation_mode.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("evaluation_mode")]
    public TerraformSet<TerraformBlock<AwsConfigConfigRuleEvaluationModeBlock>>? EvaluationMode { get; set; }

    /// <summary>
    /// Block for scope.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scope block(s) allowed")]
    [TerraformPropertyName("scope")]
    public TerraformList<TerraformBlock<AwsConfigConfigRuleScopeBlock>>? Scope { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformPropertyName("source")]
    public TerraformList<TerraformBlock<AwsConfigConfigRuleSourceBlock>>? Source { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The rule_id attribute.
    /// </summary>
    [TerraformPropertyName("rule_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RuleId => new TerraformReference(this, "rule_id");

}
