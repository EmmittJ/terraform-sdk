using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMssqlManagedInstanceTransparentDataEncryption.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedInstanceTransparentDataEncryptionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mssql_managed_instance_transparent_data_encryption Terraform resource.
/// Manages a azurerm_mssql_managed_instance_transparent_data_encryption resource.
/// </summary>
public partial class AzurermMssqlManagedInstanceTransparentDataEncryption(string name) : TerraformResource("azurerm_mssql_managed_instance_transparent_data_encryption", name)
{
    /// <summary>
    /// The auto_rotation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoRotationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("auto_rotation_enabled");
        set => SetArgument("auto_rotation_enabled", value);
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
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedHsmKeyId
    {
        get => GetArgument<TerraformValue<string>>("managed_hsm_key_id");
        set => SetArgument("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    public required TerraformValue<string> ManagedInstanceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("managed_instance_id");
        set => SetArgument("managed_instance_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlManagedInstanceTransparentDataEncryptionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlManagedInstanceTransparentDataEncryptionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
