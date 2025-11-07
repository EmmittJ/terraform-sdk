using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_account_network_rules resource.
/// </summary>
public class AzurermStorageAccountNetworkRules : TerraformResource
{
    public AzurermStorageAccountNetworkRules(string name) : base("azurerm_storage_account_network_rules", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The bypass attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Bypass
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("bypass");
        set => this.WithProperty("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultAction
    {
        get => GetProperty<TerraformProperty<string>>("default_action");
        set => this.WithProperty("default_action", value);
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
    /// The ip_rules attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? IpRules
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("ip_rules");
        set => this.WithProperty("ip_rules", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VirtualNetworkSubnetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("virtual_network_subnet_ids");
        set => this.WithProperty("virtual_network_subnet_ids", value);
    }

}
