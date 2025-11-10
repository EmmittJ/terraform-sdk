using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for file in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppFunctionFileBlock : TerraformBlock
{
    /// <summary>
    /// The content of the file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformProperty<string> Content
    {
        set => SetProperty("content", value);
    }

    /// <summary>
    /// The filename of the file to be uploaded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppFunctionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_function_app_function resource.
/// </summary>
public class AzurermFunctionAppFunction : TerraformResource
{
    public AzurermFunctionAppFunction(string name) : base("azurerm_function_app_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("config_url");
        SetOutput("invocation_url");
        SetOutput("script_root_path_url");
        SetOutput("script_url");
        SetOutput("secrets_file_url");
        SetOutput("test_data_url");
        SetOutput("url");
        SetOutput("config_json");
        SetOutput("enabled");
        SetOutput("function_app_id");
        SetOutput("id");
        SetOutput("language");
        SetOutput("name");
        SetOutput("test_data");
    }

    /// <summary>
    /// The config for this Function in JSON format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigJson is required")]
    public required TerraformProperty<string> ConfigJson
    {
        get => GetRequiredOutput<TerraformProperty<string>>("config_json");
        set => SetProperty("config_json", value);
    }

    /// <summary>
    /// Should this function be enabled. Defaults to `true`.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The ID of the Function App in which this function should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    public required TerraformProperty<string> FunctionAppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function_app_id");
        set => SetProperty("function_app_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The language the Function is written in.
    /// </summary>
    public TerraformProperty<string> Language
    {
        get => GetRequiredOutput<TerraformProperty<string>>("language");
        set => SetProperty("language", value);
    }

    /// <summary>
    /// The name of the function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The test data for the function.
    /// </summary>
    public TerraformProperty<string> TestData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("test_data");
        set => SetProperty("test_data", value);
    }

    /// <summary>
    /// Block for file.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermFunctionAppFunctionFileBlock>? File
    {
        set => SetProperty("file", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFunctionAppFunctionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The URL of the configuration JSON.
    /// </summary>
    public TerraformExpression ConfigUrl => this["config_url"];

    /// <summary>
    /// The invocation URL.
    /// </summary>
    public TerraformExpression InvocationUrl => this["invocation_url"];

    /// <summary>
    /// The Script root path URL.
    /// </summary>
    public TerraformExpression ScriptRootPathUrl => this["script_root_path_url"];

    /// <summary>
    /// The script URL.
    /// </summary>
    public TerraformExpression ScriptUrl => this["script_url"];

    /// <summary>
    /// The URL for the Secrets File.
    /// </summary>
    public TerraformExpression SecretsFileUrl => this["secrets_file_url"];

    /// <summary>
    /// The Test data URL.
    /// </summary>
    public TerraformExpression TestDataUrl => this["test_data_url"];

    /// <summary>
    /// The function URL.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
