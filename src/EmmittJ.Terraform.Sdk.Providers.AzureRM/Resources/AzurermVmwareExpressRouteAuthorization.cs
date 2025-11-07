using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_vmware_express_route_authorization resource.
/// </summary>
public class AzurermVmwareExpressRouteAuthorization : TerraformResource
{
    public AzurermVmwareExpressRouteAuthorization(string name) : base("azurerm_vmware_express_route_authorization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("express_route_authorization_id");
        this.DeclareOutput("express_route_authorization_key");
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
    /// The private_cloud_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrivateCloudId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_cloud_id");
        set => this.WithProperty("private_cloud_id", value);
    }

    /// <summary>
    /// The express_route_authorization_id attribute.
    /// </summary>
    public TerraformExpression ExpressRouteAuthorizationId => this["express_route_authorization_id"];

    /// <summary>
    /// The express_route_authorization_key attribute.
    /// </summary>
    public TerraformExpression ExpressRouteAuthorizationKey => this["express_route_authorization_key"];

}
