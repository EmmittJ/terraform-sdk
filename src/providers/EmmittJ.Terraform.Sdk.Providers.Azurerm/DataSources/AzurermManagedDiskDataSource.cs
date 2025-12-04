using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermManagedDiskDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermManagedDiskDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_managed_disk Terraform data source.
/// Retrieves information about a azurerm_managed_disk.
/// </summary>
public partial class AzurermManagedDiskDataSource(string name) : TerraformDataSource("azurerm_managed_disk", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    public TerraformValue<string> CreateOption
        => AsReference("create_option");

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    public TerraformValue<string> DiskAccessId
        => AsReference("disk_access_id");

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string> DiskEncryptionSetId
        => AsReference("disk_encryption_set_id");

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    public TerraformValue<double> DiskIopsReadWrite
        => AsReference("disk_iops_read_write");

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    public TerraformValue<double> DiskMbpsReadWrite
        => AsReference("disk_mbps_read_write");

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
        => AsReference("disk_size_gb");

    /// <summary>
    /// The encryption_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionSettings
        => AsReference("encryption_settings");

    /// <summary>
    /// The image_reference_id attribute.
    /// </summary>
    public TerraformValue<string> ImageReferenceId
        => AsReference("image_reference_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The network_access_policy attribute.
    /// </summary>
    public TerraformValue<string> NetworkAccessPolicy
        => AsReference("network_access_policy");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string> OsType
        => AsReference("os_type");

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformValue<string> SourceResourceId
        => AsReference("source_resource_id");

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public TerraformValue<string> SourceUri
        => AsReference("source_uri");

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountId
        => AsReference("storage_account_id");

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountType
        => AsReference("storage_account_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
        => AsReference("zones");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagedDiskDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagedDiskDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
