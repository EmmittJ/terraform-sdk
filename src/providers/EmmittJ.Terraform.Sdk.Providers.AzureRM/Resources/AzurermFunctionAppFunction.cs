using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The filename of the file to be uploaded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
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
        get => new TerraformReference<string>(this, "config_json");
        set => SetArgument("config_json", value);
    }

    /// <summary>
    /// Should this function be enabled. Defaults to `true`.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The ID of the Function App in which this function should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    public required TerraformValue<string> FunctionAppId
    {
        get => new TerraformReference<string>(this, "function_app_id");
        set => SetArgument("function_app_id", value);
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
    /// The language the Function is written in.
    /// </summary>
    public TerraformValue<string>? Language
    {
        get => new TerraformReference<string>(this, "language");
        set => SetArgument("language", value);
    }

    /// <summary>
    /// The name of the function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The test data for the function.
    /// </summary>
    public TerraformValue<string>? TestData
    {
        get => new TerraformReference<string>(this, "test_data");
        set => SetArgument("test_data", value);
    }

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
