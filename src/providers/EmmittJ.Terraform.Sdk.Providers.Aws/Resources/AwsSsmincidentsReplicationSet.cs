using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for region in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsSsmincidentsReplicationSetRegionBlock
{
    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }



}

/// <summary>
/// Block type for regions in .
/// Nesting mode: set
/// </summary>
public class AwsSsmincidentsReplicationSetRegionsBlock
{
    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }



}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSsmincidentsReplicationSetTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_ssmincidents_replication_set resource.
/// </summary>
public class AwsSsmincidentsReplicationSet : TerraformResource
{
    public AwsSsmincidentsReplicationSet(string name) : base("aws_ssmincidents_replication_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// Block for region.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("region")]
    public TerraformSet<TerraformBlock<AwsSsmincidentsReplicationSetRegionBlock>>? Region { get; set; }

    /// <summary>
    /// Block for regions.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("regions")]
    public TerraformSet<TerraformBlock<AwsSsmincidentsReplicationSetRegionsBlock>>? Regions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsSsmincidentsReplicationSetTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformPropertyName("created_by")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedBy => new TerraformReference(this, "created_by");

    /// <summary>
    /// The deletion_protected attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protected")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeletionProtected => new TerraformReference(this, "deletion_protected");

    /// <summary>
    /// The last_modified_by attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_by")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifiedBy => new TerraformReference(this, "last_modified_by");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
