using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachments_source in .
/// Nesting mode: list
/// </summary>
public class AwsSsmDocumentAttachmentsSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Manages a aws_ssm_document resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSsmDocument : TerraformResource
{
    public AwsSsmDocument(string name) : base("aws_ssm_document", name)
    {
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformPropertyName("content")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Content { get; set; }

    /// <summary>
    /// The document_format attribute.
    /// </summary>
    [TerraformPropertyName("document_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DocumentFormat { get; set; }

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DocumentType is required")]
    [TerraformPropertyName("document_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DocumentType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformPropertyName("permissions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Permissions { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

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
    /// The target_type attribute.
    /// </summary>
    [TerraformPropertyName("target_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetType { get; set; }

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    [TerraformPropertyName("version_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VersionName { get; set; }

    /// <summary>
    /// Block for attachments_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 AttachmentsSource block(s) allowed")]
    [TerraformPropertyName("attachments_source")]
    public TerraformList<TerraformBlock<AwsSsmDocumentAttachmentsSourceBlock>>? AttachmentsSource { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_date");

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    [TerraformPropertyName("default_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_version");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    [TerraformPropertyName("document_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DocumentVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "document_version");

    /// <summary>
    /// The hash attribute.
    /// </summary>
    [TerraformPropertyName("hash")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hash => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hash");

    /// <summary>
    /// The hash_type attribute.
    /// </summary>
    [TerraformPropertyName("hash_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HashType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hash_type");

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    [TerraformPropertyName("latest_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LatestVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "latest_version");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Owner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner");

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    [TerraformPropertyName("parameter")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Parameter => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "parameter");

    /// <summary>
    /// The platform_types attribute.
    /// </summary>
    [TerraformPropertyName("platform_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PlatformTypes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "platform_types");

    /// <summary>
    /// The schema_version attribute.
    /// </summary>
    [TerraformPropertyName("schema_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SchemaVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "schema_version");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
