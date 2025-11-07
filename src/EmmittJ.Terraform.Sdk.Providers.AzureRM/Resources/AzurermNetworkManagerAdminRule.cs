using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_manager_admin_rule resource.
/// </summary>
public class AzurermNetworkManagerAdminRule : TerraformResource
{
    public AzurermNetworkManagerAdminRule(string name) : base("azurerm_network_manager_admin_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformProperty<string>? Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// The admin_rule_collection_id attribute.
    /// </summary>
    public TerraformProperty<string>? AdminRuleCollectionId
    {
        get => GetProperty<TerraformProperty<string>>("admin_rule_collection_id");
        set => this.WithProperty("admin_rule_collection_id", value);
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
    /// The destination_port_ranges attribute.
    /// </summary>
    public TerraformProperty<List<string>>? DestinationPortRanges
    {
        get => GetProperty<TerraformProperty<List<string>>>("destination_port_ranges");
        set => this.WithProperty("destination_port_ranges", value);
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    public TerraformProperty<string>? Direction
    {
        get => GetProperty<TerraformProperty<string>>("direction");
        set => this.WithProperty("direction", value);
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
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The source_port_ranges attribute.
    /// </summary>
    public TerraformProperty<List<string>>? SourcePortRanges
    {
        get => GetProperty<TerraformProperty<List<string>>>("source_port_ranges");
        set => this.WithProperty("source_port_ranges", value);
    }

}
