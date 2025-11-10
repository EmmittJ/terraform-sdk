using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_images.
/// </summary>
public class AwsEcrImagesDataSource : TerraformDataSource
{
    public AwsEcrImagesDataSource(string name) : base("aws_ecr_images", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// ID of the registry (AWS account ID)
    /// </summary>
    [TerraformPropertyName("registry_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RegistryId { get; set; }

    /// <summary>
    /// Name of the repository
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformPropertyName("repository_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RepositoryName { get; set; }

    /// <summary>
    /// The image_ids attribute.
    /// </summary>
    [TerraformPropertyName("image_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ImageIds => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "image_ids");

}
