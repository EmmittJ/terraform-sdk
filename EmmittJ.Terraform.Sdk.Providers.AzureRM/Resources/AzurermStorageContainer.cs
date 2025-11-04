using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("has_immutability_policy");
        this.DeclareOutput("has_legal_hold");
        this.DeclareOutput("resource_manager_id");
    }

    /// <summary>
    /// The container_access_type attribute.
    /// </summary>
    public string? ContainerAccessType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_access_type")?.Value;
        set => this.WithProperty("container_access_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    public string? DefaultEncryptionScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_encryption_scope")?.Value;
        set => this.WithProperty("default_encryption_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The encryption_scope_override_enabled attribute.
    /// </summary>
    public bool? EncryptionScopeOverrideEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("encryption_scope_override_enabled")?.Value;
        set => this.WithProperty("encryption_scope_override_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, string>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata")?.Value;
        set => this.WithProperty("metadata", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public string? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id")?.Value;
        set => this.WithProperty("storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? StorageAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_name")?.Value;
        set => this.WithProperty("storage_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
