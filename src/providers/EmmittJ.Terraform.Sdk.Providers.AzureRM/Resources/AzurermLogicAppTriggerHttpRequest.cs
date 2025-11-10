using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppTriggerHttpRequestTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("callback_url");
        SetOutput("id");
        SetOutput("logic_app_id");
        SetOutput("method");
        SetOutput("name");
        SetOutput("relative_path");
        SetOutput("schema");
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
    /// The logic_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicAppId is required")]
    public required TerraformProperty<string> LogicAppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("logic_app_id");
        set => SetProperty("logic_app_id", value);
    }

    /// <summary>
    /// The method attribute.
    /// </summary>
    public TerraformProperty<string> Method
    {
        get => GetRequiredOutput<TerraformProperty<string>>("method");
        set => SetProperty("method", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The relative_path attribute.
    /// </summary>
    public TerraformProperty<string> RelativePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("relative_path");
        set => SetProperty("relative_path", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformProperty<string> Schema
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schema");
        set => SetProperty("schema", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogicAppTriggerHttpRequestTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The callback_url attribute.
    /// </summary>
    public TerraformExpression CallbackUrl => this["callback_url"];

}
