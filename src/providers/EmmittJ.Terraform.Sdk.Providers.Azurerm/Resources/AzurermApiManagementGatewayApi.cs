using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementGatewayApi.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementGatewayApiTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_api_management_gateway_api Terraform resource.
/// Manages a azurerm_api_management_gateway_api resource.
/// </summary>
public partial class AzurermApiManagementGatewayApi(string name) : TerraformResource("azurerm_api_management_gateway_api", name)
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformValue<string> ApiId
    {
        get => GetArgument<TerraformValue<string>>("api_id");
        set => SetArgument("api_id", value);
    }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayId is required")]
    public required TerraformValue<string> GatewayId
    {
        get => GetArgument<TerraformValue<string>>("gateway_id");
        set => SetArgument("gateway_id", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementGatewayApiTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementGatewayApiTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
