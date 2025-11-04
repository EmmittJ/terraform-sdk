using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_manager_admin_rule_collection resource.
/// </summary>
public class AzurermNetworkManagerAdminRuleCollection : TerraformResource
{
    public AzurermNetworkManagerAdminRuleCollection(string name) : base("azurerm_network_manager_admin_rule_collection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The network_group_ids attribute.
    /// </summary>
    public List<string>? NetworkGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("network_group_ids")?.Value;
        set => this.WithProperty("network_group_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The security_admin_configuration_id attribute.
    /// </summary>
    public string? SecurityAdminConfigurationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_admin_configuration_id")?.Value;
        set => this.WithProperty("security_admin_configuration_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
