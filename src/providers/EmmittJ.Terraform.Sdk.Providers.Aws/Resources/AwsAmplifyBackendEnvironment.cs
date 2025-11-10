using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_amplify_backend_environment resource.
/// </summary>
public class AwsAmplifyBackendEnvironment : TerraformResource
{
    public AwsAmplifyBackendEnvironment(string name) : base("aws_amplify_backend_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("app_id");
        SetOutput("deployment_artifacts");
        SetOutput("environment_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("stack_name");
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformProperty<string> AppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_id");
        set => SetProperty("app_id", value);
    }

    /// <summary>
    /// The deployment_artifacts attribute.
    /// </summary>
    public TerraformProperty<string> DeploymentArtifacts
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deployment_artifacts");
        set => SetProperty("deployment_artifacts", value);
    }

    /// <summary>
    /// The environment_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentName is required")]
    public required TerraformProperty<string> EnvironmentName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment_name");
        set => SetProperty("environment_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The stack_name attribute.
    /// </summary>
    public TerraformProperty<string> StackName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stack_name");
        set => SetProperty("stack_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
