using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for sku in AzurermApiManagementStandaloneGateway.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementStandaloneGatewaySkuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku";

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double>? Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
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

}


/// <summary>
/// Block type for timeouts in AzurermApiManagementStandaloneGateway.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementStandaloneGatewayTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_api_management_standalone_gateway Terraform resource.
/// Manages a azurerm_api_management_standalone_gateway resource.
/// </summary>
public partial class AzurermApiManagementStandaloneGateway(string name) : TerraformResource("azurerm_api_management_standalone_gateway", name)
{
    /// <summary>
    /// The backend_subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? BackendSubnetId
    {
        get => new TerraformReference<string>(this, "backend_subnet_id");
        set => SetArgument("backend_subnet_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_network_type attribute.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkType
    {
        get => new TerraformReference<string>(this, "virtual_network_type");
        set => SetArgument("virtual_network_type", value);
    }

    /// <summary>
    /// Sku block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public required TerraformList<AzurermApiManagementStandaloneGatewaySkuBlock> Sku
    {
        get => GetRequiredArgument<TerraformList<AzurermApiManagementStandaloneGatewaySkuBlock>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementStandaloneGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementStandaloneGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
