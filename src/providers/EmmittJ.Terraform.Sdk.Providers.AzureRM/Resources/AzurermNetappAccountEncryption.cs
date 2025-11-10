using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappAccountEncryptionTimeoutsBlock : TerraformBlock
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
        SetOutput("cross_tenant_key_vault_resource_id");
        SetOutput("encryption_key");
        SetOutput("federated_client_id");
        SetOutput("id");
        SetOutput("netapp_account_id");
        SetOutput("system_assigned_identity_principal_id");
        SetOutput("user_assigned_identity_id");
    }

    /// <summary>
    /// The full resource ID of the cross-tenant key vault. Required when using federated_client_id for cross-tenant scenarios.
    /// </summary>
    public TerraformProperty<string> CrossTenantKeyVaultResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cross_tenant_key_vault_resource_id");
        set => SetProperty("cross_tenant_key_vault_resource_id", value);
    }

    /// <summary>
    /// The versionless encryption key url.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionKey is required")]
    public required TerraformProperty<string> EncryptionKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encryption_key");
        set => SetProperty("encryption_key", value);
    }

    /// <summary>
    /// The Client ID of the multi-tenant Entra ID application used to access cross-tenant key vaults.
    /// </summary>
    public TerraformProperty<string> FederatedClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("federated_client_id");
        set => SetProperty("federated_client_id", value);
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
    /// The Principal ID of the System Assigned Identity to use for encryption.
    /// </summary>
    public TerraformProperty<string> SystemAssignedIdentityPrincipalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("system_assigned_identity_principal_id");
        set => SetProperty("system_assigned_identity_principal_id", value);
    }

    /// <summary>
    /// The resource ID of the User Assigned Identity to use for encryption.
    /// </summary>
    public TerraformProperty<string> UserAssignedIdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_assigned_identity_id");
        set => SetProperty("user_assigned_identity_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappAccountEncryptionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
