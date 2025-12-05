using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAutomationVariablesDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermAutomationVariablesDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_automation_variables Terraform data source.
/// Retrieves information about a azurerm_automation_variables.
/// </summary>
public partial class AzurermAutomationVariablesDataSource(string name) : TerraformDataSource("azurerm_automation_variables", name)
{
    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    public required TerraformValue<string> AutomationAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("automation_account_id");
        set => SetArgument("automation_account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The bool attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BoolAttribute
        => CreateReference("bool");

    /// <summary>
    /// The datetime attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Datetime
        => CreateReference("datetime");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Encrypted
        => CreateReference("encrypted");

    /// <summary>
    /// The int attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IntAttribute
        => CreateReference("int");

    /// <summary>
    /// The null attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NullAttribute
        => CreateReference("null");

    /// <summary>
    /// The object attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ObjectAttribute
        => CreateReference("object");

    /// <summary>
    /// The string attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StringAttribute
        => CreateReference("string");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAutomationVariablesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAutomationVariablesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
