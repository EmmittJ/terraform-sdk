using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVmwareExpressRouteAuthorization.
/// Nesting mode: single
/// </summary>
public class AzurermVmwareExpressRouteAuthorizationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_vmware_express_route_authorization Terraform resource.
/// Manages a azurerm_vmware_express_route_authorization resource.
/// </summary>
public partial class AzurermVmwareExpressRouteAuthorization(string name) : TerraformResource("azurerm_vmware_express_route_authorization", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_cloud_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateCloudId is required")]
    public required TerraformValue<string> PrivateCloudId
    {
        get => GetRequiredArgument<TerraformValue<string>>("private_cloud_id");
        set => SetArgument("private_cloud_id", value);
    }

    /// <summary>
    /// The express_route_authorization_id attribute.
    /// </summary>
    public TerraformValue<string> ExpressRouteAuthorizationId
        => CreateReference("express_route_authorization_id");

    /// <summary>
    /// The express_route_authorization_key attribute.
    /// </summary>
    public TerraformValue<string> ExpressRouteAuthorizationKey
        => CreateReference("express_route_authorization_key");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVmwareExpressRouteAuthorizationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVmwareExpressRouteAuthorizationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
