using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for capture_description in .
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
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encoding is required")]
    public required TerraformValue<string> Encoding
    {
        get => new TerraformReference<string>(this, "encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? IntervalInSeconds
    {
        get => new TerraformReference<double>(this, "interval_in_seconds");
        set => SetArgument("interval_in_seconds", value);
    }

    /// <summary>
    /// The size_limit_in_bytes attribute.
    /// </summary>
    public TerraformValue<double>? SizeLimitInBytes
    {
        get => new TerraformReference<double>(this, "size_limit_in_bytes");
        set => SetArgument("size_limit_in_bytes", value);
    }

    /// <summary>
    /// The skip_empty_archives attribute.
    /// </summary>
    public TerraformValue<bool>? SkipEmptyArchives
    {
        get => new TerraformReference<bool>(this, "skip_empty_archives");
        set => SetArgument("skip_empty_archives", value);
    }

}

/// <summary>
/// Block type for retention_description in .
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
        get => new TerraformReference<string>(this, "cleanup_policy");
        set => SetArgument("cleanup_policy", value);
    }

    /// <summary>
    /// The retention_time_in_hours attribute.
    /// </summary>
    public TerraformValue<double>? RetentionTimeInHours
    {
        get => new TerraformReference<double>(this, "retention_time_in_hours");
        set => SetArgument("retention_time_in_hours", value);
    }

    /// <summary>
    /// The tombstone_retention_time_in_hours attribute.
    /// </summary>
    public TerraformValue<double>? TombstoneRetentionTimeInHours
    {
        get => new TerraformReference<double>(this, "tombstone_retention_time_in_hours");
        set => SetArgument("tombstone_retention_time_in_hours", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The message_retention attribute.
    /// </summary>
    public TerraformValue<double> MessageRetention
    {
        get => new TerraformReference<double>(this, "message_retention");
        set => SetArgument("message_retention", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformValue<string> NamespaceId
    {
        get => new TerraformReference<string>(this, "namespace_id");
        set => SetArgument("namespace_id", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionCount is required")]
    public required TerraformValue<double> PartitionCount
    {
        get => new TerraformReference<double>(this, "partition_count");
        set => SetArgument("partition_count", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

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
