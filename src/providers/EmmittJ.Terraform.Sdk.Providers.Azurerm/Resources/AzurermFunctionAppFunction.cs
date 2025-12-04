using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for file in AzurermFunctionAppFunction.
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
    public required TerraformValue<string> Content
    {
        get => GetArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The filename of the file to be uploaded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermFunctionAppFunction.
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
/// Represents a azurerm_function_app_function Terraform resource.
/// Manages a azurerm_function_app_function resource.
/// </summary>
public partial class AzurermFunctionAppFunction(string name) : TerraformResource("azurerm_function_app_function", name)
{
    /// <summary>
    /// The config for this Function in JSON format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigJson is required")]
    public required TerraformValue<string> ConfigJson
    {
        get => GetArgument<TerraformValue<string>>("config_json");
        set => SetArgument("config_json", value);
    }

    /// <summary>
    /// Should this function be enabled. Defaults to `true`.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The ID of the Function App in which this function should reside.
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
    /// The language the Function is written in.
    /// </summary>
    public TerraformValue<string>? Language
    {
        get => GetArgument<TerraformValue<string>>("language");
        set => SetArgument("language", value);
    }

    /// <summary>
    /// The name of the function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The test data for the function.
    /// </summary>
    public TerraformValue<string>? TestData
    {
        get => GetArgument<TerraformValue<string>>("test_data");
        set => SetArgument("test_data", value);
    }

    /// <summary>
    /// The URL of the configuration JSON.
    /// </summary>
    public TerraformValue<string> ConfigUrl
        => AsReference("config_url");

    /// <summary>
    /// The invocation URL.
    /// </summary>
    public TerraformValue<string> InvocationUrl
        => AsReference("invocation_url");

    /// <summary>
    /// The Script root path URL.
    /// </summary>
    public TerraformValue<string> ScriptRootPathUrl
        => AsReference("script_root_path_url");

    /// <summary>
    /// The script URL.
    /// </summary>
    public TerraformValue<string> ScriptUrl
        => AsReference("script_url");

    /// <summary>
    /// The URL for the Secrets File.
    /// </summary>
    public TerraformValue<string> SecretsFileUrl
        => AsReference("secrets_file_url");

    /// <summary>
    /// The Test data URL.
    /// </summary>
    public TerraformValue<string> TestDataUrl
        => AsReference("test_data_url");

    /// <summary>
    /// The function URL.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermFunctionAppFunctionFileBlock>? File
    {
        get => GetArgument<TerraformList<AzurermFunctionAppFunctionFileBlock>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFunctionAppFunctionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFunctionAppFunctionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
