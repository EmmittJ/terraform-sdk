using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_manager_routing_rule resource.
/// </summary>
public class AzurermNetworkManagerRoutingRule : TerraformResource
{
    public AzurermNetworkManagerRoutingRule(string name) : base("azurerm_network_manager_routing_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The rule_collection_id attribute.
    /// </summary>
    public TerraformProperty<string>? RuleCollectionId
    {
        get => GetProperty<TerraformProperty<string>>("rule_collection_id");
        set => this.WithProperty("rule_collection_id", value);
    }

}
