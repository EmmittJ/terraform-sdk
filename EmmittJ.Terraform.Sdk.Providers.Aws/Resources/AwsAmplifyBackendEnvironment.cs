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
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    public string? AppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_id")?.Value;
        set => this.WithProperty("app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deployment_artifacts attribute.
    /// </summary>
    public string? DeploymentArtifacts
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_artifacts")?.Value;
        set => this.WithProperty("deployment_artifacts", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The environment_name attribute.
    /// </summary>
    public string? EnvironmentName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment_name")?.Value;
        set => this.WithProperty("environment_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The stack_name attribute.
    /// </summary>
    public string? StackName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stack_name")?.Value;
        set => this.WithProperty("stack_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
