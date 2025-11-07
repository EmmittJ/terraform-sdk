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
    /// The network_group_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? NetworkGroupIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("network_group_ids");
        set => this.WithProperty("network_group_ids", value);
    }

    /// <summary>
    /// The security_admin_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityAdminConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("security_admin_configuration_id");
        set => this.WithProperty("security_admin_configuration_id", value);
    }

}
