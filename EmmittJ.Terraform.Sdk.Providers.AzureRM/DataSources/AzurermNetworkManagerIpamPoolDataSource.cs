using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_network_manager_ipam_pool.
/// </summary>
public class AzurermNetworkManagerIpamPoolDataSource : TerraformDataSource
{
    public AzurermNetworkManagerIpamPoolDataSource(string name) : base("azurerm_network_manager_ipam_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("address_prefixes");
        this.DeclareOutput("description");
        this.DeclareOutput("display_name");
        this.DeclareOutput("location");
        this.DeclareOutput("parent_pool_name");
        this.DeclareOutput("tags");
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
    /// The network_manager_id attribute.
    /// </summary>
    public string? NetworkManagerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_manager_id")?.Value;
        set => this.WithProperty("network_manager_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public TerraformExpression AddressPrefixes => this["address_prefixes"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The parent_pool_name attribute.
    /// </summary>
    public TerraformExpression ParentPoolName => this["parent_pool_name"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
