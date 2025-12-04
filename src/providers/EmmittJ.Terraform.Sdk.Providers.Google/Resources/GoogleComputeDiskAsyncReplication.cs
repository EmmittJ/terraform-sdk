using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for secondary_disk in GoogleComputeDiskAsyncReplication.
/// Nesting mode: list
/// </summary>
public class GoogleComputeDiskAsyncReplicationSecondaryDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secondary_disk";

    /// <summary>
    /// Secondary disk for asynchronous replication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    public required TerraformValue<string> Disk
    {
        get => GetArgument<TerraformValue<string>>("disk");
        set => SetArgument("disk", value);
    }

    /// <summary>
    /// Output-only. Status of replication on the secondary disk.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

}


/// <summary>
/// Block type for timeouts in GoogleComputeDiskAsyncReplication.
/// Nesting mode: single
/// </summary>
public class GoogleComputeDiskAsyncReplicationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_compute_disk_async_replication Terraform resource.
/// Manages a google_compute_disk_async_replication resource.
/// </summary>
public partial class GoogleComputeDiskAsyncReplication(string name) : TerraformResource("google_compute_disk_async_replication", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Primary disk for asynchronous replication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryDisk is required")]
    public required TerraformValue<string> PrimaryDisk
    {
        get => GetArgument<TerraformValue<string>>("primary_disk");
        set => SetArgument("primary_disk", value);
    }

    /// <summary>
    /// SecondaryDisk block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondaryDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SecondaryDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecondaryDisk block(s) allowed")]
    public required TerraformList<GoogleComputeDiskAsyncReplicationSecondaryDiskBlock> SecondaryDisk
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeDiskAsyncReplicationSecondaryDiskBlock>>("secondary_disk");
        set => SetArgument("secondary_disk", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeDiskAsyncReplicationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeDiskAsyncReplicationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
