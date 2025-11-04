using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_express_route_port_authorization resource.
/// </summary>
public class AzurermExpressRoutePortAuthorization : TerraformResource
{
    public AzurermExpressRoutePortAuthorization(string name) : base("azurerm_express_route_port_authorization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("authorization_key");
        this.DeclareOutput("authorization_use_status");
    }

    /// <summary>
    /// The express_route_port_name attribute.
    /// </summary>
    public string? ExpressRoutePortName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("express_route_port_name")?.Value;
        set => this.WithProperty("express_route_port_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The authorization_key attribute.
    /// </summary>
    public TerraformExpression AuthorizationKey => this["authorization_key"];

    /// <summary>
    /// The authorization_use_status attribute.
    /// </summary>
    public TerraformExpression AuthorizationUseStatus => this["authorization_use_status"];

}
