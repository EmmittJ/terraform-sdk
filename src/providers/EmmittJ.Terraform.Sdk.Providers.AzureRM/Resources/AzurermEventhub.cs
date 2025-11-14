using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encoding is required")]
    [TerraformArgument("encoding")]
    public required TerraformValue<string> Encoding
    {
        get => new TerraformReference<string>(this, "encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [TerraformArgument("interval_in_seconds")]
    public TerraformValue<double>? IntervalInSeconds
    {
        get => new TerraformReference<double>(this, "interval_in_seconds");
        set => SetArgument("interval_in_seconds", value);
    }

    /// <summary>
    /// The size_limit_in_bytes attribute.
    /// </summary>
    [TerraformArgument("size_limit_in_bytes")]
    public TerraformValue<double>? SizeLimitInBytes
    {
        get => new TerraformReference<double>(this, "size_limit_in_bytes");
        set => SetArgument("size_limit_in_bytes", value);
    }

    /// <summary>
    /// The skip_empty_archives attribute.
    /// </summary>
    [TerraformArgument("skip_empty_archives")]
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
    [TerraformArgument("cleanup_policy")]
    public required TerraformValue<string> CleanupPolicy
    {
        get => new TerraformReference<string>(this, "cleanup_policy");
        set => SetArgument("cleanup_policy", value);
    }

    /// <summary>
    /// The retention_time_in_hours attribute.
    /// </summary>
    [TerraformArgument("retention_time_in_hours")]
    public TerraformValue<double>? RetentionTimeInHours
    {
        get => new TerraformReference<double>(this, "retention_time_in_hours");
        set => SetArgument("retention_time_in_hours", value);
    }

    /// <summary>
    /// The tombstone_retention_time_in_hours attribute.
    /// </summary>
    [TerraformArgument("tombstone_retention_time_in_hours")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The message_retention attribute.
    /// </summary>
    [TerraformArgument("message_retention")]
    public TerraformValue<double> MessageRetention
    {
        get => new TerraformReference<double>(this, "message_retention");
        set => SetArgument("message_retention", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformArgument("namespace_id")]
    public TerraformValue<string> NamespaceId
    {
        get => new TerraformReference<string>(this, "namespace_id");
        set => SetArgument("namespace_id", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("namespace_name")]
    public TerraformValue<string> NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionCount is required")]
    [TerraformArgument("partition_count")]
    public required TerraformValue<double> PartitionCount
    {
        get => new TerraformReference<double>(this, "partition_count");
        set => SetArgument("partition_count", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("resource_group_name")]
    public TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformArgument("status")]
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// Block for capture_description.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CaptureDescription block(s) allowed")]
    [TerraformArgument("capture_description")]
    public TerraformList<AzurermEventhubCaptureDescriptionBlock> CaptureDescription { get; set; } = new();

    /// <summary>
    /// Block for retention_description.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDescription block(s) allowed")]
    [TerraformArgument("retention_description")]
    public TerraformList<AzurermEventhubRetentionDescriptionBlock> RetentionDescription { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermEventhubTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The partition_ids attribute.
    /// </summary>
    [TerraformArgument("partition_ids")]
    public TerraformSet<string> PartitionIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "partition_ids").ResolveNodes(ctx));
    }

}
