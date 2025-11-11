using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachments_source in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmDocumentAttachmentsSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Manages a aws_ssm_document resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSsmDocument : TerraformResource
{
    public AwsSsmDocument(string name) : base("aws_ssm_document", name)
    {
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformProperty("content")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Content { get; set; }

    /// <summary>
    /// The document_format attribute.
    /// </summary>
    [TerraformProperty("document_format")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DocumentFormat { get; set; }

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DocumentType is required")]
    [TerraformProperty("document_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DocumentType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformProperty("permissions")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Permissions { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    [TerraformProperty("target_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetType { get; set; }

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    [TerraformProperty("version_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VersionName { get; set; }

    /// <summary>
    /// Block for attachments_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 AttachmentsSource block(s) allowed")]
    [TerraformProperty("attachments_source")]
    public TerraformList<TerraformBlock<AwsSsmDocumentAttachmentsSourceBlock>>? AttachmentsSource { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    [TerraformProperty("default_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DefaultVersion { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    [TerraformProperty("document_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DocumentVersion { get; }

    /// <summary>
    /// The hash attribute.
    /// </summary>
    [TerraformProperty("hash")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Hash { get; }

    /// <summary>
    /// The hash_type attribute.
    /// </summary>
    [TerraformProperty("hash_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HashType { get; }

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    [TerraformProperty("latest_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LatestVersion { get; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Owner { get; }

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    [TerraformProperty("parameter")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Parameter { get; }

    /// <summary>
    /// The platform_types attribute.
    /// </summary>
    [TerraformProperty("platform_types")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> PlatformTypes { get; }

    /// <summary>
    /// The schema_version attribute.
    /// </summary>
    [TerraformProperty("schema_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SchemaVersion { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
