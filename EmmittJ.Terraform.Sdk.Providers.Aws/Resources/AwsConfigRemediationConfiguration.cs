using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_config_remediation_configuration resource.
/// </summary>
public class AwsConfigRemediationConfiguration : TerraformResource
{
    public AwsConfigRemediationConfiguration(string name) : base("aws_config_remediation_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The automatic attribute.
    /// </summary>
    public bool? Automatic
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic")?.Value;
        set => this.WithProperty("automatic", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The config_rule_name attribute.
    /// </summary>
    public string? ConfigRuleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("config_rule_name")?.Value;
        set => this.WithProperty("config_rule_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maximum_automatic_attempts attribute.
    /// </summary>
    public double? MaximumAutomaticAttempts
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_automatic_attempts")?.Value;
        set => this.WithProperty("maximum_automatic_attempts", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public string? ResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_type")?.Value;
        set => this.WithProperty("resource_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The retry_attempt_seconds attribute.
    /// </summary>
    public double? RetryAttemptSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retry_attempt_seconds")?.Value;
        set => this.WithProperty("retry_attempt_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    public string? TargetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_id")?.Value;
        set => this.WithProperty("target_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    public string? TargetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_type")?.Value;
        set => this.WithProperty("target_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_version attribute.
    /// </summary>
    public string? TargetVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_version")?.Value;
        set => this.WithProperty("target_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
