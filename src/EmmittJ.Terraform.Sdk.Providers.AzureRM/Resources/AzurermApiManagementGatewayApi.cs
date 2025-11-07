using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_gateway_api resource.
/// </summary>
public class AzurermApiManagementGatewayApi : TerraformResource
{
    public AzurermApiManagementGatewayApi(string name) : base("azurerm_api_management_gateway_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApiId
    {
        get => GetProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayId
    {
        get => GetProperty<TerraformProperty<string>>("gateway_id");
        set => this.WithProperty("gateway_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
