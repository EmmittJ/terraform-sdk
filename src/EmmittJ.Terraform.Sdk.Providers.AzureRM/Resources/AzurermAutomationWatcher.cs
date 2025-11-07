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
    public TerraformLiteralProperty<string>? AutomationAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_account_id");
        set => this.WithProperty("automation_account_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Etag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("etag");
        set => this.WithProperty("etag", value);
    }

    /// <summary>
    /// The execution_frequency_in_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ExecutionFrequencyInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("execution_frequency_in_seconds");
        set => this.WithProperty("execution_frequency_in_seconds", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The script_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScriptName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("script_name");
        set => this.WithProperty("script_name", value);
    }

    /// <summary>
    /// The script_parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? ScriptParameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("script_parameters");
        set => this.WithProperty("script_parameters", value);
    }

    /// <summary>
    /// The script_run_on attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScriptRunOn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("script_run_on");
        set => this.WithProperty("script_run_on", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
