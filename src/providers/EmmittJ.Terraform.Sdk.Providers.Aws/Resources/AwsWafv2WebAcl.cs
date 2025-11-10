using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for association_config in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclAssociationConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for captcha_config in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclCaptchaConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for challenge_config in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclChallengeConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for custom_response_body in .
/// Nesting mode: set
/// </summary>
public class AwsWafv2WebAclCustomResponseBodyBlock : ITerraformBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformPropertyName("content")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Content { get; set; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentType is required")]
    [TerraformPropertyName("content_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ContentType { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

}

/// <summary>
/// Block type for data_protection_config in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclDataProtectionConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for default_action in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclDefaultActionBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for rule in .
/// Nesting mode: set
/// </summary>
public class AwsWafv2WebAclRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Priority { get; set; }

}

/// <summary>
/// Block type for visibility_config in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclVisibilityConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The cloudwatch_metrics_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchMetricsEnabled is required")]
    [TerraformPropertyName("cloudwatch_metrics_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> CloudwatchMetricsEnabled { get; set; }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformPropertyName("metric_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MetricName { get; set; }

    /// <summary>
    /// The sampled_requests_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SampledRequestsEnabled is required")]
    [TerraformPropertyName("sampled_requests_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> SampledRequestsEnabled { get; set; }

}

/// <summary>
/// Manages a aws_wafv2_web_acl resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsWafv2WebAcl : TerraformResource
{
    public AwsWafv2WebAcl(string name) : base("aws_wafv2_web_acl", name)
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
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The rule_json attribute.
    /// </summary>
    [TerraformPropertyName("rule_json")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RuleJson { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformPropertyName("scope")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Scope { get; set; }

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
    /// The token_domains attribute.
    /// </summary>
    [TerraformPropertyName("token_domains")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? TokenDomains { get; set; }

    /// <summary>
    /// Block for association_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssociationConfig block(s) allowed")]
    [TerraformPropertyName("association_config")]
    public TerraformList<TerraformBlock<AwsWafv2WebAclAssociationConfigBlock>>? AssociationConfig { get; set; } = new();

    /// <summary>
    /// Block for captcha_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CaptchaConfig block(s) allowed")]
    [TerraformPropertyName("captcha_config")]
    public TerraformList<TerraformBlock<AwsWafv2WebAclCaptchaConfigBlock>>? CaptchaConfig { get; set; } = new();

    /// <summary>
    /// Block for challenge_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ChallengeConfig block(s) allowed")]
    [TerraformPropertyName("challenge_config")]
    public TerraformList<TerraformBlock<AwsWafv2WebAclChallengeConfigBlock>>? ChallengeConfig { get; set; } = new();

    /// <summary>
    /// Block for custom_response_body.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("custom_response_body")]
    public TerraformSet<TerraformBlock<AwsWafv2WebAclCustomResponseBodyBlock>>? CustomResponseBody { get; set; } = new();

    /// <summary>
    /// Block for data_protection_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionConfig block(s) allowed")]
    [TerraformPropertyName("data_protection_config")]
    public TerraformList<TerraformBlock<AwsWafv2WebAclDataProtectionConfigBlock>>? DataProtectionConfig { get; set; } = new();

    /// <summary>
    /// Block for default_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAction block(s) allowed")]
    [TerraformPropertyName("default_action")]
    public TerraformList<TerraformBlock<AwsWafv2WebAclDefaultActionBlock>>? DefaultAction { get; set; } = new();

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("rule")]
    public TerraformSet<TerraformBlock<AwsWafv2WebAclRuleBlock>>? Rule { get; set; } = new();

    /// <summary>
    /// Block for visibility_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VisibilityConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VisibilityConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VisibilityConfig block(s) allowed")]
    [TerraformPropertyName("visibility_config")]
    public TerraformList<TerraformBlock<AwsWafv2WebAclVisibilityConfigBlock>>? VisibilityConfig { get; set; } = new();

    /// <summary>
    /// The application_integration_url attribute.
    /// </summary>
    [TerraformPropertyName("application_integration_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApplicationIntegrationUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "application_integration_url");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformPropertyName("capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Capacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "capacity");

    /// <summary>
    /// The lock_token attribute.
    /// </summary>
    [TerraformPropertyName("lock_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LockToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lock_token");

}
