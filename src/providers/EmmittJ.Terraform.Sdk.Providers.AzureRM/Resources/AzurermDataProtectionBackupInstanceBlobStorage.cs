using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupInstanceBlobStorageTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_data_protection_backup_instance_blob_storage resource.
/// </summary>
public class AzurermDataProtectionBackupInstanceBlobStorage : TerraformResource
{
    public AzurermDataProtectionBackupInstanceBlobStorage(string name) : base("azurerm_data_protection_backup_instance_blob_storage", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("backup_policy_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("storage_account_container_names");
        SetOutput("storage_account_id");
        SetOutput("vault_id");
    }

    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    public required TerraformProperty<string> BackupPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_policy_id");
        set => SetProperty("backup_policy_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The storage_account_container_names attribute.
    /// </summary>
    public List<TerraformProperty<string>> StorageAccountContainerNames
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("storage_account_container_names");
        set => SetProperty("storage_account_container_names", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    public required TerraformProperty<string> VaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vault_id");
        set => SetProperty("vault_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataProtectionBackupInstanceBlobStorageTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
