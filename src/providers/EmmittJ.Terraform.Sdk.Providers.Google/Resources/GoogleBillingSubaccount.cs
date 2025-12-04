using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_billing_subaccount Terraform resource.
/// Manages a google_billing_subaccount resource.
/// </summary>
public partial class GoogleBillingSubaccount(string name) : TerraformResource("google_billing_subaccount", name)
{
    /// <summary>
    /// The deletion_policy attribute.
    /// </summary>
    public TerraformValue<string>? DeletionPolicy
    {
        get => GetArgument<TerraformValue<string>>("deletion_policy");
        set => SetArgument("deletion_policy", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The master_billing_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterBillingAccount is required")]
    public required TerraformValue<string> MasterBillingAccount
    {
        get => GetRequiredArgument<TerraformValue<string>>("master_billing_account");
        set => SetArgument("master_billing_account", value);
    }

    /// <summary>
    /// The billing_account_id attribute.
    /// </summary>
    public TerraformValue<string> BillingAccountId
        => AsReference("billing_account_id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The open attribute.
    /// </summary>
    public TerraformValue<bool> Open
        => AsReference("open");

}
