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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.WithOutputas_immutability_policy");
        this.WithOutputas_legal_hold");
        this.WithOutputesource_manager_id");
    }

    /// <summary>
    /// The container_access_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerAccessType
    {
        get => GetProperty<TerraformProperty<string>>("container_access_type");
        set => this.WithProperty("container_access_type", value);
    }

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultEncryptionScope
    {
        get => GetProperty<TerraformProperty<string>>("default_encryption_scope");
        set => this.WithProperty("default_encryption_scope", value);
    }

    /// <summary>
    /// The encryption_scope_override_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EncryptionScopeOverrideEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("encryption_scope_override_enabled");
        set => this.WithProperty("encryption_scope_override_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? StorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_name");
        set => this.WithProperty("storage_account_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageContainerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageContainerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
