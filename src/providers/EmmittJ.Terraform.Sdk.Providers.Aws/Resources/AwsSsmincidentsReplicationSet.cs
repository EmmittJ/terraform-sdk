using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for region in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsSsmincidentsReplicationSetRegionBlock : TerraformBlockBase
{
    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }



}

/// <summary>
/// Block type for regions in .
/// Nesting mode: set
/// </summary>
public partial class AwsSsmincidentsReplicationSetRegionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }



}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsSsmincidentsReplicationSetTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_ssmincidents_replication_set resource.
/// </summary>
public partial class AwsSsmincidentsReplicationSet : TerraformResource
{
    public AwsSsmincidentsReplicationSet(string name) : base("aws_ssmincidents_replication_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

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
    /// Block for region.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("region")]
    public TerraformSet<TerraformBlock<AwsSsmincidentsReplicationSetRegionBlock>>? Region { get; set; }

    /// <summary>
    /// Block for regions.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("regions")]
    public TerraformSet<TerraformBlock<AwsSsmincidentsReplicationSetRegionsBlock>>? Regions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsSsmincidentsReplicationSetTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformProperty("created_by")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedBy { get; }

    /// <summary>
    /// The deletion_protected attribute.
    /// </summary>
    [TerraformProperty("deletion_protected")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DeletionProtected { get; }

    /// <summary>
    /// The last_modified_by attribute.
    /// </summary>
    [TerraformProperty("last_modified_by")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModifiedBy { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
