using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_virtual_hub_connection.
/// </summary>
public class AzurermVirtualHubConnectionDataSource : TerraformDataSource
{
    public AzurermVirtualHubConnectionDataSource(string name) : base("azurerm_virtual_hub_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("internet_security_enabled");
        this.DeclareOutput("remote_virtual_network_id");
        this.DeclareOutput("routing");
        this.DeclareOutput("virtual_hub_id");
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_hub_name attribute.
    /// </summary>
    public string? VirtualHubName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_hub_name")?.Value;
        set => this.WithProperty("virtual_hub_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    public TerraformExpression InternetSecurityEnabled => this["internet_security_enabled"];

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    public TerraformExpression RemoteVirtualNetworkId => this["remote_virtual_network_id"];

    /// <summary>
    /// The routing attribute.
    /// </summary>
    public TerraformExpression Routing => this["routing"];

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    public TerraformExpression VirtualHubId => this["virtual_hub_id"];

}
