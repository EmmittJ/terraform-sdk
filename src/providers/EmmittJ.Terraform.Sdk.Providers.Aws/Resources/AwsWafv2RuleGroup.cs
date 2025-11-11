using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for custom_response_body in .
/// Nesting mode: set
/// </summary>
public partial class AwsWafv2RuleGroupCustomResponseBodyBlock : TerraformBlockBase
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformProperty("content")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Content { get; set; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentType is required")]
    [TerraformProperty("content_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContentType { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Key { get; set; }

}

/// <summary>
/// Block type for rule in .
/// Nesting mode: set
/// </summary>
public partial class AwsWafv2RuleGroupRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Priority { get; set; }

}

/// <summary>
/// Block type for visibility_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsWafv2RuleGroupVisibilityConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The cloudwatch_metrics_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchMetricsEnabled is required")]
    [TerraformProperty("cloudwatch_metrics_enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> CloudwatchMetricsEnabled { get; set; }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformProperty("metric_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MetricName { get; set; }

    /// <summary>
    /// The sampled_requests_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SampledRequestsEnabled is required")]
    [TerraformProperty("sampled_requests_enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> SampledRequestsEnabled { get; set; }

}

/// <summary>
/// Manages a aws_wafv2_rule_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsWafv2RuleGroup : TerraformResource
{
    public AwsWafv2RuleGroup(string name) : base("aws_wafv2_rule_group", name)
    {
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformProperty("capacity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Capacity { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rules_json attribute.
    /// </summary>
    [TerraformProperty("rules_json")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RulesJson { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for custom_response_body.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("custom_response_body")]
    public TerraformSet<TerraformBlock<AwsWafv2RuleGroupCustomResponseBodyBlock>>? CustomResponseBody { get; set; }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("rule")]
    public TerraformSet<TerraformBlock<AwsWafv2RuleGroupRuleBlock>>? Rule { get; set; }

    /// <summary>
    /// Block for visibility_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VisibilityConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VisibilityConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VisibilityConfig block(s) allowed")]
    [TerraformProperty("visibility_config")]
    public TerraformList<TerraformBlock<AwsWafv2RuleGroupVisibilityConfigBlock>>? VisibilityConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The lock_token attribute.
    /// </summary>
    [TerraformProperty("lock_token")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LockToken { get; }

}
