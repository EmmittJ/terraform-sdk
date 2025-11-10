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
        SetOutput("id");
        SetOutput("key_vault_key_id");
        SetOutput("log_analytics_cluster_id");
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
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformProperty<string> KeyVaultKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_key_id");
        set => SetProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The log_analytics_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsClusterId is required")]
    public required TerraformProperty<string> LogAnalyticsClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_analytics_cluster_id");
        set => SetProperty("log_analytics_cluster_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogAnalyticsClusterCustomerManagedKeyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
