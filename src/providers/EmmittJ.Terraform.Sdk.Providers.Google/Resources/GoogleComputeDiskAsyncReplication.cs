using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for secondary_disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeDiskAsyncReplicationSecondaryDiskBlock
{
    /// <summary>
    /// Secondary disk for asynchronous replication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    [TerraformPropertyName("disk")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Disk { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeDiskAsyncReplicationTimeoutsBlock
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

}

/// <summary>
/// Manages a google_compute_disk_async_replication resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeDiskAsyncReplication : TerraformResource
{
    public GoogleComputeDiskAsyncReplication(string name) : base("google_compute_disk_async_replication", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Primary disk for asynchronous replication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryDisk is required")]
    [TerraformPropertyName("primary_disk")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PrimaryDisk { get; set; }

    /// <summary>
    /// Block for secondary_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondaryDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SecondaryDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecondaryDisk block(s) allowed")]
    [TerraformPropertyName("secondary_disk")]
    public TerraformList<TerraformBlock<GoogleComputeDiskAsyncReplicationSecondaryDiskBlock>>? SecondaryDisk { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeDiskAsyncReplicationTimeoutsBlock>? Timeouts { get; set; }

}
