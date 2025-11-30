using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDataProtectionBackupInstancePostgresqlFlexibleServer.
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupInstancePostgresqlFlexibleServerTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_data_protection_backup_instance_postgresql_flexible_server Terraform resource.
/// Manages a azurerm_data_protection_backup_instance_postgresql_flexible_server resource.
/// </summary>
public partial class AzurermDataProtectionBackupInstancePostgresqlFlexibleServer(string name) : TerraformResource("azurerm_data_protection_backup_instance_postgresql_flexible_server", name)
{
    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    public required TerraformValue<string> BackupPolicyId
    {
        get => new TerraformReference<string>(this, "backup_policy_id");
        set => SetArgument("backup_policy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => new TerraformReference<string>(this, "server_id");
        set => SetArgument("server_id", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    public required TerraformValue<string> VaultId
    {
        get => new TerraformReference<string>(this, "vault_id");
        set => SetArgument("vault_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataProtectionBackupInstancePostgresqlFlexibleServerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataProtectionBackupInstancePostgresqlFlexibleServerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
