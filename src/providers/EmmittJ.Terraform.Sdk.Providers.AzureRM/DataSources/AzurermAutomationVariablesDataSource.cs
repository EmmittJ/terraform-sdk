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
        set => SetProperty("read", value);
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
        SetOutput("bool");
        SetOutput("datetime");
        SetOutput("encrypted");
        SetOutput("int");
        SetOutput("null");
        SetOutput("object");
        SetOutput("string");
        SetOutput("automation_account_id");
        SetOutput("id");
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    public required TerraformProperty<string> AutomationAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("automation_account_id");
        set => SetProperty("automation_account_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationVariablesDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
