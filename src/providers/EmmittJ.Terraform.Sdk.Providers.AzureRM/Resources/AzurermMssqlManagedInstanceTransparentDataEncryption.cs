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
public class AzurermMssqlManagedInstanceTransparentDataEncryptionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mssql_managed_instance_transparent_data_encryption resource.
/// </summary>
public class AzurermMssqlManagedInstanceTransparentDataEncryption : TerraformResource
{
    public AzurermMssqlManagedInstanceTransparentDataEncryption(string name) : base("azurerm_mssql_managed_instance_transparent_data_encryption", name)
    {
    }

    /// <summary>
    /// The auto_rotation_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_rotation_enabled")]
    public TerraformValue<bool>? AutoRotationEnabled
    {
        get => new TerraformReference<bool>(this, "auto_rotation_enabled");
        set => SetArgument("auto_rotation_enabled", value);
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
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_key_id")]
    public TerraformValue<string>? KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformArgument("managed_hsm_key_id")]
    public TerraformValue<string>? ManagedHsmKeyId
    {
        get => new TerraformReference<string>(this, "managed_hsm_key_id");
        set => SetArgument("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    [TerraformArgument("managed_instance_id")]
    public required TerraformValue<string> ManagedInstanceId
    {
        get => new TerraformReference<string>(this, "managed_instance_id");
        set => SetArgument("managed_instance_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlManagedInstanceTransparentDataEncryptionTimeoutsBlock Timeouts { get; set; } = new();

}
