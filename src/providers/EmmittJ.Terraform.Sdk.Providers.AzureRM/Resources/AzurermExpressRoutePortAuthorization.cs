using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "express_route_port_name");
        set => SetArgument("express_route_port_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformValue<string> AuthorizationKey
    {
        get => new TerraformReference<string>(this, "authorization_key");
    }

    /// <summary>
    /// The authorization_use_status attribute.
    /// </summary>
    public TerraformValue<string> AuthorizationUseStatus
    {
        get => new TerraformReference<string>(this, "authorization_use_status");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermExpressRoutePortAuthorizationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermExpressRoutePortAuthorizationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
