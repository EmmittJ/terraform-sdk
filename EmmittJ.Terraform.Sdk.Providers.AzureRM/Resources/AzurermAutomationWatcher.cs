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
    public string? AutomationAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_account_id")?.Value;
        set => this.WithProperty("automation_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public string? Etag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("etag")?.Value;
        set => this.WithProperty("etag", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The execution_frequency_in_seconds attribute.
    /// </summary>
    public double? ExecutionFrequencyInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("execution_frequency_in_seconds")?.Value;
        set => this.WithProperty("execution_frequency_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The script_name attribute.
    /// </summary>
    public string? ScriptName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("script_name")?.Value;
        set => this.WithProperty("script_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The script_parameters attribute.
    /// </summary>
    public Dictionary<string, string>? ScriptParameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("script_parameters")?.Value;
        set => this.WithProperty("script_parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The script_run_on attribute.
    /// </summary>
    public string? ScriptRunOn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("script_run_on")?.Value;
        set => this.WithProperty("script_run_on", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
