using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_static_web_app_function_app_registration resource.
/// </summary>
public class AzurermStaticWebAppFunctionAppRegistration : TerraformResource
{
    public AzurermStaticWebAppFunctionAppRegistration(string name) : base("azurerm_static_web_app_function_app_registration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The function_app_id attribute.
    /// </summary>
    public TerraformProperty<string>? FunctionAppId
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
    /// The static_web_app_id attribute.
    /// </summary>
    public TerraformProperty<string>? StaticWebAppId
    {
        get => GetProperty<TerraformProperty<string>>("static_web_app_id");
        set => this.WithProperty("static_web_app_id", value);
    }

}
