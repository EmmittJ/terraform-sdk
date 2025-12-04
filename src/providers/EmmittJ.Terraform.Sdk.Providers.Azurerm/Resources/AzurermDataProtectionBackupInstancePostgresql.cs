using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDataProtectionBackupInstancePostgresql.
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupInstancePostgresqlTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_data_protection_backup_instance_postgresql Terraform resource.
/// Manages a azurerm_data_protection_backup_instance_postgresql resource.
/// </summary>
public partial class AzurermDataProtectionBackupInstancePostgresql(string name) : TerraformResource("azurerm_data_protection_backup_instance_postgresql", name)
{
    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    public required TerraformValue<string> BackupPolicyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("backup_policy_id");
        set => SetArgument("backup_policy_id", value);
    }

    /// <summary>
    /// The database_credential_key_vault_secret_id attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseCredentialKeyVaultSecretId
    {
        get => GetArgument<TerraformValue<string>>("database_credential_key_vault_secret_id");
        set => SetArgument("database_credential_key_vault_secret_id", value);
    }

    /// <summary>
    /// The database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseId is required")]
    public required TerraformValue<string> DatabaseId
    {
        get => GetRequiredArgument<TerraformValue<string>>("database_id");
        set => SetArgument("database_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    public required TerraformValue<string> VaultId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vault_id");
        set => SetArgument("vault_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataProtectionBackupInstancePostgresqlTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataProtectionBackupInstancePostgresqlTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
