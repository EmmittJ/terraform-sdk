using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_logging_billing_account_exclusion Terraform resource.
/// Manages a google_logging_billing_account_exclusion resource.
/// </summary>
public partial class GoogleLoggingBillingAccountExclusion(string name) : TerraformResource("google_logging_billing_account_exclusion", name)
{
    /// <summary>
    /// The billing_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccount is required")]
    public required TerraformValue<string> BillingAccount
    {
        get => new TerraformReference<string>(this, "billing_account");
        set => SetArgument("billing_account", value);
    }

    /// <summary>
    /// A human-readable description.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Whether this exclusion rule should be disabled or not. This defaults to false.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// The filter to apply when excluding logs. Only log entries that match the filter are excluded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
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
    /// The name of the logging exclusion.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}
