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
    public TerraformLiteralProperty<string>? ConfigJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("config_json");
        set => this.WithProperty("config_json", value);
    }

    /// <summary>
    /// Should this function be enabled. Defaults to `true`.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The ID of the Function App in which this function should reside.
    /// </summary>
    public TerraformLiteralProperty<string>? FunctionAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_app_id");
        set => this.WithProperty("function_app_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The language the Function is written in.
    /// </summary>
    public TerraformLiteralProperty<string>? Language
    {
        get => GetProperty<TerraformLiteralProperty<string>>("language");
        set => this.WithProperty("language", value);
    }

    /// <summary>
    /// The name of the function.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The test data for the function.
    /// </summary>
    public TerraformLiteralProperty<string>? TestData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("test_data");
        set => this.WithProperty("test_data", value);
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
