using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_action in .
/// Nesting mode: list
/// </summary>
public class AwsWafregionalWebAclDefaultActionBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for logging_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsWafregionalWebAclLoggingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogDestination is required")]
    public required TerraformProperty<string> LogDestination
    {
        get => GetRequiredProperty<TerraformProperty<string>>("log_destination");
        set => WithProperty("log_destination", value);
    }

}

/// <summary>
/// Block type for rule in .
/// Nesting mode: set
/// </summary>
public class AwsWafregionalWebAclRuleBlock : TerraformBlock
{
    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetRequiredProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

    /// <summary>
    /// The rule_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleId is required")]
    public required TerraformProperty<string> RuleId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("rule_id");
        set => WithProperty("rule_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Manages a aws_wafregional_web_acl resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsWafregionalWebAcl : TerraformResource
{
    public AwsWafregionalWebAcl(string name) : base("aws_wafregional_web_acl", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
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
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformProperty<string> MetricName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("metric_name");
        set => this.WithProperty("metric_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for default_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAction block(s) allowed")]
    public List<AwsWafregionalWebAclDefaultActionBlock>? DefaultAction
    {
        get => GetProperty<List<AwsWafregionalWebAclDefaultActionBlock>>("default_action");
        set => this.WithProperty("default_action", value);
    }

    /// <summary>
    /// Block for logging_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    public List<AwsWafregionalWebAclLoggingConfigurationBlock>? LoggingConfiguration
    {
        get => GetProperty<List<AwsWafregionalWebAclLoggingConfigurationBlock>>("logging_configuration");
        set => this.WithProperty("logging_configuration", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafregionalWebAclRuleBlock>? Rule
    {
        get => GetProperty<HashSet<AwsWafregionalWebAclRuleBlock>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
