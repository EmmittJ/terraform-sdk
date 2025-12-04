using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermExpressRoutePortAuthorization.
/// Nesting mode: single
/// </summary>
public class AzurermExpressRoutePortAuthorizationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_express_route_port_authorization Terraform resource.
/// Manages a azurerm_express_route_port_authorization resource.
/// </summary>
public partial class AzurermExpressRoutePortAuthorization(string name) : TerraformResource("azurerm_express_route_port_authorization", name)
{
    /// <summary>
    /// The express_route_port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRoutePortName is required")]
    public required TerraformValue<string> ExpressRoutePortName
    {
        get => GetArgument<TerraformValue<string>>("express_route_port_name");
        set => SetArgument("express_route_port_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformValue<string> AuthorizationKey
        => AsReference("authorization_key");

    /// <summary>
    /// The authorization_use_status attribute.
    /// </summary>
    public TerraformValue<string> AuthorizationUseStatus
        => AsReference("authorization_use_status");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermExpressRoutePortAuthorizationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermExpressRoutePortAuthorizationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
