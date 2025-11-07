using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_logic_app_action_http resource.
/// </summary>
public class AzurermLogicAppActionHttp : TerraformResource
{
    public AzurermLogicAppActionHttp(string name) : base("azurerm_logic_app_action_http", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Body
    {
        get => GetProperty<TerraformLiteralProperty<string>>("body");
        set => this.WithProperty("body", value);
    }

    /// <summary>
    /// The headers attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Headers
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("headers");
        set => this.WithProperty("headers", value);
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
    /// The logic_app_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LogicAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logic_app_id");
        set => this.WithProperty("logic_app_id", value);
    }

    /// <summary>
    /// The method attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Method
    {
        get => GetProperty<TerraformLiteralProperty<string>>("method");
        set => this.WithProperty("method", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The queries attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Queries
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("queries");
        set => this.WithProperty("queries", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Uri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("uri");
        set => this.WithProperty("uri", value);
    }

}
