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
        get => new TerraformReference<string>(this, "action_name");
        set => SetArgument("action_name", value);
    }

    /// <summary>
    /// The action_result attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionResult is required")]
    public required TerraformValue<string> ActionResult
    {
        get => new TerraformReference<string>(this, "action_result");
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
        get => new TerraformReference<string>(this, "body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The headers attribute.
    /// </summary>
    public TerraformMap<string>? Headers
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "headers").ResolveNodes(ctx));
        set => SetArgument("headers", value);
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
    /// The logic_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicAppId is required")]
    public required TerraformValue<string> LogicAppId
    {
        get => new TerraformReference<string>(this, "logic_app_id");
        set => SetArgument("logic_app_id", value);
    }

    /// <summary>
    /// The method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Method is required")]
    public required TerraformValue<string> Method
    {
        get => new TerraformReference<string>(this, "method");
        set => SetArgument("method", value);
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
    /// The queries attribute.
    /// </summary>
    public TerraformMap<string>? Queries
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "queries").ResolveNodes(ctx));
        set => SetArgument("queries", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
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
