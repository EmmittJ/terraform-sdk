using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagedDiskDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_managed_disk.
/// </summary>
public class AzurermManagedDiskDataSource : TerraformDataSource
{
    public AzurermManagedDiskDataSource(string name) : base("azurerm_managed_disk", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_option");
        this.WithOutput("disk_access_id");
        this.WithOutput("disk_encryption_set_id");
        this.WithOutput("disk_iops_read_write");
        this.WithOutput("disk_mbps_read_write");
        this.WithOutput("disk_size_gb");
        this.WithOutput("encryption_settings");
        this.WithOutput("image_reference_id");
        this.WithOutput("location");
        this.WithOutput("network_access_policy");
        this.WithOutput("os_type");
        this.WithOutput("source_resource_id");
        this.WithOutput("source_uri");
        this.WithOutput("storage_account_id");
        this.WithOutput("storage_account_type");
        this.WithOutput("tags");
        this.WithOutput("zones");
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
    public AzurermManagedDiskDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermManagedDiskDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    public TerraformExpression CreateOption => this["create_option"];

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    public TerraformExpression DiskAccessId => this["disk_access_id"];

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformExpression DiskEncryptionSetId => this["disk_encryption_set_id"];

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    public TerraformExpression DiskIopsReadWrite => this["disk_iops_read_write"];

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    public TerraformExpression DiskMbpsReadWrite => this["disk_mbps_read_write"];

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformExpression DiskSizeGb => this["disk_size_gb"];

    /// <summary>
    /// The encryption_settings attribute.
    /// </summary>
    public TerraformExpression EncryptionSettings => this["encryption_settings"];

    /// <summary>
    /// The image_reference_id attribute.
    /// </summary>
    public TerraformExpression ImageReferenceId => this["image_reference_id"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The network_access_policy attribute.
    /// </summary>
    public TerraformExpression NetworkAccessPolicy => this["network_access_policy"];

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
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformExpression StorageAccountType => this["storage_account_type"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformExpression Zones => this["zones"];

}
