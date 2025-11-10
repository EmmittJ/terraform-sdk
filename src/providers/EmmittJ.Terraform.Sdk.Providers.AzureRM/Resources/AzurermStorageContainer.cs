using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageContainerTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_storage_container resource.
/// </summary>
public class AzurermStorageContainer : TerraformResource
{
    public AzurermStorageContainer(string name) : base("azurerm_storage_container", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("has_immutability_policy");
        SetOutput("has_legal_hold");
        SetOutput("resource_manager_id");
        SetOutput("container_access_type");
        SetOutput("default_encryption_scope");
        SetOutput("encryption_scope_override_enabled");
        SetOutput("id");
        SetOutput("metadata");
        SetOutput("name");
        SetOutput("storage_account_id");
        SetOutput("storage_account_name");
    }

    /// <summary>
    /// The container_access_type attribute.
    /// </summary>
    public TerraformProperty<string> ContainerAccessType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_access_type");
        set => SetProperty("container_access_type", value);
    }

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    public TerraformProperty<string> DefaultEncryptionScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_encryption_scope");
        set => SetProperty("default_encryption_scope", value);
    }

    /// <summary>
    /// The encryption_scope_override_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> EncryptionScopeOverrideEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("encryption_scope_override_enabled");
        set => SetProperty("encryption_scope_override_enabled", value);
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
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Metadata
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => SetProperty("metadata", value);
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
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> StorageAccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_name");
        set => SetProperty("storage_account_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageContainerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The has_immutability_policy attribute.
    /// </summary>
    public TerraformExpression HasImmutabilityPolicy => this["has_immutability_policy"];

    /// <summary>
    /// The has_legal_hold attribute.
    /// </summary>
    public TerraformExpression HasLegalHold => this["has_legal_hold"];

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformExpression ResourceManagerId => this["resource_manager_id"];

}
