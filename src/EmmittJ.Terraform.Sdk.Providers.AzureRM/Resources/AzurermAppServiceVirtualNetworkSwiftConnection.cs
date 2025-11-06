using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_app_service_virtual_network_swift_connection resource.
/// </summary>
public class AzurermAppServiceVirtualNetworkSwiftConnection : TerraformResource
{
    public AzurermAppServiceVirtualNetworkSwiftConnection(string name) : base("azurerm_app_service_virtual_network_swift_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The app_service_id attribute.
    /// </summary>
    public string? AppServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_service_id")?.Value;
        set => this.WithProperty("app_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
