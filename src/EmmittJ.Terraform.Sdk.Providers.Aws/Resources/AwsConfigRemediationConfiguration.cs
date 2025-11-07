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
    public TerraformLiteralProperty<bool>? Automatic
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic");
        set => this.WithProperty("automatic", value);
    }

    /// <summary>
    /// The config_rule_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConfigRuleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("config_rule_name");
        set => this.WithProperty("config_rule_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The maximum_automatic_attempts attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaximumAutomaticAttempts
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_automatic_attempts");
        set => this.WithProperty("maximum_automatic_attempts", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_type");
        set => this.WithProperty("resource_type", value);
    }

    /// <summary>
    /// The retry_attempt_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RetryAttemptSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retry_attempt_seconds");
        set => this.WithProperty("retry_attempt_seconds", value);
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_id");
        set => this.WithProperty("target_id", value);
    }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_type");
        set => this.WithProperty("target_type", value);
    }

    /// <summary>
    /// The target_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_version");
        set => this.WithProperty("target_version", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
