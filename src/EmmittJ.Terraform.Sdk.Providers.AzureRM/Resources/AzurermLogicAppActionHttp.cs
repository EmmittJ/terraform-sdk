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
    public string? Body
    {
        get => GetProperty<TerraformLiteralProperty<string>>("body")?.Value;
        set => this.WithProperty("body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The headers attribute.
    /// </summary>
    public Dictionary<string, string>? Headers
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("headers")?.Value;
        set => this.WithProperty("headers", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The queries attribute.
    /// </summary>
    public Dictionary<string, string>? Queries
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("queries")?.Value;
        set => this.WithProperty("queries", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public string? Uri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("uri")?.Value;
        set => this.WithProperty("uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
