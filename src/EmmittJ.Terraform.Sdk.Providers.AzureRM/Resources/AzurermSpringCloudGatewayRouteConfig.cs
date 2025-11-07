using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_gateway_route_config resource.
/// </summary>
public class AzurermSpringCloudGatewayRouteConfig : TerraformResource
{
    public AzurermSpringCloudGatewayRouteConfig(string name) : base("azurerm_spring_cloud_gateway_route_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The filters attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Filters
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("filters");
        set => this.WithProperty("filters", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The predicates attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Predicates
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("predicates");
        set => this.WithProperty("predicates", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SpringCloudAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_app_id");
        set => this.WithProperty("spring_cloud_app_id", value);
    }

    /// <summary>
    /// The spring_cloud_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SpringCloudGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_gateway_id");
        set => this.WithProperty("spring_cloud_gateway_id", value);
    }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SsoValidationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sso_validation_enabled");
        set => this.WithProperty("sso_validation_enabled", value);
    }

}
