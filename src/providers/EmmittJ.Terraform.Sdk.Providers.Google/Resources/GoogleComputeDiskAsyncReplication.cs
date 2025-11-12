using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for secondary_disk in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeDiskAsyncReplicationSecondaryDiskBlock() : TerraformBlock("secondary_disk")
{
    /// <summary>
    /// Secondary disk for asynchronous replication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    [TerraformProperty("disk")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Disk { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeDiskAsyncReplicationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_compute_disk_async_replication resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeDiskAsyncReplication : TerraformResource
{
    public GoogleComputeDiskAsyncReplication(string name) : base("google_compute_disk_async_replication", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Primary disk for asynchronous replication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryDisk is required")]
    [TerraformProperty("primary_disk")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrimaryDisk { get; set; }

    /// <summary>
    /// Block for secondary_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondaryDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SecondaryDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecondaryDisk block(s) allowed")]
    [TerraformProperty("secondary_disk")]
    public required TerraformList<GoogleComputeDiskAsyncReplicationSecondaryDiskBlock> SecondaryDisk { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeDiskAsyncReplicationTimeoutsBlock Timeouts { get; set; } = new();

}
