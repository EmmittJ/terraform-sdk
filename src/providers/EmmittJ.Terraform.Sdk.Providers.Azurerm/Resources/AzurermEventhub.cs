using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for capture_description in AzurermEventhub.
/// Nesting mode: list
/// </summary>
public class AzurermEventhubCaptureDescriptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capture_description";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encoding is required")]
    public required TerraformValue<string> Encoding
    {
        get => GetRequiredArgument<TerraformValue<string>>("encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? IntervalInSeconds
    {
        get => GetArgument<TerraformValue<double>>("interval_in_seconds");
        set => SetArgument("interval_in_seconds", value);
    }

    /// <summary>
    /// The size_limit_in_bytes attribute.
    /// </summary>
    public TerraformValue<double>? SizeLimitInBytes
    {
        get => GetArgument<TerraformValue<double>>("size_limit_in_bytes");
        set => SetArgument("size_limit_in_bytes", value);
    }

    /// <summary>
    /// The skip_empty_archives attribute.
    /// </summary>
    public TerraformValue<bool>? SkipEmptyArchives
    {
        get => GetArgument<TerraformValue<bool>>("skip_empty_archives");
        set => SetArgument("skip_empty_archives", value);
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AzurermEventhubCaptureDescriptionBlockDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AzurermEventhubCaptureDescriptionBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

}

/// <summary>
/// Block type for destination in AzurermEventhubCaptureDescriptionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventhubCaptureDescriptionBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The archive_name_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArchiveNameFormat is required")]
    public required TerraformValue<string> ArchiveNameFormat
    {
        get => GetRequiredArgument<TerraformValue<string>>("archive_name_format");
        set => SetArgument("archive_name_format", value);
    }

    /// <summary>
    /// The blob_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlobContainerName is required")]
    public required TerraformValue<string> BlobContainerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("blob_container_name");
        set => SetArgument("blob_container_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

}


/// <summary>
/// Block type for retention_description in AzurermEventhub.
/// Nesting mode: list
/// </summary>
public class AzurermEventhubRetentionDescriptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_description";

    /// <summary>
    /// The cleanup_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CleanupPolicy is required")]
    public required TerraformValue<string> CleanupPolicy
    {
        get => GetRequiredArgument<TerraformValue<string>>("cleanup_policy");
        set => SetArgument("cleanup_policy", value);
    }

    /// <summary>
    /// The retention_time_in_hours attribute.
    /// </summary>
    public TerraformValue<double>? RetentionTimeInHours
    {
        get => GetArgument<TerraformValue<double>>("retention_time_in_hours");
        set => SetArgument("retention_time_in_hours", value);
    }

    /// <summary>
    /// The tombstone_retention_time_in_hours attribute.
    /// </summary>
    public TerraformValue<double>? TombstoneRetentionTimeInHours
    {
        get => GetArgument<TerraformValue<double>>("tombstone_retention_time_in_hours");
        set => SetArgument("tombstone_retention_time_in_hours", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermEventhub.
/// Nesting mode: single
/// </summary>
public class AzurermEventhubTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_eventhub Terraform resource.
/// Manages a azurerm_eventhub resource.
/// </summary>
public partial class AzurermEventhub(string name) : TerraformResource("azurerm_eventhub", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The message_retention attribute.
    /// </summary>
    public TerraformValue<double> MessageRetention
    {
        get => GetArgument<TerraformValue<double>>("message_retention") ?? CreateReference("message_retention");
        set => SetArgument("message_retention", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformValue<string> NamespaceId
    {
        get => GetArgument<TerraformValue<string>>("namespace_id") ?? CreateReference("namespace_id");
        set => SetArgument("namespace_id", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> NamespaceName
    {
        get => GetArgument<TerraformValue<string>>("namespace_name") ?? CreateReference("namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionCount is required")]
    public required TerraformValue<double> PartitionCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("partition_count");
        set => SetArgument("partition_count", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name") ?? CreateReference("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The partition_ids attribute.
    /// </summary>
    public TerraformSet<string> PartitionIds
        => CreateReference("partition_ids");

    /// <summary>
    /// CaptureDescription block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CaptureDescription block(s) allowed")]
    public TerraformList<AzurermEventhubCaptureDescriptionBlock>? CaptureDescription
    {
        get => GetArgument<TerraformList<AzurermEventhubCaptureDescriptionBlock>>("capture_description");
        set => SetArgument("capture_description", value);
    }

    /// <summary>
    /// RetentionDescription block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDescription block(s) allowed")]
    public TerraformList<AzurermEventhubRetentionDescriptionBlock>? RetentionDescription
    {
        get => GetArgument<TerraformList<AzurermEventhubRetentionDescriptionBlock>>("retention_description");
        set => SetArgument("retention_description", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventhubTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventhubTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
