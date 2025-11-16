using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    public TerraformValue<string> CreateOption
    {
        get => new TerraformReference<string>(this, "create_option");
    }

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    public TerraformValue<string> DiskAccessId
    {
        get => new TerraformReference<string>(this, "disk_access_id");
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string> DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
    }

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    public TerraformValue<double> DiskIopsReadWrite
    {
        get => new TerraformReference<double>(this, "disk_iops_read_write");
    }

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    public TerraformValue<double> DiskMbpsReadWrite
    {
        get => new TerraformReference<double>(this, "disk_mbps_read_write");
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
    }

    /// <summary>
    /// The encryption_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The image_reference_id attribute.
    /// </summary>
    public TerraformValue<string> ImageReferenceId
    {
        get => new TerraformReference<string>(this, "image_reference_id");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The network_access_policy attribute.
    /// </summary>
    public TerraformValue<string> NetworkAccessPolicy
    {
        get => new TerraformReference<string>(this, "network_access_policy");
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string> OsType
    {
        get => new TerraformReference<string>(this, "os_type");
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformValue<string> SourceResourceId
    {
        get => new TerraformReference<string>(this, "source_resource_id");
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public TerraformValue<string> SourceUri
    {
        get => new TerraformReference<string>(this, "source_uri");
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagedDiskDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagedDiskDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
