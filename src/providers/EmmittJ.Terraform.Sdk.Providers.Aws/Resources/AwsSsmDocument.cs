using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachments_source in .
/// Nesting mode: list
/// </summary>
public class AwsSsmDocumentAttachmentsSourceBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Values { get; set; }

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
    public required TerraformValue<string> Content { get; set; }

    /// <summary>
    /// The document_format attribute.
    /// </summary>
    [TerraformPropertyName("document_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DocumentFormat { get; set; }

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DocumentType is required")]
    [TerraformPropertyName("document_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DocumentType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformPropertyName("permissions")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Permissions { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    [TerraformPropertyName("target_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetType { get; set; }

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    [TerraformPropertyName("version_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VersionName { get; set; }

    /// <summary>
    /// Block for attachments_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 AttachmentsSource block(s) allowed")]
    [TerraformPropertyName("attachments_source")]
    public TerraformList<TerraformBlock<AwsSsmDocumentAttachmentsSourceBlock>>? AttachmentsSource { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedDate => new TerraformReference(this, "created_date");

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    [TerraformPropertyName("default_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultVersion => new TerraformReference(this, "default_version");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    [TerraformPropertyName("document_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DocumentVersion => new TerraformReference(this, "document_version");

    /// <summary>
    /// The hash attribute.
    /// </summary>
    [TerraformPropertyName("hash")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Hash => new TerraformReference(this, "hash");

    /// <summary>
    /// The hash_type attribute.
    /// </summary>
    [TerraformPropertyName("hash_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HashType => new TerraformReference(this, "hash_type");

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    [TerraformPropertyName("latest_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LatestVersion => new TerraformReference(this, "latest_version");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Owner => new TerraformReference(this, "owner");

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    [TerraformPropertyName("parameter")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Parameter => new TerraformReference(this, "parameter");

    /// <summary>
    /// The platform_types attribute.
    /// </summary>
    [TerraformPropertyName("platform_types")]
    // Output-only attribute - read-only reference
    public TerraformList<string> PlatformTypes => new TerraformReference(this, "platform_types");

    /// <summary>
    /// The schema_version attribute.
    /// </summary>
    [TerraformPropertyName("schema_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SchemaVersion => new TerraformReference(this, "schema_version");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
