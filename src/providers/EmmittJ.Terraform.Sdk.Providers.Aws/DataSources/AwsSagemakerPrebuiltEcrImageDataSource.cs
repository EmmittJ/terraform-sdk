using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sagemaker_prebuilt_ecr_image.
/// </summary>
public class AwsSagemakerPrebuiltEcrImageDataSource : TerraformDataSource
{
    public AwsSagemakerPrebuiltEcrImageDataSource(string name) : base("aws_sagemaker_prebuilt_ecr_image", name)
    {
    }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    [TerraformPropertyName("dns_suffix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DnsSuffix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The image_tag attribute.
    /// </summary>
    [TerraformPropertyName("image_tag")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ImageTag { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformPropertyName("repository_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RepositoryName { get; set; }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformPropertyName("registry_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegistryId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "registry_id");

    /// <summary>
    /// The registry_path attribute.
    /// </summary>
    [TerraformPropertyName("registry_path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegistryPath => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "registry_path");

}
