using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for association_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsWafv2WebAclAssociationConfigBlock() : TerraformBlock("association_config")
{
}

/// <summary>
/// Block type for captcha_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsWafv2WebAclCaptchaConfigBlock() : TerraformBlock("captcha_config")
{
}

/// <summary>
/// Block type for challenge_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsWafv2WebAclChallengeConfigBlock() : TerraformBlock("challenge_config")
{
}

/// <summary>
/// Block type for custom_response_body in .
/// Nesting mode: set
/// </summary>
public partial class AwsWafv2WebAclCustomResponseBodyBlock() : TerraformBlock("custom_response_body")
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformProperty("content")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Content { get; set; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentType is required")]
    [TerraformProperty("content_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContentType { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

}

/// <summary>
/// Block type for data_protection_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsWafv2WebAclDataProtectionConfigBlock() : TerraformBlock("data_protection_config")
{
}

/// <summary>
/// Block type for default_action in .
/// Nesting mode: list
/// </summary>
public partial class AwsWafv2WebAclDefaultActionBlock() : TerraformBlock("default_action")
{
}

/// <summary>
/// Block type for rule in .
/// Nesting mode: set
/// </summary>
public partial class AwsWafv2WebAclRuleBlock() : TerraformBlock("rule")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Priority { get; set; }

}

/// <summary>
/// Block type for visibility_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsWafv2WebAclVisibilityConfigBlock() : TerraformBlock("visibility_config")
{
    /// <summary>
    /// The cloudwatch_metrics_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchMetricsEnabled is required")]
    [TerraformProperty("cloudwatch_metrics_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> CloudwatchMetricsEnabled { get; set; }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformProperty("metric_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MetricName { get; set; }

    /// <summary>
    /// The sampled_requests_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SampledRequestsEnabled is required")]
    [TerraformProperty("sampled_requests_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> SampledRequestsEnabled { get; set; }

}

/// <summary>
/// Manages a aws_wafv2_web_acl resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsWafv2WebAcl : TerraformResource
{
    public AwsWafv2WebAcl(string name) : base("aws_wafv2_web_acl", name)
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
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rule_json attribute.
    /// </summary>
    [TerraformProperty("rule_json")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RuleJson { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Scope { get; set; }

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
    /// The token_domains attribute.
    /// </summary>
    [TerraformProperty("token_domains")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? TokenDomains { get; set; }

    /// <summary>
    /// Block for association_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssociationConfig block(s) allowed")]
    [TerraformProperty("association_config")]
    public TerraformList<AwsWafv2WebAclAssociationConfigBlock> AssociationConfig { get; set; } = new();

    /// <summary>
    /// Block for captcha_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CaptchaConfig block(s) allowed")]
    [TerraformProperty("captcha_config")]
    public TerraformList<AwsWafv2WebAclCaptchaConfigBlock> CaptchaConfig { get; set; } = new();

    /// <summary>
    /// Block for challenge_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ChallengeConfig block(s) allowed")]
    [TerraformProperty("challenge_config")]
    public TerraformList<AwsWafv2WebAclChallengeConfigBlock> ChallengeConfig { get; set; } = new();

    /// <summary>
    /// Block for custom_response_body.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("custom_response_body")]
    public TerraformSet<AwsWafv2WebAclCustomResponseBodyBlock> CustomResponseBody { get; set; } = new();

    /// <summary>
    /// Block for data_protection_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionConfig block(s) allowed")]
    [TerraformProperty("data_protection_config")]
    public TerraformList<AwsWafv2WebAclDataProtectionConfigBlock> DataProtectionConfig { get; set; } = new();

    /// <summary>
    /// Block for default_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAction block(s) allowed")]
    [TerraformProperty("default_action")]
    public required TerraformList<AwsWafv2WebAclDefaultActionBlock> DefaultAction { get; set; } = new();

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("rule")]
    public TerraformSet<AwsWafv2WebAclRuleBlock> Rule { get; set; } = new();

    /// <summary>
    /// Block for visibility_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VisibilityConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VisibilityConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VisibilityConfig block(s) allowed")]
    [TerraformProperty("visibility_config")]
    public required TerraformList<AwsWafv2WebAclVisibilityConfigBlock> VisibilityConfig { get; set; } = new();

    /// <summary>
    /// The application_integration_url attribute.
    /// </summary>
    [TerraformProperty("application_integration_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApplicationIntegrationUrl { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformProperty("capacity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Capacity { get; }

    /// <summary>
    /// The lock_token attribute.
    /// </summary>
    [TerraformProperty("lock_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LockToken { get; }

}
