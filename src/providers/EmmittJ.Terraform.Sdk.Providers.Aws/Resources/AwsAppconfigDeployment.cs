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
        SetOutput("arn");
        SetOutput("deployment_number");
        SetOutput("kms_key_arn");
        SetOutput("state");
        SetOutput("application_id");
        SetOutput("configuration_profile_id");
        SetOutput("configuration_version");
        SetOutput("deployment_strategy_id");
        SetOutput("description");
        SetOutput("environment_id");
        SetOutput("id");
        SetOutput("kms_key_identifier");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_id");
        set => SetProperty("application_id", value);
    }

    /// <summary>
    /// The configuration_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationProfileId is required")]
    public required TerraformProperty<string> ConfigurationProfileId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configuration_profile_id");
        set => SetProperty("configuration_profile_id", value);
    }

    /// <summary>
    /// The configuration_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationVersion is required")]
    public required TerraformProperty<string> ConfigurationVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configuration_version");
        set => SetProperty("configuration_version", value);
    }

    /// <summary>
    /// The deployment_strategy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentStrategyId is required")]
    public required TerraformProperty<string> DeploymentStrategyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deployment_strategy_id");
        set => SetProperty("deployment_strategy_id", value);
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
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    public required TerraformProperty<string> EnvironmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment_id");
        set => SetProperty("environment_id", value);
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
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_identifier");
        set => SetProperty("kms_key_identifier", value);
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
