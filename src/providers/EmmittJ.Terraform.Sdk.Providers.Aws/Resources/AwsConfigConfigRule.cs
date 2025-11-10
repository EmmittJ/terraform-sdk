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
        set => SetProperty("mode", value);
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
        set => SetProperty("compliance_resource_id", value);
    }

    /// <summary>
    /// The compliance_resource_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ComplianceResourceTypes
    {
        set => SetProperty("compliance_resource_types", value);
    }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    public TerraformProperty<string>? TagKey
    {
        set => SetProperty("tag_key", value);
    }

    /// <summary>
    /// The tag_value attribute.
    /// </summary>
    public TerraformProperty<string>? TagValue
    {
        set => SetProperty("tag_value", value);
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
        set => SetProperty("owner", value);
    }

    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SourceIdentifier
    {
        set => SetProperty("source_identifier", value);
    }

}

/// <summary>
/// Manages a aws_config_config_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConfigConfigRule : TerraformResource
{
    public AwsConfigConfigRule(string name) : base("aws_config_config_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("rule_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("input_parameters");
        SetOutput("maximum_execution_frequency");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// The input_parameters attribute.
    /// </summary>
    public TerraformProperty<string> InputParameters
    {
        get => GetRequiredOutput<TerraformProperty<string>>("input_parameters");
        set => SetProperty("input_parameters", value);
    }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    public TerraformProperty<string> MaximumExecutionFrequency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maximum_execution_frequency");
        set => SetProperty("maximum_execution_frequency", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for evaluation_mode.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsConfigConfigRuleEvaluationModeBlock>? EvaluationMode
    {
        set => SetProperty("evaluation_mode", value);
    }

    /// <summary>
    /// Block for scope.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scope block(s) allowed")]
    public List<AwsConfigConfigRuleScopeBlock>? Scope
    {
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<AwsConfigConfigRuleSourceBlock>? Source
    {
        set => SetProperty("source", value);
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
