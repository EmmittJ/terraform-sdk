using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("bool");
        this.DeclareOutput("datetime");
        this.DeclareOutput("encrypted");
        this.DeclareOutput("int");
        this.DeclareOutput("null");
        this.DeclareOutput("object");
        this.DeclareOutput("string");
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
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
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
