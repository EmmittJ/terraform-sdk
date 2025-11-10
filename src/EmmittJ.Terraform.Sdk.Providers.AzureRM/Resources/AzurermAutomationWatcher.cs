using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationWatcherTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_automation_watcher resource.
/// </summary>
public class AzurermAutomationWatcher : TerraformResource
{
    public AzurermAutomationWatcher(string name) : base("azurerm_automation_watcher", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    public required TerraformProperty<string> AutomationAccountId
    {
        get => GetProperty<TerraformProperty<string>>("automation_account_id");
        set => this.WithProperty("automation_account_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformProperty<string>? Etag
    {
        get => GetProperty<TerraformProperty<string>>("etag");
        set => this.WithProperty("etag", value);
    }

    /// <summary>
    /// The execution_frequency_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionFrequencyInSeconds is required")]
    public required TerraformProperty<double> ExecutionFrequencyInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("execution_frequency_in_seconds");
        set => this.WithProperty("execution_frequency_in_seconds", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The script_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScriptName is required")]
    public required TerraformProperty<string> ScriptName
    {
        get => GetProperty<TerraformProperty<string>>("script_name");
        set => this.WithProperty("script_name", value);
    }

    /// <summary>
    /// The script_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ScriptParameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("script_parameters");
        set => this.WithProperty("script_parameters", value);
    }

    /// <summary>
    /// The script_run_on attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScriptRunOn is required")]
    public required TerraformProperty<string> ScriptRunOn
    {
        get => GetProperty<TerraformProperty<string>>("script_run_on");
        set => this.WithProperty("script_run_on", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationWatcherTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAutomationWatcherTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
