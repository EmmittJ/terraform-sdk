using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappAccountEncryptionDataSourceTimeoutsBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetappAccountId is required")]
    public required TerraformProperty<string> NetappAccountId
    {
        get => GetProperty<TerraformProperty<string>>("netapp_account_id");
        set => this.WithProperty("netapp_account_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappAccountEncryptionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetappAccountEncryptionDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
