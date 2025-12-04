using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermBillingMpaAccountScopeDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermBillingMpaAccountScopeDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_billing_mpa_account_scope Terraform data source.
/// Retrieves information about a azurerm_billing_mpa_account_scope.
/// </summary>
public partial class AzurermBillingMpaAccountScopeDataSource(string name) : TerraformDataSource("azurerm_billing_mpa_account_scope", name)
{
    /// <summary>
    /// The billing_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccountName is required")]
    public required TerraformValue<string> BillingAccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("billing_account_name");
        set => SetArgument("billing_account_name", value);
    }

    /// <summary>
    /// The customer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerName is required")]
    public required TerraformValue<string> CustomerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("customer_name");
        set => SetArgument("customer_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBillingMpaAccountScopeDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBillingMpaAccountScopeDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
