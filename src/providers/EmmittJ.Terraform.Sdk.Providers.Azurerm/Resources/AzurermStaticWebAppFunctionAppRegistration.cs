using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStaticWebAppFunctionAppRegistration.
/// Nesting mode: single
/// </summary>
public class AzurermStaticWebAppFunctionAppRegistrationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_static_web_app_function_app_registration Terraform resource.
/// Manages a azurerm_static_web_app_function_app_registration resource.
/// </summary>
public partial class AzurermStaticWebAppFunctionAppRegistration(string name) : TerraformResource("azurerm_static_web_app_function_app_registration", name)
{
    /// <summary>
    /// The function_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    public required TerraformValue<string> FunctionAppId
    {
        get => GetArgument<TerraformValue<string>>("function_app_id");
        set => SetArgument("function_app_id", value);
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
    /// The static_web_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StaticWebAppId is required")]
    public required TerraformValue<string> StaticWebAppId
    {
        get => GetArgument<TerraformValue<string>>("static_web_app_id");
        set => SetArgument("static_web_app_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStaticWebAppFunctionAppRegistrationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStaticWebAppFunctionAppRegistrationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
