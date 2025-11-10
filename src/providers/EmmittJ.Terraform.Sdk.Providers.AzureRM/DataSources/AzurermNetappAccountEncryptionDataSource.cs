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
        set => SetProperty("read", value);
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
        SetOutput("cross_tenant_key_vault_resource_id");
        SetOutput("encryption_key");
        SetOutput("federated_client_id");
        SetOutput("system_assigned_identity_principal_id");
        SetOutput("user_assigned_identity_id");
        SetOutput("id");
        SetOutput("netapp_account_id");
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
    /// The ID of the NetApp Account where encryption will be set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetappAccountId is required")]
    public required TerraformProperty<string> NetappAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("netapp_account_id");
        set => SetProperty("netapp_account_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappAccountEncryptionDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
