using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSnapshotDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_snapshot.
/// </summary>
public class AzurermSnapshotDataSource : TerraformDataSource
{
    public AzurermSnapshotDataSource(string name) : base("azurerm_snapshot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("creation_option");
        this.WithOutput("disk_size_gb");
        this.WithOutput("encryption_settings");
        this.WithOutput("os_type");
        this.WithOutput("source_resource_id");
        this.WithOutput("source_uri");
        this.WithOutput("storage_account_id");
        this.WithOutput("time_created");
        this.WithOutput("trusted_launch_enabled");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSnapshotDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSnapshotDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The creation_option attribute.
    /// </summary>
    public TerraformExpression CreationOption => this["creation_option"];

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformExpression DiskSizeGb => this["disk_size_gb"];

    /// <summary>
    /// The encryption_settings attribute.
    /// </summary>
    public TerraformExpression EncryptionSettings => this["encryption_settings"];

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformExpression OsType => this["os_type"];

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformExpression SourceResourceId => this["source_resource_id"];

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public TerraformExpression SourceUri => this["source_uri"];

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformExpression StorageAccountId => this["storage_account_id"];

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    public TerraformExpression TimeCreated => this["time_created"];

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformExpression TrustedLaunchEnabled => this["trusted_launch_enabled"];

}
