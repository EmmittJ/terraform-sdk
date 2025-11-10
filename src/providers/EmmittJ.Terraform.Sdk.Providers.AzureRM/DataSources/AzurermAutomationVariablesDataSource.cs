using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationVariablesDataSourceTimeoutsBlock : TerraformBlock
{
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
/// Retrieves information about a azurerm_automation_variables.
/// </summary>
public class AzurermAutomationVariablesDataSource : TerraformDataSource
{
    public AzurermAutomationVariablesDataSource(string name) : base("azurerm_automation_variables", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("bool");
        this.WithOutput("datetime");
        this.WithOutput("encrypted");
        this.WithOutput("int");
        this.WithOutput("null");
        this.WithOutput("object");
        this.WithOutput("string");
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    public required TerraformProperty<string> AutomationAccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("automation_account_id");
        set => this.WithProperty("automation_account_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationVariablesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAutomationVariablesDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The bool attribute.
    /// </summary>
    public TerraformExpression Bool => this["bool"];

    /// <summary>
    /// The datetime attribute.
    /// </summary>
    public TerraformExpression Datetime => this["datetime"];

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformExpression Encrypted => this["encrypted"];

    /// <summary>
    /// The int attribute.
    /// </summary>
    public TerraformExpression Int => this["int"];

    /// <summary>
    /// The null attribute.
    /// </summary>
    public TerraformExpression Null => this["null"];

    /// <summary>
    /// The object attribute.
    /// </summary>
    public TerraformExpression Object => this["object"];

    /// <summary>
    /// The string attribute.
    /// </summary>
    public TerraformExpression String => this["string"];

}
