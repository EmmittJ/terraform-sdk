using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_manager_management_group_connection resource.
/// </summary>
public class AzurermNetworkManagerManagementGroupConnection : TerraformResource
{
    public AzurermNetworkManagerManagementGroupConnection(string name) : base("azurerm_network_manager_management_group_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("connection_state");
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
    /// The management_group_id attribute.
    /// </summary>
    public string? ManagementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("management_group_id")?.Value;
        set => this.WithProperty("management_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The connection_state attribute.
    /// </summary>
    public TerraformExpression ConnectionState => this["connection_state"];

}
