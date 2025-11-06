using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_logic_app_trigger_http_request resource.
/// </summary>
public class AzurermLogicAppTriggerHttpRequest : TerraformResource
{
    public AzurermLogicAppTriggerHttpRequest(string name) : base("azurerm_logic_app_trigger_http_request", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("callback_url");
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
    /// The logic_app_id attribute.
    /// </summary>
    public string? LogicAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logic_app_id")?.Value;
        set => this.WithProperty("logic_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The method attribute.
    /// </summary>
    public string? Method
    {
        get => GetProperty<TerraformLiteralProperty<string>>("method")?.Value;
        set => this.WithProperty("method", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The relative_path attribute.
    /// </summary>
    public string? RelativePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("relative_path")?.Value;
        set => this.WithProperty("relative_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public string? Schema
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schema")?.Value;
        set => this.WithProperty("schema", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The callback_url attribute.
    /// </summary>
    public TerraformExpression CallbackUrl => this["callback_url"];

}
