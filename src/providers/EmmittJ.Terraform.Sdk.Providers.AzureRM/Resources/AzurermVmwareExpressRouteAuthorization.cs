using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Manages a azurerm_vmware_express_route_authorization resource.
/// </summary>
public class AzurermVmwareExpressRouteAuthorization : TerraformResource
{
    public AzurermVmwareExpressRouteAuthorization(string name) : base("azurerm_vmware_express_route_authorization", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_cloud_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateCloudId is required")]
    [TerraformArgument("private_cloud_id")]
    public required TerraformValue<string> PrivateCloudId
    {
        get => new TerraformReference<string>(this, "private_cloud_id");
        set => SetArgument("private_cloud_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVmwareExpressRouteAuthorizationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The express_route_authorization_id attribute.
    /// </summary>
    [TerraformArgument("express_route_authorization_id")]
    public TerraformValue<string> ExpressRouteAuthorizationId
    {
        get => new TerraformReference<string>(this, "express_route_authorization_id");
    }

    /// <summary>
    /// The express_route_authorization_key attribute.
    /// </summary>
    [TerraformArgument("express_route_authorization_key")]
    public TerraformValue<string> ExpressRouteAuthorizationKey
    {
        get => new TerraformReference<string>(this, "express_route_authorization_key");
    }

}
