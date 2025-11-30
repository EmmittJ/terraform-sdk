using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLogicAppTriggerHttpRequest.
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppTriggerHttpRequestTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_logic_app_trigger_http_request Terraform resource.
/// Manages a azurerm_logic_app_trigger_http_request resource.
/// </summary>
public partial class AzurermLogicAppTriggerHttpRequest(string name) : TerraformResource("azurerm_logic_app_trigger_http_request", name)
{
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
    public TerraformValue<string>? Method
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
    /// The relative_path attribute.
    /// </summary>
    public TerraformValue<string>? RelativePath
    {
        get => new TerraformReference<string>(this, "relative_path");
        set => SetArgument("relative_path", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformValue<string> Schema
    {
        get => new TerraformReference<string>(this, "schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// The callback_url attribute.
    /// </summary>
    public TerraformValue<string> CallbackUrl
    {
        get => new TerraformReference<string>(this, "callback_url");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogicAppTriggerHttpRequestTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogicAppTriggerHttpRequestTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
