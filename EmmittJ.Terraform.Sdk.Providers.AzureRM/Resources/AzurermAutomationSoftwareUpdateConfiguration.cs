using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_automation_software_update_configuration resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermAutomationSoftwareUpdateConfiguration : TerraformResource
{
    public AzurermAutomationSoftwareUpdateConfiguration(string name) : base("azurerm_automation_software_update_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("error_code");
        this.DeclareOutput("error_message");
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
    /// The duration attribute.
    /// </summary>
    public string? Duration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("duration")?.Value;
        set => this.WithProperty("duration", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The non_azure_computer_names attribute.
    /// </summary>
    public List<string>? NonAzureComputerNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("non_azure_computer_names")?.Value;
        set => this.WithProperty("non_azure_computer_names", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The virtual_machine_ids attribute.
    /// </summary>
    public List<string>? VirtualMachineIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("virtual_machine_ids")?.Value;
        set => this.WithProperty("virtual_machine_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    public TerraformExpression ErrorCode => this["error_code"];

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformExpression ErrorMessage => this["error_message"];

}
