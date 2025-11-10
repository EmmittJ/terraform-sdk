using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for run_after in .
/// Nesting mode: set
/// </summary>
public class AzurermLogicAppActionHttpRunAfterBlock : TerraformBlock
{
    /// <summary>
    /// The action_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionName is required")]
    public required TerraformProperty<string> ActionName
    {
        set => SetProperty("action_name", value);
    }

    /// <summary>
    /// The action_result attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionResult is required")]
    public required TerraformProperty<string> ActionResult
    {
        set => SetProperty("action_result", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppActionHttpTimeoutsBlock : TerraformBlock
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
        SetOutput("body");
        SetOutput("headers");
        SetOutput("id");
        SetOutput("logic_app_id");
        SetOutput("method");
        SetOutput("name");
        SetOutput("queries");
        SetOutput("uri");
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformProperty<string> Body
    {
        get => GetRequiredOutput<TerraformProperty<string>>("body");
        set => SetProperty("body", value);
    }

    /// <summary>
    /// The headers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Headers
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("headers");
        set => SetProperty("headers", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Method is required")]
    public required TerraformProperty<string> Method
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
    /// The queries attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Queries
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("queries");
        set => SetProperty("queries", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("uri");
        set => SetProperty("uri", value);
    }

    /// <summary>
    /// Block for run_after.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermLogicAppActionHttpRunAfterBlock>? RunAfter
    {
        set => SetProperty("run_after", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogicAppActionHttpTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
