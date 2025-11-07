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
    public TerraformProperty<string>? AutomationAccountId
    {
        get => GetProperty<TerraformProperty<string>>("automation_account_id");
        set => this.WithProperty("automation_account_id", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformProperty<string>? Duration
    {
        get => GetProperty<TerraformProperty<string>>("duration");
        set => this.WithProperty("duration", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The non_azure_computer_names attribute.
    /// </summary>
    public TerraformProperty<List<string>>? NonAzureComputerNames
    {
        get => GetProperty<TerraformProperty<List<string>>>("non_azure_computer_names");
        set => this.WithProperty("non_azure_computer_names", value);
    }

    /// <summary>
    /// The virtual_machine_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? VirtualMachineIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("virtual_machine_ids");
        set => this.WithProperty("virtual_machine_ids", value);
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
