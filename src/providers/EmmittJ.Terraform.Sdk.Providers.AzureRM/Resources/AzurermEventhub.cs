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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encoding is required")]
    public required TerraformProperty<string> Encoding
    {
        set => SetProperty("encoding", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IntervalInSeconds
    {
        set => SetProperty("interval_in_seconds", value);
    }

    /// <summary>
    /// The size_limit_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? SizeLimitInBytes
    {
        set => SetProperty("size_limit_in_bytes", value);
    }

    /// <summary>
    /// The skip_empty_archives attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipEmptyArchives
    {
        set => SetProperty("skip_empty_archives", value);
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
        set => SetProperty("cleanup_policy", value);
    }

    /// <summary>
    /// The retention_time_in_hours attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionTimeInHours
    {
        set => SetProperty("retention_time_in_hours", value);
    }

    /// <summary>
    /// The tombstone_retention_time_in_hours attribute.
    /// </summary>
    public TerraformProperty<double>? TombstoneRetentionTimeInHours
    {
        set => SetProperty("tombstone_retention_time_in_hours", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("partition_ids");
        SetOutput("id");
        SetOutput("message_retention");
        SetOutput("name");
        SetOutput("namespace_id");
        SetOutput("namespace_name");
        SetOutput("partition_count");
        SetOutput("resource_group_name");
        SetOutput("status");
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
    /// The message_retention attribute.
    /// </summary>
    public TerraformProperty<double> MessageRetention
    {
        get => GetRequiredOutput<TerraformProperty<double>>("message_retention");
        set => SetProperty("message_retention", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformProperty<string> NamespaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace_id");
        set => SetProperty("namespace_id", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> NamespaceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace_name");
        set => SetProperty("namespace_name", value);
    }

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionCount is required")]
    public required TerraformProperty<double> PartitionCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("partition_count");
        set => SetProperty("partition_count", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
    }

    /// <summary>
    /// Block for capture_description.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CaptureDescription block(s) allowed")]
    public List<AzurermEventhubCaptureDescriptionBlock>? CaptureDescription
    {
        set => SetProperty("capture_description", value);
    }

    /// <summary>
    /// Block for retention_description.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDescription block(s) allowed")]
    public List<AzurermEventhubRetentionDescriptionBlock>? RetentionDescription
    {
        set => SetProperty("retention_description", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermEventhubTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The partition_ids attribute.
    /// </summary>
    public TerraformExpression PartitionIds => this["partition_ids"];

}
