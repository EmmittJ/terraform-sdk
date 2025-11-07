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
    public TerraformProperty<HashSet<string>>? Filters
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("filters");
        set => this.WithProperty("filters", value);
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
    /// The predicates attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Predicates
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("predicates");
        set => this.WithProperty("predicates", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public TerraformProperty<string>? SpringCloudAppId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_app_id");
        set => this.WithProperty("spring_cloud_app_id", value);
    }

    /// <summary>
    /// The spring_cloud_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? SpringCloudGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_gateway_id");
        set => this.WithProperty("spring_cloud_gateway_id", value);
    }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SsoValidationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sso_validation_enabled");
        set => this.WithProperty("sso_validation_enabled", value);
    }

}
