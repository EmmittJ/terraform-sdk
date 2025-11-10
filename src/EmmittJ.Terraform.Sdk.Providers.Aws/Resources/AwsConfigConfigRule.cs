using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for evaluation_mode in .
/// Nesting mode: set
/// </summary>
public class AwsConfigConfigRuleEvaluationModeBlock : TerraformBlock
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

}

/// <summary>
/// Block type for scope in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigRuleScopeBlock : TerraformBlock
{
    /// <summary>
    /// The compliance_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? ComplianceResourceId
    {
        get => GetProperty<TerraformProperty<string>>("compliance_resource_id");
        set => WithProperty("compliance_resource_id", value);
    }

    /// <summary>
    /// The compliance_resource_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ComplianceResourceTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("compliance_resource_types");
        set => WithProperty("compliance_resource_types", value);
    }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    public TerraformProperty<string>? TagKey
    {
        get => GetProperty<TerraformProperty<string>>("tag_key");
        set => WithProperty("tag_key", value);
    }

    /// <summary>
    /// The tag_value attribute.
    /// </summary>
    public TerraformProperty<string>? TagValue
    {
        get => GetProperty<TerraformProperty<string>>("tag_value");
        set => WithProperty("tag_value", value);
    }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigRuleSourceBlock : TerraformBlock
{
    /// <summary>
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    public required TerraformProperty<string> Owner
    {
        get => GetProperty<TerraformProperty<string>>("owner");
        set => WithProperty("owner", value);
    }

    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SourceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("source_identifier");
        set => WithProperty("source_identifier", value);
    }

}

/// <summary>
/// Manages a aws_config_config_rule resource.
/// </summary>
public class AwsConfigConfigRule : TerraformResource
{
    public AwsConfigConfigRule(string name) : base("aws_config_config_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("rule_id");
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
    /// The input_parameters attribute.
    /// </summary>
    public TerraformProperty<string>? InputParameters
    {
        get => GetProperty<TerraformProperty<string>>("input_parameters");
        set => this.WithProperty("input_parameters", value);
    }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    public TerraformProperty<string>? MaximumExecutionFrequency
    {
        get => GetProperty<TerraformProperty<string>>("maximum_execution_frequency");
        set => this.WithProperty("maximum_execution_frequency", value);
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
    /// Block for evaluation_mode.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsConfigConfigRuleEvaluationModeBlock>? EvaluationMode
    {
        get => GetProperty<HashSet<AwsConfigConfigRuleEvaluationModeBlock>>("evaluation_mode");
        set => this.WithProperty("evaluation_mode", value);
    }

    /// <summary>
    /// Block for scope.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scope block(s) allowed")]
    public List<AwsConfigConfigRuleScopeBlock>? Scope
    {
        get => GetProperty<List<AwsConfigConfigRuleScopeBlock>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<AwsConfigConfigRuleSourceBlock>? Source
    {
        get => GetProperty<List<AwsConfigConfigRuleSourceBlock>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The rule_id attribute.
    /// </summary>
    public TerraformExpression RuleId => this["rule_id"];

}
