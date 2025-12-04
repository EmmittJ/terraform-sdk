using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAutomationVariableBoolDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermAutomationVariableBoolDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_automation_variable_bool Terraform data source.
/// Retrieves information about a azurerm_automation_variable_bool.
/// </summary>
public partial class AzurermAutomationVariableBoolDataSource(string name) : TerraformDataSource("azurerm_automation_variable_bool", name)
{
    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    public required TerraformValue<string> AutomationAccountName
    {
        get => GetArgument<TerraformValue<string>>("automation_account_name");
        set => SetArgument("automation_account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
        => AsReference("encrypted");

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<bool> Value
        => AsReference("value");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAutomationVariableBoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAutomationVariableBoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
