using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for catalog_data in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcrpublicRepositoryCatalogDataBlock : TerraformBlockBase
{
    /// <summary>
    /// The about_text attribute.
    /// </summary>
    [TerraformProperty("about_text")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AboutText { get; set; }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    [TerraformProperty("architectures")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Architectures { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The logo_image_blob attribute.
    /// </summary>
    [TerraformProperty("logo_image_blob")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LogoImageBlob { get; set; }

    /// <summary>
    /// The operating_systems attribute.
    /// </summary>
    [TerraformProperty("operating_systems")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? OperatingSystems { get; set; }

    /// <summary>
    /// The usage_text attribute.
    /// </summary>
    [TerraformProperty("usage_text")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UsageText { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEcrpublicRepositoryTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_ecrpublic_repository resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEcrpublicRepository : TerraformResource
{
    public AwsEcrpublicRepository(string name) : base("aws_ecrpublic_repository", name)
    {
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

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
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RepositoryName { get; set; }

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
    /// Block for catalog_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogData block(s) allowed")]
    [TerraformProperty("catalog_data")]
    public partial TerraformList<TerraformBlock<AwsEcrpublicRepositoryCatalogDataBlock>>? CatalogData { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsEcrpublicRepositoryTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformProperty("registry_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RegistryId { get; }

    /// <summary>
    /// The repository_uri attribute.
    /// </summary>
    [TerraformProperty("repository_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RepositoryUri { get; }

}
