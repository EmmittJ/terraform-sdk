using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_image_version resource.
/// </summary>
public partial class AwsSagemakerImageVersion : TerraformResource
{
    public AwsSagemakerImageVersion(string name) : base("aws_sagemaker_image_version", name)
    {
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    [TerraformProperty("aliases")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Aliases { get; set; }

    /// <summary>
    /// The base_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseImage is required")]
    [TerraformProperty("base_image")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BaseImage { get; set; }

    /// <summary>
    /// The horovod attribute.
    /// </summary>
    [TerraformProperty("horovod")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Horovod { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    [TerraformProperty("image_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ImageName { get; set; }

    /// <summary>
    /// The job_type attribute.
    /// </summary>
    [TerraformProperty("job_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? JobType { get; set; }

    /// <summary>
    /// The ml_framework attribute.
    /// </summary>
    [TerraformProperty("ml_framework")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MlFramework { get; set; }

    /// <summary>
    /// The processor attribute.
    /// </summary>
    [TerraformProperty("processor")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Processor { get; set; }

    /// <summary>
    /// The programming_lang attribute.
    /// </summary>
    [TerraformProperty("programming_lang")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProgrammingLang { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The release_notes attribute.
    /// </summary>
    [TerraformProperty("release_notes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ReleaseNotes { get; set; }

    /// <summary>
    /// The vendor_guidance attribute.
    /// </summary>
    [TerraformProperty("vendor_guidance")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VendorGuidance { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The container_image attribute.
    /// </summary>
    [TerraformProperty("container_image")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContainerImage { get; }

    /// <summary>
    /// The image_arn attribute.
    /// </summary>
    [TerraformProperty("image_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImageArn { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Version { get; }

}
