using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for run_after in AzurermLogicAppActionHttp.
/// Nesting mode: set
/// </summary>
public class AzurermLogicAppActionHttpRunAfterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "run_after";

    /// <summary>
    /// The action_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionName is required")]
    public required TerraformValue<string> ActionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("action_name");
        set => SetArgument("action_name", value);
    }

    /// <summary>
    /// The action_result attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionResult is required")]
    public required TerraformValue<string> ActionResult
    {
        get => GetRequiredArgument<TerraformValue<string>>("action_result");
        set => SetArgument("action_result", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermLogicAppActionHttp.
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppActionHttpTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_logic_app_action_http Terraform resource.
/// Manages a azurerm_logic_app_action_http resource.
/// </summary>
public partial class AzurermLogicAppActionHttp(string name) : TerraformResource("azurerm_logic_app_action_http", name)
{
    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformValue<string>? Body
    {
        get => GetArgument<TerraformValue<string>>("body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The headers attribute.
    /// </summary>
    public TerraformMap<string>? Headers
    {
        get => GetArgument<TerraformMap<string>>("headers");
        set => SetArgument("headers", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The logic_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicAppId is required")]
    public required TerraformValue<string> LogicAppId
    {
        get => GetRequiredArgument<TerraformValue<string>>("logic_app_id");
        set => SetArgument("logic_app_id", value);
    }

    /// <summary>
    /// The method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Method is required")]
    public required TerraformValue<string> Method
    {
        get => GetRequiredArgument<TerraformValue<string>>("method");
        set => SetArgument("method", value);
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
    /// The queries attribute.
    /// </summary>
    public TerraformMap<string>? Queries
    {
        get => GetArgument<TerraformMap<string>>("queries");
        set => SetArgument("queries", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// RunAfter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermLogicAppActionHttpRunAfterBlock>? RunAfter
    {
        get => GetArgument<TerraformSet<AzurermLogicAppActionHttpRunAfterBlock>>("run_after");
        set => SetArgument("run_after", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogicAppActionHttpTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogicAppActionHttpTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
