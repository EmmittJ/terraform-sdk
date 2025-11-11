using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for capture_description in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventhubCaptureDescriptionBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encoding is required")]
    [TerraformProperty("encoding")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Encoding { get; set; }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [TerraformProperty("interval_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? IntervalInSeconds { get; set; }

    /// <summary>
    /// The size_limit_in_bytes attribute.
    /// </summary>
    [TerraformProperty("size_limit_in_bytes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SizeLimitInBytes { get; set; }

    /// <summary>
    /// The skip_empty_archives attribute.
    /// </summary>
    [TerraformProperty("skip_empty_archives")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipEmptyArchives { get; set; }

}

/// <summary>
/// Block type for retention_description in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventhubRetentionDescriptionBlock : TerraformBlockBase
{
    /// <summary>
    /// The cleanup_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CleanupPolicy is required")]
    [TerraformProperty("cleanup_policy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CleanupPolicy { get; set; }

    /// <summary>
    /// The retention_time_in_hours attribute.
    /// </summary>
    [TerraformProperty("retention_time_in_hours")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RetentionTimeInHours { get; set; }

    /// <summary>
    /// The tombstone_retention_time_in_hours attribute.
    /// </summary>
    [TerraformProperty("tombstone_retention_time_in_hours")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TombstoneRetentionTimeInHours { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermEventhubTimeoutsBlock : TerraformBlockBase
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
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_eventhub resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermEventhub : TerraformResource
{
    public AzurermEventhub(string name) : base("azurerm_eventhub", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The message_retention attribute.
    /// </summary>
    [TerraformProperty("message_retention")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MessageRetention { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformProperty("namespace_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NamespaceId { get; set; }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("namespace_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NamespaceName { get; set; }

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionCount is required")]
    [TerraformProperty("partition_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> PartitionCount { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("resource_group_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// Block for capture_description.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CaptureDescription block(s) allowed")]
    [TerraformProperty("capture_description")]
    public TerraformList<TerraformBlock<AzurermEventhubCaptureDescriptionBlock>>? CaptureDescription { get; set; }

    /// <summary>
    /// Block for retention_description.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDescription block(s) allowed")]
    [TerraformProperty("retention_description")]
    public TerraformList<TerraformBlock<AzurermEventhubRetentionDescriptionBlock>>? RetentionDescription { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermEventhubTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The partition_ids attribute.
    /// </summary>
    [TerraformProperty("partition_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> PartitionIds { get; }

}
