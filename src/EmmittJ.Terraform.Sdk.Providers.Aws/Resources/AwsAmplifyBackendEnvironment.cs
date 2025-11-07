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
    public TerraformLiteralProperty<string>? AppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_id");
        set => this.WithProperty("app_id", value);
    }

    /// <summary>
    /// The deployment_artifacts attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeploymentArtifacts
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_artifacts");
        set => this.WithProperty("deployment_artifacts", value);
    }

    /// <summary>
    /// The environment_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EnvironmentName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment_name");
        set => this.WithProperty("environment_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The stack_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StackName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stack_name");
        set => this.WithProperty("stack_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
