using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for association_config in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclAssociationConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for captcha_config in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclCaptchaConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for challenge_config in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclChallengeConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for custom_response_body in .
/// Nesting mode: set
/// </summary>
public class AwsWafv2WebAclCustomResponseBodyBlock : TerraformBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformProperty<string> Content
    {
        get => GetProperty<TerraformProperty<string>>("content");
        set => WithProperty("content", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentType is required")]
    public required TerraformProperty<string> ContentType
    {
        get => GetProperty<TerraformProperty<string>>("content_type");
        set => WithProperty("content_type", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

}

/// <summary>
/// Block type for data_protection_config in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclDataProtectionConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for default_action in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclDefaultActionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for rule in .
/// Nesting mode: set
/// </summary>
public class AwsWafv2WebAclRuleBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

}

/// <summary>
/// Block type for visibility_config in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclVisibilityConfigBlock : TerraformBlock
{
    /// <summary>
    /// The cloudwatch_metrics_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchMetricsEnabled is required")]
    public required TerraformProperty<bool> CloudwatchMetricsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cloudwatch_metrics_enabled");
        set => WithProperty("cloudwatch_metrics_enabled", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformProperty<string> MetricName
    {
        get => GetProperty<TerraformProperty<string>>("metric_name");
        set => WithProperty("metric_name", value);
    }

    /// <summary>
    /// The sampled_requests_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SampledRequestsEnabled is required")]
    public required TerraformProperty<bool> SampledRequestsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sampled_requests_enabled");
        set => WithProperty("sampled_requests_enabled", value);
    }

}

/// <summary>
/// Manages a aws_wafv2_web_acl resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsWafv2WebAcl : TerraformResource
{
    public AwsWafv2WebAcl(string name) : base("aws_wafv2_web_acl", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("application_integration_url");
        this.DeclareOutput("arn");
        this.DeclareOutput("capacity");
        this.DeclareOutput("lock_token");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rule_json attribute.
    /// </summary>
    public TerraformProperty<string>? RuleJson
    {
        get => GetProperty<TerraformProperty<string>>("rule_json");
        set => this.WithProperty("rule_json", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The token_domains attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? TokenDomains
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("token_domains");
        set => this.WithProperty("token_domains", value);
    }

    /// <summary>
    /// Block for association_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssociationConfig block(s) allowed")]
    public List<AwsWafv2WebAclAssociationConfigBlock>? AssociationConfig
    {
        get => GetProperty<List<AwsWafv2WebAclAssociationConfigBlock>>("association_config");
        set => this.WithProperty("association_config", value);
    }

    /// <summary>
    /// Block for captcha_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CaptchaConfig block(s) allowed")]
    public List<AwsWafv2WebAclCaptchaConfigBlock>? CaptchaConfig
    {
        get => GetProperty<List<AwsWafv2WebAclCaptchaConfigBlock>>("captcha_config");
        set => this.WithProperty("captcha_config", value);
    }

    /// <summary>
    /// Block for challenge_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ChallengeConfig block(s) allowed")]
    public List<AwsWafv2WebAclChallengeConfigBlock>? ChallengeConfig
    {
        get => GetProperty<List<AwsWafv2WebAclChallengeConfigBlock>>("challenge_config");
        set => this.WithProperty("challenge_config", value);
    }

    /// <summary>
    /// Block for custom_response_body.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafv2WebAclCustomResponseBodyBlock>? CustomResponseBody
    {
        get => GetProperty<HashSet<AwsWafv2WebAclCustomResponseBodyBlock>>("custom_response_body");
        set => this.WithProperty("custom_response_body", value);
    }

    /// <summary>
    /// Block for data_protection_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionConfig block(s) allowed")]
    public List<AwsWafv2WebAclDataProtectionConfigBlock>? DataProtectionConfig
    {
        get => GetProperty<List<AwsWafv2WebAclDataProtectionConfigBlock>>("data_protection_config");
        set => this.WithProperty("data_protection_config", value);
    }

    /// <summary>
    /// Block for default_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAction block(s) allowed")]
    public List<AwsWafv2WebAclDefaultActionBlock>? DefaultAction
    {
        get => GetProperty<List<AwsWafv2WebAclDefaultActionBlock>>("default_action");
        set => this.WithProperty("default_action", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafv2WebAclRuleBlock>? Rule
    {
        get => GetProperty<HashSet<AwsWafv2WebAclRuleBlock>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// Block for visibility_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VisibilityConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VisibilityConfig block(s) allowed")]
    public List<AwsWafv2WebAclVisibilityConfigBlock>? VisibilityConfig
    {
        get => GetProperty<List<AwsWafv2WebAclVisibilityConfigBlock>>("visibility_config");
        set => this.WithProperty("visibility_config", value);
    }

    /// <summary>
    /// The application_integration_url attribute.
    /// </summary>
    public TerraformExpression ApplicationIntegrationUrl => this["application_integration_url"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformExpression Capacity => this["capacity"];

    /// <summary>
    /// The lock_token attribute.
    /// </summary>
    public TerraformExpression LockToken => this["lock_token"];

}
