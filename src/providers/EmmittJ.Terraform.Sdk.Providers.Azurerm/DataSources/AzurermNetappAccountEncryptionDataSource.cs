using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetappAccountEncryptionDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermNetappAccountEncryptionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_netapp_account_encryption Terraform data source.
/// Retrieves information about a azurerm_netapp_account_encryption.
/// </summary>
public partial class AzurermNetappAccountEncryptionDataSource(string name) : TerraformDataSource("azurerm_netapp_account_encryption", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the NetApp Account where encryption will be set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetappAccountId is required")]
    public required TerraformValue<string> NetappAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("netapp_account_id");
        set => SetArgument("netapp_account_id", value);
    }

    /// <summary>
    /// The cross_tenant_key_vault_resource_id attribute.
    /// </summary>
    public TerraformValue<string> CrossTenantKeyVaultResourceId
        => AsReference("cross_tenant_key_vault_resource_id");

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    public TerraformValue<string> EncryptionKey
        => AsReference("encryption_key");

    /// <summary>
    /// The federated_client_id attribute.
    /// </summary>
    public TerraformValue<string> FederatedClientId
        => AsReference("federated_client_id");

    /// <summary>
    /// The system_assigned_identity_principal_id attribute.
    /// </summary>
    public TerraformValue<string> SystemAssignedIdentityPrincipalId
        => AsReference("system_assigned_identity_principal_id");

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string> UserAssignedIdentityId
        => AsReference("user_assigned_identity_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappAccountEncryptionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappAccountEncryptionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
