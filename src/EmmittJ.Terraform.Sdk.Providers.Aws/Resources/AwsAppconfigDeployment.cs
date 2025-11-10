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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// The configuration_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationProfileId is required")]
    public required TerraformProperty<string> ConfigurationProfileId
    {
        get => GetProperty<TerraformProperty<string>>("configuration_profile_id");
        set => this.WithProperty("configuration_profile_id", value);
    }

    /// <summary>
    /// The configuration_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationVersion is required")]
    public required TerraformProperty<string> ConfigurationVersion
    {
        get => GetProperty<TerraformProperty<string>>("configuration_version");
        set => this.WithProperty("configuration_version", value);
    }

    /// <summary>
    /// The deployment_strategy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentStrategyId is required")]
    public required TerraformProperty<string> DeploymentStrategyId
    {
        get => GetProperty<TerraformProperty<string>>("deployment_strategy_id");
        set => this.WithProperty("deployment_strategy_id", value);
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
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    public required TerraformProperty<string> EnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("environment_id");
        set => this.WithProperty("environment_id", value);
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
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_identifier");
        set => this.WithProperty("kms_key_identifier", value);
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
