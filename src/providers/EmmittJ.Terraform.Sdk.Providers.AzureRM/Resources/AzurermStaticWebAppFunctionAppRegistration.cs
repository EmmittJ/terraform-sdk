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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        SetOutput("function_app_id");
        SetOutput("id");
        SetOutput("static_web_app_id");
    }

    /// <summary>
    /// The function_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    public required TerraformProperty<string> FunctionAppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function_app_id");
        set => SetProperty("function_app_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The static_web_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StaticWebAppId is required")]
    public required TerraformProperty<string> StaticWebAppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("static_web_app_id");
        set => SetProperty("static_web_app_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStaticWebAppFunctionAppRegistrationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
