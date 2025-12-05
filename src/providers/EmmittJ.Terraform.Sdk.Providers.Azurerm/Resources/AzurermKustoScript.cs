using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKustoScript.
/// Nesting mode: single
/// </summary>
public class AzurermKustoScriptTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_kusto_script Terraform resource.
/// Manages a azurerm_kusto_script resource.
/// </summary>
public partial class AzurermKustoScript(string name) : TerraformResource("azurerm_kusto_script", name)
{
    /// <summary>
    /// The continue_on_errors_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ContinueOnErrorsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("continue_on_errors_enabled");
        set => SetArgument("continue_on_errors_enabled", value);
    }

    /// <summary>
    /// The database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseId is required")]
    public required TerraformValue<string> DatabaseId
    {
        get => GetRequiredArgument<TerraformValue<string>>("database_id");
        set => SetArgument("database_id", value);
    }

    /// <summary>
    /// The force_an_update_when_value_changed attribute.
    /// </summary>
    public TerraformValue<string> ForceAnUpdateWhenValueChanged
    {
        get => GetArgument<TerraformValue<string>>("force_an_update_when_value_changed") ?? CreateReference("force_an_update_when_value_changed");
        set => SetArgument("force_an_update_when_value_changed", value);
    }

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
    /// The sas_token attribute.
    /// </summary>
    public TerraformValue<string>? SasToken
    {
        get => GetArgument<TerraformValue<string>>("sas_token");
        set => SetArgument("sas_token", value);
    }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    public TerraformValue<string>? ScriptContent
    {
        get => GetArgument<TerraformValue<string>>("script_content");
        set => SetArgument("script_content", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKustoScriptTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKustoScriptTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
