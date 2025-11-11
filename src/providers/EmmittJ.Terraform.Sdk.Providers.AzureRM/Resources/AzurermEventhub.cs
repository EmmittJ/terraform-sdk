using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for capture_description in .
/// Nesting mode: list
/// </summary>
public class AzurermEventhubCaptureDescriptionBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encoding is required")]
    [TerraformPropertyName("encoding")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Encoding { get; set; }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("interval_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? IntervalInSeconds { get; set; }

    /// <summary>
    /// The size_limit_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("size_limit_in_bytes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SizeLimitInBytes { get; set; }

    /// <summary>
    /// The skip_empty_archives attribute.
    /// </summary>
    [TerraformPropertyName("skip_empty_archives")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SkipEmptyArchives { get; set; }

}

/// <summary>
/// Block type for retention_description in .
/// Nesting mode: list
/// </summary>
public class AzurermEventhubRetentionDescriptionBlock
{
    /// <summary>
    /// The cleanup_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CleanupPolicy is required")]
    [TerraformPropertyName("cleanup_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CleanupPolicy { get; set; }

    /// <summary>
    /// The retention_time_in_hours attribute.
    /// </summary>
    [TerraformPropertyName("retention_time_in_hours")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetentionTimeInHours { get; set; }

    /// <summary>
    /// The tombstone_retention_time_in_hours attribute.
    /// </summary>
    [TerraformPropertyName("tombstone_retention_time_in_hours")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TombstoneRetentionTimeInHours { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventhubTimeoutsBlock
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
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_eventhub resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermEventhub : TerraformResource
{
    public AzurermEventhub(string name) : base("azurerm_eventhub", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The message_retention attribute.
    /// </summary>
    [TerraformPropertyName("message_retention")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MessageRetention { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformPropertyName("namespace_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamespaceId { get; set; } = default!;

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("namespace_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamespaceName { get; set; } = default!;

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionCount is required")]
    [TerraformPropertyName("partition_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> PartitionCount { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("resource_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ResourceGroupName { get; set; } = default!;

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// Block for capture_description.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CaptureDescription block(s) allowed")]
    [TerraformPropertyName("capture_description")]
    public TerraformList<TerraformBlock<AzurermEventhubCaptureDescriptionBlock>>? CaptureDescription { get; set; }

    /// <summary>
    /// Block for retention_description.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDescription block(s) allowed")]
    [TerraformPropertyName("retention_description")]
    public TerraformList<TerraformBlock<AzurermEventhubRetentionDescriptionBlock>>? RetentionDescription { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermEventhubTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The partition_ids attribute.
    /// </summary>
    [TerraformPropertyName("partition_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> PartitionIds => new TerraformReference(this, "partition_ids");

}
