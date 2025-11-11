using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_studio_lifecycle_config resource.
/// </summary>
public partial class AwsSagemakerStudioLifecycleConfig : TerraformResource
{
    public AwsSagemakerStudioLifecycleConfig(string name) : base("aws_sagemaker_studio_lifecycle_config", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The studio_lifecycle_config_app_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StudioLifecycleConfigAppType is required")]
    [TerraformProperty("studio_lifecycle_config_app_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StudioLifecycleConfigAppType { get; set; }

    /// <summary>
    /// The studio_lifecycle_config_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StudioLifecycleConfigContent is required")]
    [TerraformProperty("studio_lifecycle_config_content")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StudioLifecycleConfigContent { get; set; }

    /// <summary>
    /// The studio_lifecycle_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StudioLifecycleConfigName is required")]
    [TerraformProperty("studio_lifecycle_config_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StudioLifecycleConfigName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
