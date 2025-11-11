using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_rds_global_cluster.
/// </summary>
public class AwsRdsGlobalClusterDataSource : TerraformDataSource
{
    public AwsRdsGlobalClusterDataSource(string name) : base("aws_rds_global_cluster", name)
    {
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformPropertyName("identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Identifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseName => new TerraformReference(this, "database_name");

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeletionProtection => new TerraformReference(this, "deletion_protection");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Engine => new TerraformReference(this, "engine");

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    [TerraformPropertyName("engine_lifecycle_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineLifecycleSupport => new TerraformReference(this, "engine_lifecycle_support");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineVersion => new TerraformReference(this, "engine_version");

    /// <summary>
    /// The members attribute.
    /// </summary>
    [TerraformPropertyName("members")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Members => new TerraformReference(this, "members");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceId => new TerraformReference(this, "resource_id");

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("storage_encrypted")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> StorageEncrypted => new TerraformReference(this, "storage_encrypted");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
