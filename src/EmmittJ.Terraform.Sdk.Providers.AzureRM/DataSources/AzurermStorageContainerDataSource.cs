using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageContainerDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_storage_container.
/// </summary>
public class AzurermStorageContainerDataSource : TerraformDataSource
{
    public AzurermStorageContainerDataSource(string name) : base("azurerm_storage_container", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("container_access_type");
        this.DeclareOutput("default_encryption_scope");
        this.DeclareOutput("encryption_scope_override_enabled");
        this.DeclareOutput("has_immutability_policy");
        this.DeclareOutput("has_legal_hold");
        this.DeclareOutput("resource_manager_id");
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
        get => GetProperty<TerraformProperty<string>>("name");
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
    public TerraformProperty<string>? StorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_name");
        set => this.WithProperty("storage_account_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageContainerDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageContainerDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The container_access_type attribute.
    /// </summary>
    public TerraformExpression ContainerAccessType => this["container_access_type"];

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    public TerraformExpression DefaultEncryptionScope => this["default_encryption_scope"];

    /// <summary>
    /// The encryption_scope_override_enabled attribute.
    /// </summary>
    public TerraformExpression EncryptionScopeOverrideEnabled => this["encryption_scope_override_enabled"];

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
