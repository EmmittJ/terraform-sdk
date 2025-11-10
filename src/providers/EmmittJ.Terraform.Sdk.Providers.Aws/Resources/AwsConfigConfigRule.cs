using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for evaluation_mode in .
/// Nesting mode: set
/// </summary>
public class AwsConfigConfigRuleEvaluationModeBlock : ITerraformBlock
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Mode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "mode");

}

/// <summary>
/// Block type for scope in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigRuleScopeBlock : ITerraformBlock
{
    /// <summary>
    /// The compliance_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("compliance_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ComplianceResourceId { get; set; }

    /// <summary>
    /// The compliance_resource_types attribute.
    /// </summary>
    [TerraformPropertyName("compliance_resource_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ComplianceResourceTypes { get; set; }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    [TerraformPropertyName("tag_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TagKey { get; set; }

    /// <summary>
    /// The tag_value attribute.
    /// </summary>
    [TerraformPropertyName("tag_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TagValue { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigRuleSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    [TerraformPropertyName("owner")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Owner { get; set; }

    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    [TerraformPropertyName("source_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceIdentifier { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The input_parameters attribute.
    /// </summary>
    [TerraformPropertyName("input_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InputParameters { get; set; }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    [TerraformPropertyName("maximum_execution_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaximumExecutionFrequency { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for evaluation_mode.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("evaluation_mode")]
    public TerraformSet<TerraformBlock<AwsConfigConfigRuleEvaluationModeBlock>>? EvaluationMode { get; set; } = new();

    /// <summary>
    /// Block for scope.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scope block(s) allowed")]
    [TerraformPropertyName("scope")]
    public TerraformList<TerraformBlock<AwsConfigConfigRuleScopeBlock>>? Scope { get; set; } = new();

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformPropertyName("source")]
    public TerraformList<TerraformBlock<AwsConfigConfigRuleSourceBlock>>? Source { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The rule_id attribute.
    /// </summary>
    [TerraformPropertyName("rule_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RuleId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "rule_id");

}
