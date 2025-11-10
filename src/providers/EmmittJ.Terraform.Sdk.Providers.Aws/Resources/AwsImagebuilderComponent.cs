using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_imagebuilder_component resource.
/// </summary>
public class AwsImagebuilderComponent : TerraformResource
{
    public AwsImagebuilderComponent(string name) : base("aws_imagebuilder_component", name)
    {
    }

    /// <summary>
    /// The change_description attribute.
    /// </summary>
    [TerraformPropertyName("change_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ChangeDescription { get; set; }

    /// <summary>
    /// The data attribute.
    /// </summary>
    [TerraformPropertyName("data")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Data { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Platform is required")]
    [TerraformPropertyName("platform")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Platform { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformPropertyName("skip_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipDestroy { get; set; }

    /// <summary>
    /// The supported_os_versions attribute.
    /// </summary>
    [TerraformPropertyName("supported_os_versions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SupportedOsVersions { get; set; }

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
    /// The uri attribute.
    /// </summary>
    [TerraformPropertyName("uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Uri { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformPropertyName("date_created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DateCreated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "date_created");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Encrypted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "encrypted");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Owner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
