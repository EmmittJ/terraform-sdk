using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVmwareExpressRouteAuthorizationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The private_cloud_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateCloudId is required")]
    public required TerraformProperty<string> PrivateCloudId
    {
        get => GetProperty<TerraformProperty<string>>("private_cloud_id");
        set => this.WithProperty("private_cloud_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVmwareExpressRouteAuthorizationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVmwareExpressRouteAuthorizationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
