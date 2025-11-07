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
    public TerraformLiteralProperty<string>? CrossTenantKeyVaultResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cross_tenant_key_vault_resource_id");
        set => this.WithProperty("cross_tenant_key_vault_resource_id", value);
    }

    /// <summary>
    /// The versionless encryption key url.
    /// </summary>
    public TerraformLiteralProperty<string>? EncryptionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_key");
        set => this.WithProperty("encryption_key", value);
    }

    /// <summary>
    /// The Client ID of the multi-tenant Entra ID application used to access cross-tenant key vaults.
    /// </summary>
    public TerraformLiteralProperty<string>? FederatedClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("federated_client_id");
        set => this.WithProperty("federated_client_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ID of the NetApp Account where encryption will be set.
    /// </summary>
    public TerraformLiteralProperty<string>? NetappAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("netapp_account_id");
        set => this.WithProperty("netapp_account_id", value);
    }

    /// <summary>
    /// The Principal ID of the System Assigned Identity to use for encryption.
    /// </summary>
    public TerraformLiteralProperty<string>? SystemAssignedIdentityPrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("system_assigned_identity_principal_id");
        set => this.WithProperty("system_assigned_identity_principal_id", value);
    }

    /// <summary>
    /// The resource ID of the User Assigned Identity to use for encryption.
    /// </summary>
    public TerraformLiteralProperty<string>? UserAssignedIdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_assigned_identity_id");
        set => this.WithProperty("user_assigned_identity_id", value);
    }

}
