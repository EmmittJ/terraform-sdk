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
        set => SetProperty("content", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentType is required")]
    public required TerraformProperty<string> ContentType
    {
        set => SetProperty("content_type", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        set => SetProperty("key", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        set => SetProperty("priority", value);
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
        set => SetProperty("cloudwatch_metrics_enabled", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformProperty<string> MetricName
    {
        set => SetProperty("metric_name", value);
    }

    /// <summary>
    /// The sampled_requests_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SampledRequestsEnabled is required")]
    public required TerraformProperty<bool> SampledRequestsEnabled
    {
        set => SetProperty("sampled_requests_enabled", value);
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
        SetOutput("application_integration_url");
        SetOutput("arn");
        SetOutput("capacity");
        SetOutput("lock_token");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("region");
        SetOutput("rule_json");
        SetOutput("scope");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("token_domains");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The rule_json attribute.
    /// </summary>
    public TerraformProperty<string> RuleJson
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule_json");
        set => SetProperty("rule_json", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope");
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The token_domains attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> TokenDomains
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("token_domains");
        set => SetProperty("token_domains", value);
    }

    /// <summary>
    /// Block for association_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssociationConfig block(s) allowed")]
    public List<AwsWafv2WebAclAssociationConfigBlock>? AssociationConfig
    {
        set => SetProperty("association_config", value);
    }

    /// <summary>
    /// Block for captcha_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CaptchaConfig block(s) allowed")]
    public List<AwsWafv2WebAclCaptchaConfigBlock>? CaptchaConfig
    {
        set => SetProperty("captcha_config", value);
    }

    /// <summary>
    /// Block for challenge_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ChallengeConfig block(s) allowed")]
    public List<AwsWafv2WebAclChallengeConfigBlock>? ChallengeConfig
    {
        set => SetProperty("challenge_config", value);
    }

    /// <summary>
    /// Block for custom_response_body.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafv2WebAclCustomResponseBodyBlock>? CustomResponseBody
    {
        set => SetProperty("custom_response_body", value);
    }

    /// <summary>
    /// Block for data_protection_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionConfig block(s) allowed")]
    public List<AwsWafv2WebAclDataProtectionConfigBlock>? DataProtectionConfig
    {
        set => SetProperty("data_protection_config", value);
    }

    /// <summary>
    /// Block for default_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAction block(s) allowed")]
    public List<AwsWafv2WebAclDefaultActionBlock>? DefaultAction
    {
        set => SetProperty("default_action", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafv2WebAclRuleBlock>? Rule
    {
        set => SetProperty("rule", value);
    }

    /// <summary>
    /// Block for visibility_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VisibilityConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VisibilityConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VisibilityConfig block(s) allowed")]
    public List<AwsWafv2WebAclVisibilityConfigBlock>? VisibilityConfig
    {
        set => SetProperty("visibility_config", value);
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
