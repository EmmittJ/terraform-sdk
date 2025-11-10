using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for execution_controls in .
/// Nesting mode: list
/// </summary>
public class AwsConfigRemediationConfigurationExecutionControlsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for parameter in .
/// Nesting mode: list
/// </summary>
public class AwsConfigRemediationConfigurationParameterBlock : TerraformBlock
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
    /// The resource_value attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceValue
    {
        set => SetProperty("resource_value", value);
    }

    /// <summary>
    /// The static_value attribute.
    /// </summary>
    public TerraformProperty<string>? StaticValue
    {
        set => SetProperty("static_value", value);
    }

    /// <summary>
    /// The static_values attribute.
    /// </summary>
    public List<TerraformProperty<string>>? StaticValues
    {
        set => SetProperty("static_values", value);
    }

}

/// <summary>
/// Manages a aws_config_remediation_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConfigRemediationConfiguration : TerraformResource
{
    public AwsConfigRemediationConfiguration(string name) : base("aws_config_remediation_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("automatic");
        SetOutput("config_rule_name");
        SetOutput("id");
        SetOutput("maximum_automatic_attempts");
        SetOutput("region");
        SetOutput("resource_type");
        SetOutput("retry_attempt_seconds");
        SetOutput("target_id");
        SetOutput("target_type");
        SetOutput("target_version");
    }

    /// <summary>
    /// The automatic attribute.
    /// </summary>
    public TerraformProperty<bool> Automatic
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("automatic");
        set => SetProperty("automatic", value);
    }

    /// <summary>
    /// The config_rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigRuleName is required")]
    public required TerraformProperty<string> ConfigRuleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("config_rule_name");
        set => SetProperty("config_rule_name", value);
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
    /// The maximum_automatic_attempts attribute.
    /// </summary>
    public TerraformProperty<double> MaximumAutomaticAttempts
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_automatic_attempts");
        set => SetProperty("maximum_automatic_attempts", value);
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
    /// The resource_type attribute.
    /// </summary>
    public TerraformProperty<string> ResourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_type");
        set => SetProperty("resource_type", value);
    }

    /// <summary>
    /// The retry_attempt_seconds attribute.
    /// </summary>
    public TerraformProperty<double> RetryAttemptSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retry_attempt_seconds");
        set => SetProperty("retry_attempt_seconds", value);
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetId is required")]
    public required TerraformProperty<string> TargetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_id");
        set => SetProperty("target_id", value);
    }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetType is required")]
    public required TerraformProperty<string> TargetType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_type");
        set => SetProperty("target_type", value);
    }

    /// <summary>
    /// The target_version attribute.
    /// </summary>
    public TerraformProperty<string> TargetVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_version");
        set => SetProperty("target_version", value);
    }

    /// <summary>
    /// Block for execution_controls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionControls block(s) allowed")]
    public List<AwsConfigRemediationConfigurationExecutionControlsBlock>? ExecutionControls
    {
        set => SetProperty("execution_controls", value);
    }

    /// <summary>
    /// Block for parameter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 Parameter block(s) allowed")]
    public List<AwsConfigRemediationConfigurationParameterBlock>? Parameter
    {
        set => SetProperty("parameter", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
