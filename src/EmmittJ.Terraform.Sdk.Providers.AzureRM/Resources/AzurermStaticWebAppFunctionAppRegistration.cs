using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStaticWebAppFunctionAppRegistrationTimeoutsBlock : TerraformBlock
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

}

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
    /// The static_web_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StaticWebAppId is required")]
    public required TerraformProperty<string> StaticWebAppId
    {
        get => GetProperty<TerraformProperty<string>>("static_web_app_id");
        set => this.WithProperty("static_web_app_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStaticWebAppFunctionAppRegistrationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStaticWebAppFunctionAppRegistrationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
