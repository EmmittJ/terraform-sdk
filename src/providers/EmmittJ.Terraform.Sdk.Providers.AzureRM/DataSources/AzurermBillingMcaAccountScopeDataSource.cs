using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBillingMcaAccountScopeDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_billing_mca_account_scope Terraform data source.
/// Retrieves information about a azurerm_billing_mca_account_scope.
/// </summary>
public partial class AzurermBillingMcaAccountScopeDataSource(string name) : TerraformDataSource("azurerm_billing_mca_account_scope", name)
{
    /// <summary>
    /// The billing_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccountName is required")]
    public required TerraformValue<string> BillingAccountName
    {
        get => new TerraformReference<string>(this, "billing_account_name");
        set => SetArgument("billing_account_name", value);
    }

    /// <summary>
    /// The billing_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingProfileName is required")]
    public required TerraformValue<string> BillingProfileName
    {
        get => new TerraformReference<string>(this, "billing_profile_name");
        set => SetArgument("billing_profile_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The invoice_section_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InvoiceSectionName is required")]
    public required TerraformValue<string> InvoiceSectionName
    {
        get => new TerraformReference<string>(this, "invoice_section_name");
        set => SetArgument("invoice_section_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBillingMcaAccountScopeDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBillingMcaAccountScopeDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
