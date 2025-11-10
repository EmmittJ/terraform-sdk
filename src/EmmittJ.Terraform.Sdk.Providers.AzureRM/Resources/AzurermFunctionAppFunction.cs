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
        get => GetProperty<TerraformProperty<string>>("content");
        set => WithProperty("content", value);
    }

    /// <summary>
    /// The filename of the file to be uploaded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.DeclareOutput("config_url");
        this.DeclareOutput("invocation_url");
        this.DeclareOutput("script_root_path_url");
        this.DeclareOutput("script_url");
        this.DeclareOutput("secrets_file_url");
        this.DeclareOutput("test_data_url");
        this.DeclareOutput("url");
    }

    /// <summary>
    /// The config for this Function in JSON format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigJson is required")]
    public required TerraformProperty<string> ConfigJson
    {
        get => GetProperty<TerraformProperty<string>>("config_json");
        set => this.WithProperty("config_json", value);
    }

    /// <summary>
    /// Should this function be enabled. Defaults to `true`.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The ID of the Function App in which this function should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    public required TerraformProperty<string> FunctionAppId
    {
        get => GetProperty<TerraformProperty<string>>("function_app_id");
        set => this.WithProperty("function_app_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The language the Function is written in.
    /// </summary>
    public TerraformProperty<string>? Language
    {
        get => GetProperty<TerraformProperty<string>>("language");
        set => this.WithProperty("language", value);
    }

    /// <summary>
    /// The name of the function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The test data for the function.
    /// </summary>
    public TerraformProperty<string>? TestData
    {
        get => GetProperty<TerraformProperty<string>>("test_data");
        set => this.WithProperty("test_data", value);
    }

    /// <summary>
    /// Block for file.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermFunctionAppFunctionFileBlock>? File
    {
        get => GetProperty<List<AzurermFunctionAppFunctionFileBlock>>("file");
        set => this.WithProperty("file", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFunctionAppFunctionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermFunctionAppFunctionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
