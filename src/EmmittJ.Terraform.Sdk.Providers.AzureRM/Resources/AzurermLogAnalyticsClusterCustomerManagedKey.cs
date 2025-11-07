using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The log_analytics_cluster_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LogAnalyticsClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_analytics_cluster_id");
        set => this.WithProperty("log_analytics_cluster_id", value);
    }

}
