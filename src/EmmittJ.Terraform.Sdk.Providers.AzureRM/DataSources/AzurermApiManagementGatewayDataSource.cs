using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_api_management_gateway.
/// </summary>
public class AzurermApiManagementGatewayDataSource : TerraformDataSource
{
    public AzurermApiManagementGatewayDataSource(string name) : base("azurerm_api_management_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("location_data");
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApiManagementId
    {
        get => GetProperty<TerraformProperty<string>>("api_management_id");
        set => this.WithProperty("api_management_id", value);
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
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The location_data attribute.
    /// </summary>
    public TerraformExpression LocationData => this["location_data"];

}
