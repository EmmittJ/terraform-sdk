using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermCognitiveAccountCustomerManagedKey.
/// Nesting mode: single
/// </summary>
public class AzurermCognitiveAccountCustomerManagedKeyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_cognitive_account_customer_managed_key Terraform resource.
/// Manages a azurerm_cognitive_account_customer_managed_key resource.
/// </summary>
public partial class AzurermCognitiveAccountCustomerManagedKey(string name) : TerraformResource("azurerm_cognitive_account_customer_managed_key", name)
{
    /// <summary>
    /// The cognitive_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CognitiveAccountId is required")]
    public required TerraformValue<string> CognitiveAccountId
    {
        get => GetArgument<TerraformValue<string>>("cognitive_account_id");
        set => SetArgument("cognitive_account_id", value);
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
    /// The identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? IdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("identity_client_id");
        set => SetArgument("identity_client_id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCognitiveAccountCustomerManagedKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCognitiveAccountCustomerManagedKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
