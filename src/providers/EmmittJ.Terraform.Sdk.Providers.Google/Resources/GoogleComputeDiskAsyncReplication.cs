using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for secondary_disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeDiskAsyncReplicationSecondaryDiskBlock : TerraformBlock
{
    /// <summary>
    /// Secondary disk for asynchronous replication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    public required TerraformProperty<string> Disk
    {
        set => SetProperty("disk", value);
    }

    /// <summary>
    /// Output-only. Status of replication on the secondary disk.
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeDiskAsyncReplicationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_compute_disk_async_replication resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeDiskAsyncReplication : TerraformResource
{
    public GoogleComputeDiskAsyncReplication(string name) : base("google_compute_disk_async_replication", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("primary_disk");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Primary disk for asynchronous replication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryDisk is required")]
    public required TerraformProperty<string> PrimaryDisk
    {
        get => GetRequiredOutput<TerraformProperty<string>>("primary_disk");
        set => SetProperty("primary_disk", value);
    }

    /// <summary>
    /// Block for secondary_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondaryDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SecondaryDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecondaryDisk block(s) allowed")]
    public List<GoogleComputeDiskAsyncReplicationSecondaryDiskBlock>? SecondaryDisk
    {
        set => SetProperty("secondary_disk", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeDiskAsyncReplicationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
