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
    public string? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action")?.Value;
        set => this.WithProperty("action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The admin_rule_collection_id attribute.
    /// </summary>
    public string? AdminRuleCollectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_rule_collection_id")?.Value;
        set => this.WithProperty("admin_rule_collection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_port_ranges attribute.
    /// </summary>
    public List<string>? DestinationPortRanges
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("destination_port_ranges")?.Value;
        set => this.WithProperty("destination_port_ranges", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    public string? Direction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("direction")?.Value;
        set => this.WithProperty("direction", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_port_ranges attribute.
    /// </summary>
    public List<string>? SourcePortRanges
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("source_port_ranges")?.Value;
        set => this.WithProperty("source_port_ranges", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

}
