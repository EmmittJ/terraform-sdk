using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appconfig_deployment resource.
/// </summary>
public class AwsAppconfigDeployment : TerraformResource
{
    public AwsAppconfigDeployment(string name) : base("aws_appconfig_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("deployment_number");
        this.DeclareOutput("kms_key_arn");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The configuration_profile_id attribute.
    /// </summary>
    public string? ConfigurationProfileId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_profile_id")?.Value;
        set => this.WithProperty("configuration_profile_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The configuration_version attribute.
    /// </summary>
    public string? ConfigurationVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_version")?.Value;
        set => this.WithProperty("configuration_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deployment_strategy_id attribute.
    /// </summary>
    public string? DeploymentStrategyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_strategy_id")?.Value;
        set => this.WithProperty("deployment_strategy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public string? EnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment_id")?.Value;
        set => this.WithProperty("environment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kms_key_identifier attribute.
    /// </summary>
    public string? KmsKeyIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_identifier")?.Value;
        set => this.WithProperty("kms_key_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The deployment_number attribute.
    /// </summary>
    public TerraformExpression DeploymentNumber => this["deployment_number"];

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformExpression KmsKeyArn => this["kms_key_arn"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
