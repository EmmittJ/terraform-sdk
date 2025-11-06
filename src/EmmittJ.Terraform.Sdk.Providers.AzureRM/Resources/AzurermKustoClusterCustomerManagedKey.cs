using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public string? ClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_id")?.Value;
        set => this.WithProperty("cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public string? KeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_name")?.Value;
        set => this.WithProperty("key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    public string? KeyVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_id")?.Value;
        set => this.WithProperty("key_vault_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_version attribute.
    /// </summary>
    public string? KeyVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_version")?.Value;
        set => this.WithProperty("key_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public string? ManagedHsmKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_hsm_key_id")?.Value;
        set => this.WithProperty("managed_hsm_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_identity attribute.
    /// </summary>
    public string? UserIdentity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_identity")?.Value;
        set => this.WithProperty("user_identity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
