using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_kusto_cluster_customer_managed_key resource.
/// </summary>
public class AzurermKustoClusterCustomerManagedKey : TerraformResource
{
    public AzurermKustoClusterCustomerManagedKey(string name) : base("azurerm_kusto_cluster_customer_managed_key", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformArgument("cluster_id")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformArgument("key_name")]
    public TerraformValue<string>? KeyName
    {
        get => new TerraformReference<string>(this, "key_name");
        set => SetArgument("key_name", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_id")]
    public TerraformValue<string>? KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The key_version attribute.
    /// </summary>
    [TerraformArgument("key_version")]
    public TerraformValue<string>? KeyVersion
    {
        get => new TerraformReference<string>(this, "key_version");
        set => SetArgument("key_version", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformArgument("managed_hsm_key_id")]
    public TerraformValue<string>? ManagedHsmKeyId
    {
        get => new TerraformReference<string>(this, "managed_hsm_key_id");
        set => SetArgument("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The user_identity attribute.
    /// </summary>
    [TerraformArgument("user_identity")]
    public TerraformValue<string>? UserIdentity
    {
        get => new TerraformReference<string>(this, "user_identity");
        set => SetArgument("user_identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKustoClusterCustomerManagedKeyTimeoutsBlock Timeouts { get; set; } = new();

}
