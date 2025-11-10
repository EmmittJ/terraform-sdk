using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKustoClusterCustomerManagedKeyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_kusto_cluster_customer_managed_key resource.
/// </summary>
public class AzurermKustoClusterCustomerManagedKey : TerraformResource
{
    public AzurermKustoClusterCustomerManagedKey(string name) : base("azurerm_kusto_cluster_customer_managed_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cluster_id");
        SetOutput("id");
        SetOutput("key_name");
        SetOutput("key_vault_id");
        SetOutput("key_version");
        SetOutput("managed_hsm_key_id");
        SetOutput("user_identity");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_id");
        set => SetProperty("cluster_id", value);
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
    /// The key_name attribute.
    /// </summary>
    public TerraformProperty<string> KeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_name");
        set => SetProperty("key_name", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformProperty<string> KeyVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_id");
        set => SetProperty("key_vault_id", value);
    }

    /// <summary>
    /// The key_version attribute.
    /// </summary>
    public TerraformProperty<string> KeyVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_version");
        set => SetProperty("key_version", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformProperty<string> ManagedHsmKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_hsm_key_id");
        set => SetProperty("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The user_identity attribute.
    /// </summary>
    public TerraformProperty<string> UserIdentity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_identity");
        set => SetProperty("user_identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKustoClusterCustomerManagedKeyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
