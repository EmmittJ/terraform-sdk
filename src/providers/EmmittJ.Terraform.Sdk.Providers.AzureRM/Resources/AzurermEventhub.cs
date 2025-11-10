using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for capture_description in .
/// Nesting mode: list
/// </summary>
public class AzurermEventhubCaptureDescriptionBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encoding is required")]
    public required TerraformProperty<string> Encoding
    {
        get => GetRequiredProperty<TerraformProperty<string>>("encoding");
        set => WithProperty("encoding", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IntervalInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("interval_in_seconds");
        set => WithProperty("interval_in_seconds", value);
    }

    /// <summary>
    /// The size_limit_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? SizeLimitInBytes
    {
        get => GetProperty<TerraformProperty<double>>("size_limit_in_bytes");
        set => WithProperty("size_limit_in_bytes", value);
    }

    /// <summary>
    /// The skip_empty_archives attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipEmptyArchives
    {
        get => GetProperty<TerraformProperty<bool>>("skip_empty_archives");
        set => WithProperty("skip_empty_archives", value);
    }

}

/// <summary>
/// Block type for retention_description in .
/// Nesting mode: list
/// </summary>
public class AzurermEventhubRetentionDescriptionBlock : TerraformBlock
{
    /// <summary>
    /// The cleanup_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CleanupPolicy is required")]
    public required TerraformProperty<string> CleanupPolicy
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cleanup_policy");
        set => WithProperty("cleanup_policy", value);
    }

    /// <summary>
    /// The retention_time_in_hours attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionTimeInHours
    {
        get => GetProperty<TerraformProperty<double>>("retention_time_in_hours");
        set => WithProperty("retention_time_in_hours", value);
    }

    /// <summary>
    /// The tombstone_retention_time_in_hours attribute.
    /// </summary>
    public TerraformProperty<double>? TombstoneRetentionTimeInHours
    {
        get => GetProperty<TerraformProperty<double>>("tombstone_retention_time_in_hours");
        set => WithProperty("tombstone_retention_time_in_hours", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventhubTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("partition_ids");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The message_retention attribute.
    /// </summary>
    public TerraformProperty<double>? MessageRetention
    {
        get => GetProperty<TerraformProperty<double>>("message_retention");
        set => this.WithProperty("message_retention", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformProperty<string>? NamespaceId
    {
        get => GetProperty<TerraformProperty<string>>("namespace_id");
        set => this.WithProperty("namespace_id", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? NamespaceName
    {
        get => GetProperty<TerraformProperty<string>>("namespace_name");
        set => this.WithProperty("namespace_name", value);
    }

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionCount is required")]
    public required TerraformProperty<double> PartitionCount
    {
        get => GetRequiredProperty<TerraformProperty<double>>("partition_count");
        set => this.WithProperty("partition_count", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// Block for capture_description.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CaptureDescription block(s) allowed")]
    public List<AzurermEventhubCaptureDescriptionBlock>? CaptureDescription
    {
        get => GetProperty<List<AzurermEventhubCaptureDescriptionBlock>>("capture_description");
        set => this.WithProperty("capture_description", value);
    }

    /// <summary>
    /// Block for retention_description.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDescription block(s) allowed")]
    public List<AzurermEventhubRetentionDescriptionBlock>? RetentionDescription
    {
        get => GetProperty<List<AzurermEventhubRetentionDescriptionBlock>>("retention_description");
        set => this.WithProperty("retention_description", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermEventhubTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermEventhubTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The partition_ids attribute.
    /// </summary>
    public TerraformExpression PartitionIds => this["partition_ids"];

}
