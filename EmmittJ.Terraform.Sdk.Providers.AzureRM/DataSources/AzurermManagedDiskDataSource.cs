using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("create_option");
        this.DeclareOutput("disk_access_id");
        this.DeclareOutput("disk_encryption_set_id");
        this.DeclareOutput("disk_iops_read_write");
        this.DeclareOutput("disk_mbps_read_write");
        this.DeclareOutput("disk_size_gb");
        this.DeclareOutput("encryption_settings");
        this.DeclareOutput("image_reference_id");
        this.DeclareOutput("location");
        this.DeclareOutput("network_access_policy");
        this.DeclareOutput("os_type");
        this.DeclareOutput("source_resource_id");
        this.DeclareOutput("source_uri");
        this.DeclareOutput("storage_account_id");
        this.DeclareOutput("storage_account_type");
        this.DeclareOutput("tags");
        this.DeclareOutput("zones");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
