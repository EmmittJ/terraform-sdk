using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_images.
/// </summary>
public partial class AwsEcrImagesDataSource : TerraformDataSource
{
    public AwsEcrImagesDataSource(string name) : base("aws_ecr_images", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// ID of the registry (AWS account ID)
    /// </summary>
    [TerraformProperty("registry_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RegistryId { get; set; }

    /// <summary>
    /// Name of the repository
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// The image_ids attribute.
    /// </summary>
    [TerraformProperty("image_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ImageIds { get; }

}
