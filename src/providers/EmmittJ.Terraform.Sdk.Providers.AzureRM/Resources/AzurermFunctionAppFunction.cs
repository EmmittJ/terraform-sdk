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
/// Block type for file in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppFunctionFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file";

    /// <summary>
    /// The content of the file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformArgument("content")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The filename of the file to be uploaded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppFunctionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_function_app_function resource.
/// </summary>
public class AzurermFunctionAppFunction : TerraformResource
{
    public AzurermFunctionAppFunction(string name) : base("azurerm_function_app_function", name)
    {
    }

    /// <summary>
    /// The config for this Function in JSON format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigJson is required")]
    [TerraformArgument("config_json")]
    public required TerraformValue<string> ConfigJson
    {
        get => new TerraformReference<string>(this, "config_json");
        set => SetArgument("config_json", value);
    }

    /// <summary>
    /// Should this function be enabled. Defaults to `true`.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The ID of the Function App in which this function should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    [TerraformArgument("function_app_id")]
    public required TerraformValue<string> FunctionAppId
    {
        get => new TerraformReference<string>(this, "function_app_id");
        set => SetArgument("function_app_id", value);
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
    /// The language the Function is written in.
    /// </summary>
    [TerraformArgument("language")]
    public TerraformValue<string>? Language
    {
        get => new TerraformReference<string>(this, "language");
        set => SetArgument("language", value);
    }

    /// <summary>
    /// The name of the function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The test data for the function.
    /// </summary>
    [TerraformArgument("test_data")]
    public TerraformValue<string>? TestData
    {
        get => new TerraformReference<string>(this, "test_data");
        set => SetArgument("test_data", value);
    }

    /// <summary>
    /// Block for file.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("file")]
    public TerraformList<AzurermFunctionAppFunctionFileBlock> File { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermFunctionAppFunctionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The URL of the configuration JSON.
    /// </summary>
    [TerraformArgument("config_url")]
    public TerraformValue<string> ConfigUrl
    {
        get => new TerraformReference<string>(this, "config_url");
    }

    /// <summary>
    /// The invocation URL.
    /// </summary>
    [TerraformArgument("invocation_url")]
    public TerraformValue<string> InvocationUrl
    {
        get => new TerraformReference<string>(this, "invocation_url");
    }

    /// <summary>
    /// The Script root path URL.
    /// </summary>
    [TerraformArgument("script_root_path_url")]
    public TerraformValue<string> ScriptRootPathUrl
    {
        get => new TerraformReference<string>(this, "script_root_path_url");
    }

    /// <summary>
    /// The script URL.
    /// </summary>
    [TerraformArgument("script_url")]
    public TerraformValue<string> ScriptUrl
    {
        get => new TerraformReference<string>(this, "script_url");
    }

    /// <summary>
    /// The URL for the Secrets File.
    /// </summary>
    [TerraformArgument("secrets_file_url")]
    public TerraformValue<string> SecretsFileUrl
    {
        get => new TerraformReference<string>(this, "secrets_file_url");
    }

    /// <summary>
    /// The Test data URL.
    /// </summary>
    [TerraformArgument("test_data_url")]
    public TerraformValue<string> TestDataUrl
    {
        get => new TerraformReference<string>(this, "test_data_url");
    }

    /// <summary>
    /// The function URL.
    /// </summary>
    [TerraformArgument("url")]
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

}
