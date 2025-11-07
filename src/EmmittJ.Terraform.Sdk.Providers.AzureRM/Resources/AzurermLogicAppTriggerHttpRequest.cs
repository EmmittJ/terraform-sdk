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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The logic_app_id attribute.
    /// </summary>
    public TerraformProperty<string>? LogicAppId
    {
        get => GetProperty<TerraformProperty<string>>("logic_app_id");
        set => this.WithProperty("logic_app_id", value);
    }

    /// <summary>
    /// The method attribute.
    /// </summary>
    public TerraformProperty<string>? Method
    {
        get => GetProperty<TerraformProperty<string>>("method");
        set => this.WithProperty("method", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The relative_path attribute.
    /// </summary>
    public TerraformProperty<string>? RelativePath
    {
        get => GetProperty<TerraformProperty<string>>("relative_path");
        set => this.WithProperty("relative_path", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformProperty<string>? Schema
    {
        get => GetProperty<TerraformProperty<string>>("schema");
        set => this.WithProperty("schema", value);
    }

    /// <summary>
    /// The callback_url attribute.
    /// </summary>
    public TerraformExpression CallbackUrl => this["callback_url"];

}
