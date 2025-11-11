using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_image_version resource.
/// </summary>
public class AwsSagemakerImageVersion : TerraformResource
{
    public AwsSagemakerImageVersion(string name) : base("aws_sagemaker_image_version", name)
    {
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    [TerraformPropertyName("aliases")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Aliases { get; set; }

    /// <summary>
    /// The base_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseImage is required")]
    [TerraformPropertyName("base_image")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BaseImage { get; set; }

    /// <summary>
    /// The horovod attribute.
    /// </summary>
    [TerraformPropertyName("horovod")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Horovod { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    [TerraformPropertyName("image_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ImageName { get; set; }

    /// <summary>
    /// The job_type attribute.
    /// </summary>
    [TerraformPropertyName("job_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? JobType { get; set; }

    /// <summary>
    /// The ml_framework attribute.
    /// </summary>
    [TerraformPropertyName("ml_framework")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MlFramework { get; set; }

    /// <summary>
    /// The processor attribute.
    /// </summary>
    [TerraformPropertyName("processor")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Processor { get; set; }

    /// <summary>
    /// The programming_lang attribute.
    /// </summary>
    [TerraformPropertyName("programming_lang")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProgrammingLang { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The release_notes attribute.
    /// </summary>
    [TerraformPropertyName("release_notes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReleaseNotes { get; set; }

    /// <summary>
    /// The vendor_guidance attribute.
    /// </summary>
    [TerraformPropertyName("vendor_guidance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VendorGuidance { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The container_image attribute.
    /// </summary>
    [TerraformPropertyName("container_image")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContainerImage => new TerraformReference(this, "container_image");

    /// <summary>
    /// The image_arn attribute.
    /// </summary>
    [TerraformPropertyName("image_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageArn => new TerraformReference(this, "image_arn");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Version => new TerraformReference(this, "version");

}
