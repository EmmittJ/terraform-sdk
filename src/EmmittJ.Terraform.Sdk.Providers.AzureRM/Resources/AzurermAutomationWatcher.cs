using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<string>? AutomationAccountId
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
    public TerraformProperty<double>? ExecutionFrequencyInSeconds
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The script_name attribute.
    /// </summary>
    public TerraformProperty<string>? ScriptName
    {
        get => GetProperty<TerraformProperty<string>>("script_name");
        set => this.WithProperty("script_name", value);
    }

    /// <summary>
    /// The script_parameters attribute.
    /// </summary>
    public TerraformMapProperty<string>? ScriptParameters
    {
        get => GetProperty<TerraformMapProperty<string>>("script_parameters");
        set => this.WithProperty("script_parameters", value);
    }

    /// <summary>
    /// The script_run_on attribute.
    /// </summary>
    public TerraformProperty<string>? ScriptRunOn
    {
        get => GetProperty<TerraformProperty<string>>("script_run_on");
        set => this.WithProperty("script_run_on", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
