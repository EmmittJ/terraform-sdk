using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedInstanceTransparentDataEncryptionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mssql_managed_instance_transparent_data_encryption resource.
/// </summary>
public class AzurermMssqlManagedInstanceTransparentDataEncryption : TerraformResource
{
    public AzurermMssqlManagedInstanceTransparentDataEncryption(string name) : base("azurerm_mssql_managed_instance_transparent_data_encryption", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auto_rotation_enabled");
        SetOutput("id");
        SetOutput("key_vault_key_id");
        SetOutput("managed_hsm_key_id");
        SetOutput("managed_instance_id");
    }

    /// <summary>
    /// The auto_rotation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutoRotationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_rotation_enabled");
        set => SetProperty("auto_rotation_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KeyVaultKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_key_id");
        set => SetProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformProperty<string> ManagedHsmKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_hsm_key_id");
        set => SetProperty("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    public required TerraformProperty<string> ManagedInstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_instance_id");
        set => SetProperty("managed_instance_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlManagedInstanceTransparentDataEncryptionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
