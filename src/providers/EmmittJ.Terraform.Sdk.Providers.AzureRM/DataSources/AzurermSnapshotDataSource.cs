using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSnapshotDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_snapshot Terraform data source.
/// Retrieves information about a azurerm_snapshot.
/// </summary>
public partial class AzurermSnapshotDataSource(string name) : TerraformDataSource("azurerm_snapshot", name)
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
    /// The creation_option attribute.
    /// </summary>
    public TerraformValue<string> CreationOption
    {
        get => new TerraformReference<string>(this, "creation_option");
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
    /// The time_created attribute.
    /// </summary>
    public TerraformValue<string> TimeCreated
    {
        get => new TerraformReference<string>(this, "time_created");
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TrustedLaunchEnabled
    {
        get => new TerraformReference<bool>(this, "trusted_launch_enabled");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSnapshotDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSnapshotDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
