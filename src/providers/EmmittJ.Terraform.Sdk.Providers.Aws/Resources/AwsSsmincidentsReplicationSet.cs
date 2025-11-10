using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for region in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsSsmincidentsReplicationSetRegionBlock : ITerraformBlock
{
    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>("", "status");

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    [TerraformPropertyName("status_message")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusMessage => new TerraformReferenceProperty<TerraformProperty<string>>("", "status_message");

}

/// <summary>
/// Block type for regions in .
/// Nesting mode: set
/// </summary>
public class AwsSsmincidentsReplicationSetRegionsBlock : ITerraformBlock
{
    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>("", "status");

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    [TerraformPropertyName("status_message")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusMessage => new TerraformReferenceProperty<TerraformProperty<string>>("", "status_message");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSsmincidentsReplicationSetTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// Block for region.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("region")]
    public TerraformSet<TerraformBlock<AwsSsmincidentsReplicationSetRegionBlock>>? Region { get; set; } = new();

    /// <summary>
    /// Block for regions.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("regions")]
    public TerraformSet<TerraformBlock<AwsSsmincidentsReplicationSetRegionsBlock>>? Regions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsSsmincidentsReplicationSetTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformPropertyName("created_by")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedBy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_by");

    /// <summary>
    /// The deletion_protected attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protected")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeletionProtected => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protected");

    /// <summary>
    /// The last_modified_by attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_by")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedBy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_by");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
