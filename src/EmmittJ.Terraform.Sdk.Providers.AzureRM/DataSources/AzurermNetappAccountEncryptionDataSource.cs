using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_netapp_account_encryption.
/// </summary>
public class AzurermNetappAccountEncryptionDataSource : TerraformDataSource
{
    public AzurermNetappAccountEncryptionDataSource(string name) : base("azurerm_netapp_account_encryption", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cross_tenant_key_vault_resource_id");
        this.DeclareOutput("encryption_key");
        this.DeclareOutput("federated_client_id");
        this.DeclareOutput("system_assigned_identity_principal_id");
        this.DeclareOutput("user_assigned_identity_id");
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
    /// The ID of the NetApp Account where encryption will be set.
    /// </summary>
    public TerraformProperty<string>? NetappAccountId
    {
        get => GetProperty<TerraformProperty<string>>("netapp_account_id");
        set => this.WithProperty("netapp_account_id", value);
    }

    /// <summary>
    /// The cross_tenant_key_vault_resource_id attribute.
    /// </summary>
    public TerraformExpression CrossTenantKeyVaultResourceId => this["cross_tenant_key_vault_resource_id"];

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    public TerraformExpression EncryptionKey => this["encryption_key"];

    /// <summary>
    /// The federated_client_id attribute.
    /// </summary>
    public TerraformExpression FederatedClientId => this["federated_client_id"];

    /// <summary>
    /// The system_assigned_identity_principal_id attribute.
    /// </summary>
    public TerraformExpression SystemAssignedIdentityPrincipalId => this["system_assigned_identity_principal_id"];

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformExpression UserAssignedIdentityId => this["user_assigned_identity_id"];

}
