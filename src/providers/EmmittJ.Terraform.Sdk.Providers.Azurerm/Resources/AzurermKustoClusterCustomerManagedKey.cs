using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKustoClusterCustomerManagedKey.
/// Nesting mode: single
/// </summary>
public class AzurermKustoClusterCustomerManagedKeyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_kusto_cluster_customer_managed_key Terraform resource.
/// Manages a azurerm_kusto_cluster_customer_managed_key resource.
/// </summary>
public partial class AzurermKustoClusterCustomerManagedKey(string name) : TerraformResource("azurerm_kusto_cluster_customer_managed_key", name)
{
    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformValue<string>? KeyName
    {
        get => GetArgument<TerraformValue<string>>("key_name");
        set => SetArgument("key_name", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The key_version attribute.
    /// </summary>
    public TerraformValue<string>? KeyVersion
    {
        get => GetArgument<TerraformValue<string>>("key_version");
        set => SetArgument("key_version", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedHsmKeyId
    {
        get => GetArgument<TerraformValue<string>>("managed_hsm_key_id");
        set => SetArgument("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The user_identity attribute.
    /// </summary>
    public TerraformValue<string>? UserIdentity
    {
        get => GetArgument<TerraformValue<string>>("user_identity");
        set => SetArgument("user_identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKustoClusterCustomerManagedKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKustoClusterCustomerManagedKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
