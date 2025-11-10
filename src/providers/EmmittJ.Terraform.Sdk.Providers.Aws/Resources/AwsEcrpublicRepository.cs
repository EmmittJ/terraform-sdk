using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for catalog_data in .
/// Nesting mode: list
/// </summary>
public class AwsEcrpublicRepositoryCatalogDataBlock : ITerraformBlock
{
    /// <summary>
    /// The about_text attribute.
    /// </summary>
    [TerraformPropertyName("about_text")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AboutText { get; set; }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    [TerraformPropertyName("architectures")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Architectures { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The logo_image_blob attribute.
    /// </summary>
    [TerraformPropertyName("logo_image_blob")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LogoImageBlob { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "logo_image_blob");

    /// <summary>
    /// The operating_systems attribute.
    /// </summary>
    [TerraformPropertyName("operating_systems")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? OperatingSystems { get; set; }

    /// <summary>
    /// The usage_text attribute.
    /// </summary>
    [TerraformPropertyName("usage_text")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UsageText { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEcrpublicRepositoryTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_ecrpublic_repository resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcrpublicRepository : TerraformResource
{
    public AwsEcrpublicRepository(string name) : base("aws_ecrpublic_repository", name)
    {
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for catalog_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogData block(s) allowed")]
    [TerraformPropertyName("catalog_data")]
    public TerraformList<TerraformBlock<AwsEcrpublicRepositoryCatalogDataBlock>>? CatalogData { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEcrpublicRepositoryTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformPropertyName("registry_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegistryId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "registry_id");

    /// <summary>
    /// The repository_uri attribute.
    /// </summary>
    [TerraformPropertyName("repository_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RepositoryUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "repository_uri");

}
