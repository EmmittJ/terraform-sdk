using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_billing_account_iam_policy Terraform resource.
/// Manages a google_billing_account_iam_policy resource.
/// </summary>
public partial class GoogleBillingAccountIamPolicy(string name) : TerraformResource("google_billing_account_iam_policy", name)
{
    /// <summary>
    /// The billing_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccountId is required")]
    public required TerraformValue<string> BillingAccountId
    {
        get => new TerraformReference<string>(this, "billing_account_id");
        set => SetArgument("billing_account_id", value);
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
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformValue<string> PolicyData
    {
        get => new TerraformReference<string>(this, "policy_data");
        set => SetArgument("policy_data", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

}
