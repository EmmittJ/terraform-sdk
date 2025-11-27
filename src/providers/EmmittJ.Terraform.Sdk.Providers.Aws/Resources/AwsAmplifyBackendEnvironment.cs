using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_amplify_backend_environment Terraform resource.
/// Manages a aws_amplify_backend_environment resource.
/// </summary>
public partial class AwsAmplifyBackendEnvironment(string name) : TerraformResource("aws_amplify_backend_environment", name)
{
    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The deployment_artifacts attribute.
    /// </summary>
    public TerraformValue<string> DeploymentArtifacts
    {
        get => new TerraformReference<string>(this, "deployment_artifacts");
        set => SetArgument("deployment_artifacts", value);
    }

    /// <summary>
    /// The environment_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentName is required")]
    public required TerraformValue<string> EnvironmentName
    {
        get => new TerraformReference<string>(this, "environment_name");
        set => SetArgument("environment_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The stack_name attribute.
    /// </summary>
    public TerraformValue<string> StackName
    {
        get => new TerraformReference<string>(this, "stack_name");
        set => SetArgument("stack_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
