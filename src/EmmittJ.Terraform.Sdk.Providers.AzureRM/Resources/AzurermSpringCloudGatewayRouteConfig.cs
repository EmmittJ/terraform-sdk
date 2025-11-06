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
    public HashSet<string>? Filters
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("filters")?.Value;
        set => this.WithProperty("filters", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The predicates attribute.
    /// </summary>
    public HashSet<string>? Predicates
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("predicates")?.Value;
        set => this.WithProperty("predicates", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public string? SpringCloudAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_app_id")?.Value;
        set => this.WithProperty("spring_cloud_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The spring_cloud_gateway_id attribute.
    /// </summary>
    public string? SpringCloudGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_gateway_id")?.Value;
        set => this.WithProperty("spring_cloud_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    public bool? SsoValidationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sso_validation_enabled")?.Value;
        set => this.WithProperty("sso_validation_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
