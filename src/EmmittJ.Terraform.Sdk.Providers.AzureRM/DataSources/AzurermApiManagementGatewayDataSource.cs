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
    public string? ApiManagementId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_id")?.Value;
        set => this.WithProperty("api_management_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The location_data attribute.
    /// </summary>
    public TerraformExpression LocationData => this["location_data"];

}
