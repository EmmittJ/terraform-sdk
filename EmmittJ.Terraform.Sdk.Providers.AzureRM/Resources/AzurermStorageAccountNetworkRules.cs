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
    public HashSet<string>? Bypass
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("bypass")?.Value;
        set => this.WithProperty("bypass", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public string? DefaultAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_action")?.Value;
        set => this.WithProperty("default_action", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ip_rules attribute.
    /// </summary>
    public HashSet<string>? IpRules
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ip_rules")?.Value;
        set => this.WithProperty("ip_rules", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public string? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id")?.Value;
        set => this.WithProperty("storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    public HashSet<string>? VirtualNetworkSubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("virtual_network_subnet_ids")?.Value;
        set => this.WithProperty("virtual_network_subnet_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
