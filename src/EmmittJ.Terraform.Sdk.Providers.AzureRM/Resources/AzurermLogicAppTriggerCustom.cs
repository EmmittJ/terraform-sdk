using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_logic_app_trigger_custom resource.
/// </summary>
public class AzurermLogicAppTriggerCustom : TerraformResource
{
    public AzurermLogicAppTriggerCustom(string name) : base("azurerm_logic_app_trigger_custom", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("callback_url");
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The callback_url attribute.
    /// </summary>
    public TerraformExpression CallbackUrl => this["callback_url"];

}
