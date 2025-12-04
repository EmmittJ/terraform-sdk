using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for encryption_settings in AzurermSnapshot.
/// Nesting mode: list
/// </summary>
public class AzurermSnapshotEncryptionSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_settings";

    /// <summary>
    /// DiskEncryptionKey block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskEncryptionKey is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DiskEncryptionKey block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskEncryptionKey block(s) allowed")]
    public required TerraformList<AzurermSnapshotEncryptionSettingsBlockDiskEncryptionKeyBlock> DiskEncryptionKey
    {
        get => GetRequiredArgument<TerraformList<AzurermSnapshotEncryptionSettingsBlockDiskEncryptionKeyBlock>>("disk_encryption_key");
        set => SetArgument("disk_encryption_key", value);
    }

    /// <summary>
    /// KeyEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyEncryptionKey block(s) allowed")]
    public TerraformList<AzurermSnapshotEncryptionSettingsBlockKeyEncryptionKeyBlock>? KeyEncryptionKey
    {
        get => GetArgument<TerraformList<AzurermSnapshotEncryptionSettingsBlockKeyEncryptionKeyBlock>>("key_encryption_key");
        set => SetArgument("key_encryption_key", value);
    }

}

/// <summary>
/// Block type for disk_encryption_key in AzurermSnapshotEncryptionSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSnapshotEncryptionSettingsBlockDiskEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_encryption_key";

    /// <summary>
    /// The secret_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretUrl is required")]
    public required TerraformValue<string> SecretUrl
    {
        get => GetArgument<TerraformValue<string>>("secret_url");
        set => SetArgument("secret_url", value);
    }

    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    public required TerraformValue<string> SourceVaultId
    {
        get => GetArgument<TerraformValue<string>>("source_vault_id");
        set => SetArgument("source_vault_id", value);
    }

}

/// <summary>
/// Block type for key_encryption_key in AzurermSnapshotEncryptionSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSnapshotEncryptionSettingsBlockKeyEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_encryption_key";

    /// <summary>
    /// The key_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyUrl is required")]
    public required TerraformValue<string> KeyUrl
    {
        get => GetArgument<TerraformValue<string>>("key_url");
        set => SetArgument("key_url", value);
    }

    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    public required TerraformValue<string> SourceVaultId
    {
        get => GetArgument<TerraformValue<string>>("source_vault_id");
        set => SetArgument("source_vault_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSnapshot.
/// Nesting mode: single
/// </summary>
public class AzurermSnapshotTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_snapshot Terraform resource.
/// Manages a azurerm_snapshot resource.
/// </summary>
public partial class AzurermSnapshot(string name) : TerraformResource("azurerm_snapshot", name)
{
    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    public required TerraformValue<string> CreateOption
    {
        get => GetArgument<TerraformValue<string>>("create_option");
        set => SetArgument("create_option", value);
    }

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    public TerraformValue<string>? DiskAccessId
    {
        get => GetArgument<TerraformValue<string>>("disk_access_id");
        set => SetArgument("disk_access_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double>? DiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The incremental_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IncrementalEnabled
    {
        get => GetArgument<TerraformValue<bool>>("incremental_enabled");
        set => SetArgument("incremental_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_access_policy attribute.
    /// </summary>
    public TerraformValue<string>? NetworkAccessPolicy
    {
        get => GetArgument<TerraformValue<string>>("network_access_policy");
        set => SetArgument("network_access_policy", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceResourceId
    {
        get => GetArgument<TerraformValue<string>>("source_resource_id");
        set => SetArgument("source_resource_id", value);
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public TerraformValue<string>? SourceUri
    {
        get => GetArgument<TerraformValue<string>>("source_uri");
        set => SetArgument("source_uri", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountId
    {
        get => GetArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TrustedLaunchEnabled
        => AsReference("trusted_launch_enabled");

    /// <summary>
    /// EncryptionSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSettings block(s) allowed")]
    public TerraformList<AzurermSnapshotEncryptionSettingsBlock>? EncryptionSettings
    {
        get => GetArgument<TerraformList<AzurermSnapshotEncryptionSettingsBlock>>("encryption_settings");
        set => SetArgument("encryption_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSnapshotTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSnapshotTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
