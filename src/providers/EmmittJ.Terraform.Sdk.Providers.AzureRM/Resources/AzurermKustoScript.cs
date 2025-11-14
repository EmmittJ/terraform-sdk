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
public class AzurermKustoScriptTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_kusto_script resource.
/// </summary>
public class AzurermKustoScript : TerraformResource
{
    public AzurermKustoScript(string name) : base("azurerm_kusto_script", name)
    {
    }

    /// <summary>
    /// The continue_on_errors_enabled attribute.
    /// </summary>
    [TerraformArgument("continue_on_errors_enabled")]
    public TerraformValue<bool>? ContinueOnErrorsEnabled
    {
        get => new TerraformReference<bool>(this, "continue_on_errors_enabled");
        set => SetArgument("continue_on_errors_enabled", value);
    }

    /// <summary>
    /// The database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseId is required")]
    [TerraformArgument("database_id")]
    public required TerraformValue<string> DatabaseId
    {
        get => new TerraformReference<string>(this, "database_id");
        set => SetArgument("database_id", value);
    }

    /// <summary>
    /// The force_an_update_when_value_changed attribute.
    /// </summary>
    [TerraformArgument("force_an_update_when_value_changed")]
    public TerraformValue<string> ForceAnUpdateWhenValueChanged
    {
        get => new TerraformReference<string>(this, "force_an_update_when_value_changed");
        set => SetArgument("force_an_update_when_value_changed", value);
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
    /// The sas_token attribute.
    /// </summary>
    [TerraformArgument("sas_token")]
    public TerraformValue<string>? SasToken
    {
        get => new TerraformReference<string>(this, "sas_token");
        set => SetArgument("sas_token", value);
    }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    [TerraformArgument("script_content")]
    public TerraformValue<string>? ScriptContent
    {
        get => new TerraformReference<string>(this, "script_content");
        set => SetArgument("script_content", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformArgument("url")]
    public TerraformValue<string>? Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKustoScriptTimeoutsBlock Timeouts { get; set; } = new();

}
