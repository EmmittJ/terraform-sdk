using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitAuthorizationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_express_route_circuit_authorization resource.
/// </summary>
public class AzurermExpressRouteCircuitAuthorization : TerraformResource
{
    public AzurermExpressRouteCircuitAuthorization(string name) : base("azurerm_express_route_circuit_authorization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("authorization_key");
        SetOutput("authorization_use_status");
        SetOutput("express_route_circuit_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The express_route_circuit_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteCircuitName is required")]
    public required TerraformProperty<string> ExpressRouteCircuitName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("express_route_circuit_name");
        set => SetProperty("express_route_circuit_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExpressRouteCircuitAuthorizationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
