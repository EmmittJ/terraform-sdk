using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_action in .
/// Nesting mode: list
/// </summary>
public class AwsWafWebAclDefaultActionBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for logging_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsWafWebAclLoggingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogDestination is required")]
    public required TerraformProperty<string> LogDestination
    {
        get => GetProperty<TerraformProperty<string>>("log_destination");
        set => WithProperty("log_destination", value);
    }

}

/// <summary>
/// Block type for rules in .
/// Nesting mode: set
/// </summary>
public class AwsWafWebAclRulesBlock : TerraformBlock
{
    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

    /// <summary>
    /// The rule_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleId is required")]
    public required TerraformProperty<string> RuleId
    {
        get => GetProperty<TerraformProperty<string>>("rule_id");
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
/// Manages a aws_waf_web_acl resource.
/// </summary>
public class AwsWafWebAcl : TerraformResource
{
    public AwsWafWebAcl(string name) : base("aws_waf_web_acl", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
        get => GetProperty<TerraformProperty<string>>("metric_name");
        set => this.WithProperty("metric_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    public List<AwsWafWebAclDefaultActionBlock>? DefaultAction
    {
        get => GetProperty<List<AwsWafWebAclDefaultActionBlock>>("default_action");
        set => this.WithProperty("default_action", value);
    }

    /// <summary>
    /// Block for logging_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    public List<AwsWafWebAclLoggingConfigurationBlock>? LoggingConfiguration
    {
        get => GetProperty<List<AwsWafWebAclLoggingConfigurationBlock>>("logging_configuration");
        set => this.WithProperty("logging_configuration", value);
    }

    /// <summary>
    /// Block for rules.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafWebAclRulesBlock>? Rules
    {
        get => GetProperty<HashSet<AwsWafWebAclRulesBlock>>("rules");
        set => this.WithProperty("rules", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
