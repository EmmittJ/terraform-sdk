using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsClusterCustomerManagedKeyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_log_analytics_cluster_customer_managed_key resource.
/// </summary>
public class AzurermLogAnalyticsClusterCustomerManagedKey : TerraformResource
{
    public AzurermLogAnalyticsClusterCustomerManagedKey(string name) : base("azurerm_log_analytics_cluster_customer_managed_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformProperty<string> KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The log_analytics_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsClusterId is required")]
    public required TerraformProperty<string> LogAnalyticsClusterId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_cluster_id");
        set => this.WithProperty("log_analytics_cluster_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogAnalyticsClusterCustomerManagedKeyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLogAnalyticsClusterCustomerManagedKeyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
