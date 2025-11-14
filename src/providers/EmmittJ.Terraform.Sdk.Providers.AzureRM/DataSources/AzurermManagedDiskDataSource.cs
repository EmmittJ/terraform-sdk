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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_managed_disk.
/// </summary>
public class AzurermManagedDiskDataSource : TerraformDataSource
{
    public AzurermManagedDiskDataSource(string name) : base("azurerm_managed_disk", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermManagedDiskDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [TerraformArgument("create_option")]
    public TerraformValue<string> CreateOption
    {
        get => new TerraformReference<string>(this, "create_option");
    }

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    [TerraformArgument("disk_access_id")]
    public TerraformValue<string> DiskAccessId
    {
        get => new TerraformReference<string>(this, "disk_access_id");
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformArgument("disk_encryption_set_id")]
    public TerraformValue<string> DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
    }

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    [TerraformArgument("disk_iops_read_write")]
    public TerraformValue<double> DiskIopsReadWrite
    {
        get => new TerraformReference<double>(this, "disk_iops_read_write");
    }

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    [TerraformArgument("disk_mbps_read_write")]
    public TerraformValue<double> DiskMbpsReadWrite
    {
        get => new TerraformReference<double>(this, "disk_mbps_read_write");
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformArgument("disk_size_gb")]
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
    }

    /// <summary>
    /// The encryption_settings attribute.
    /// </summary>
    [TerraformArgument("encryption_settings")]
    public TerraformList<object> EncryptionSettings
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "encryption_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The image_reference_id attribute.
    /// </summary>
    [TerraformArgument("image_reference_id")]
    public TerraformValue<string> ImageReferenceId
    {
        get => new TerraformReference<string>(this, "image_reference_id");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The network_access_policy attribute.
    /// </summary>
    [TerraformArgument("network_access_policy")]
    public TerraformValue<string> NetworkAccessPolicy
    {
        get => new TerraformReference<string>(this, "network_access_policy");
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformArgument("os_type")]
    public TerraformValue<string> OsType
    {
        get => new TerraformReference<string>(this, "os_type");
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformArgument("source_resource_id")]
    public TerraformValue<string> SourceResourceId
    {
        get => new TerraformReference<string>(this, "source_resource_id");
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    [TerraformArgument("source_uri")]
    public TerraformValue<string> SourceUri
    {
        get => new TerraformReference<string>(this, "source_uri");
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformArgument("storage_account_id")]
    public TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformArgument("storage_account_type")]
    public TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

}
