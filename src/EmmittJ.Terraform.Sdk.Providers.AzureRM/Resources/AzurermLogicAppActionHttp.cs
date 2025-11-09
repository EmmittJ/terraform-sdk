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
    public TerraformProperty<string>? Body
    {
        get => GetProperty<TerraformProperty<string>>("body");
        set => this.WithProperty("body", value);
    }

    /// <summary>
    /// The headers attribute.
    /// </summary>
    public TerraformMapProperty<string>? Headers
    {
        get => GetProperty<TerraformMapProperty<string>>("headers");
        set => this.WithProperty("headers", value);
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
    /// The queries attribute.
    /// </summary>
    public TerraformMapProperty<string>? Queries
    {
        get => GetProperty<TerraformMapProperty<string>>("queries");
        set => this.WithProperty("queries", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        get => GetProperty<TerraformProperty<string>>("uri");
        set => this.WithProperty("uri", value);
    }

}
