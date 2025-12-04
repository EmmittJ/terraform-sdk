using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermEventhubNamespaceCustomerManagedKey.
/// Nesting mode: single
/// </summary>
public class AzurermEventhubNamespaceCustomerManagedKeyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_eventhub_namespace_customer_managed_key Terraform resource.
/// Manages a azurerm_eventhub_namespace_customer_managed_key resource.
/// </summary>
public partial class AzurermEventhubNamespaceCustomerManagedKey(string name) : TerraformResource("azurerm_eventhub_namespace_customer_managed_key", name)
{
    /// <summary>
    /// The eventhub_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceId is required")]
    public required TerraformValue<string> EventhubNamespaceId
    {
        get => GetArgument<TerraformValue<string>>("eventhub_namespace_id");
        set => SetArgument("eventhub_namespace_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InfrastructureEncryptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("infrastructure_encryption_enabled");
        set => SetArgument("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The key_vault_key_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyIds is required")]
    public required TerraformSet<string> KeyVaultKeyIds
    {
        get => GetArgument<TerraformSet<string>>("key_vault_key_ids");
        set => SetArgument("key_vault_key_ids", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? UserAssignedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventhubNamespaceCustomerManagedKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventhubNamespaceCustomerManagedKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
