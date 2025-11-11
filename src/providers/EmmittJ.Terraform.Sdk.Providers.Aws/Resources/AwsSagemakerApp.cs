using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_spec in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerAppResourceSpecBlock : TerraformBlockBase
{
    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceType { get; set; }

    /// <summary>
    /// The lifecycle_config_arn attribute.
    /// </summary>
    [TerraformProperty("lifecycle_config_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LifecycleConfigArn { get; set; }

    /// <summary>
    /// The sagemaker_image_arn attribute.
    /// </summary>
    [TerraformProperty("sagemaker_image_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SagemakerImageArn { get; set; }

    /// <summary>
    /// The sagemaker_image_version_alias attribute.
    /// </summary>
    [TerraformProperty("sagemaker_image_version_alias")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SagemakerImageVersionAlias { get; set; }

    /// <summary>
    /// The sagemaker_image_version_arn attribute.
    /// </summary>
    [TerraformProperty("sagemaker_image_version_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SagemakerImageVersionArn { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerApp : TerraformResource
{
    public AwsSagemakerApp(string name) : base("aws_sagemaker_app", name)
    {
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppName is required")]
    [TerraformProperty("app_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppName { get; set; }

    /// <summary>
    /// The app_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppType is required")]
    [TerraformProperty("app_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppType { get; set; }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    [TerraformProperty("domain_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainId { get; set; }

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
    /// The space_name attribute.
    /// </summary>
    [TerraformProperty("space_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SpaceName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The user_profile_name attribute.
    /// </summary>
    [TerraformProperty("user_profile_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserProfileName { get; set; }

    /// <summary>
    /// Block for resource_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceSpec block(s) allowed")]
    [TerraformProperty("resource_spec")]
    public partial TerraformList<TerraformBlock<AwsSagemakerAppResourceSpecBlock>>? ResourceSpec { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
