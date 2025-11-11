using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sagemaker_prebuilt_ecr_image.
/// </summary>
public partial class AwsSagemakerPrebuiltEcrImageDataSource : TerraformDataSource
{
    public AwsSagemakerPrebuiltEcrImageDataSource(string name) : base("aws_sagemaker_prebuilt_ecr_image", name)
    {
    }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    [TerraformProperty("dns_suffix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DnsSuffix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_tag attribute.
    /// </summary>
    [TerraformProperty("image_tag")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageTag { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformProperty("registry_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RegistryId { get; }

    /// <summary>
    /// The registry_path attribute.
    /// </summary>
    [TerraformProperty("registry_path")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RegistryPath { get; }

}
