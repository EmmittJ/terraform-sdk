using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public string? ConfigJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("config_json")?.Value;
        set => this.WithProperty("config_json", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Should this function be enabled. Defaults to `true`.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ID of the Function App in which this function should reside.
    /// </summary>
    public string? FunctionAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_app_id")?.Value;
        set => this.WithProperty("function_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The language the Function is written in.
    /// </summary>
    public string? Language
    {
        get => GetProperty<TerraformLiteralProperty<string>>("language")?.Value;
        set => this.WithProperty("language", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the function.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The test data for the function.
    /// </summary>
    public string? TestData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("test_data")?.Value;
        set => this.WithProperty("test_data", value == null ? null : new TerraformLiteralProperty<string>(value));
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
