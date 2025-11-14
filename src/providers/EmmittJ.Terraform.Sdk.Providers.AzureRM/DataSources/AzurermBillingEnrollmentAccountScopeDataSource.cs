using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBillingEnrollmentAccountScopeDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_billing_enrollment_account_scope.
/// </summary>
public class AzurermBillingEnrollmentAccountScopeDataSource : TerraformDataSource
{
    public AzurermBillingEnrollmentAccountScopeDataSource(string name) : base("azurerm_billing_enrollment_account_scope", name)
    {
    }

    /// <summary>
    /// The billing_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccountName is required")]
    [TerraformArgument("billing_account_name")]
    public required TerraformValue<string> BillingAccountName
    {
        get => new TerraformReference<string>(this, "billing_account_name");
        set => SetArgument("billing_account_name", value);
    }

    /// <summary>
    /// The enrollment_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnrollmentAccountName is required")]
    [TerraformArgument("enrollment_account_name")]
    public required TerraformValue<string> EnrollmentAccountName
    {
        get => new TerraformReference<string>(this, "enrollment_account_name");
        set => SetArgument("enrollment_account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermBillingEnrollmentAccountScopeDataSourceTimeoutsBlock Timeouts { get; set; } = new();

}
