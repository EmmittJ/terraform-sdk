using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_amplify_backend_environment resource.
/// </summary>
public partial class AwsAmplifyBackendEnvironment : TerraformResource
{
    public AwsAmplifyBackendEnvironment(string name) : base("aws_amplify_backend_environment", name)
    {
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformProperty("app_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppId { get; set; }

    /// <summary>
    /// The deployment_artifacts attribute.
    /// </summary>
    [TerraformProperty("deployment_artifacts")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DeploymentArtifacts { get; set; }

    /// <summary>
    /// The environment_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentName is required")]
    [TerraformProperty("environment_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EnvironmentName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The stack_name attribute.
    /// </summary>
    [TerraformProperty("stack_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StackName { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
