using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_netapp_account_encryption resource.
/// </summary>
public class AzurermNetappAccountEncryption : TerraformResource
{
    public AzurermNetappAccountEncryption(string name) : base("azurerm_netapp_account_encryption", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The full resource ID of the cross-tenant key vault. Required when using federated_client_id for cross-tenant scenarios.
    /// </summary>
    public string? CrossTenantKeyVaultResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cross_tenant_key_vault_resource_id")?.Value;
        set => this.WithProperty("cross_tenant_key_vault_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The versionless encryption key url.
    /// </summary>
    public string? EncryptionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_key")?.Value;
        set => this.WithProperty("encryption_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Client ID of the multi-tenant Entra ID application used to access cross-tenant key vaults.
    /// </summary>
    public string? FederatedClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("federated_client_id")?.Value;
        set => this.WithProperty("federated_client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ID of the NetApp Account where encryption will be set.
    /// </summary>
    public string? NetappAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("netapp_account_id")?.Value;
        set => this.WithProperty("netapp_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Principal ID of the System Assigned Identity to use for encryption.
    /// </summary>
    public string? SystemAssignedIdentityPrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("system_assigned_identity_principal_id")?.Value;
        set => this.WithProperty("system_assigned_identity_principal_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource ID of the User Assigned Identity to use for encryption.
    /// </summary>
    public string? UserAssignedIdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_assigned_identity_id")?.Value;
        set => this.WithProperty("user_assigned_identity_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
