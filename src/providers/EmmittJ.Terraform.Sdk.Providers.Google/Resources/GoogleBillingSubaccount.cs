using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_billing_subaccount resource.
/// </summary>
public class GoogleBillingSubaccount : TerraformResource
{
    public GoogleBillingSubaccount(string name) : base("google_billing_subaccount", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("billing_account_id");
        SetOutput("name");
        SetOutput("open");
        SetOutput("deletion_policy");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("master_billing_account");
    }

    /// <summary>
    /// The deletion_policy attribute.
    /// </summary>
    public TerraformProperty<string> DeletionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deletion_policy");
        set => SetProperty("deletion_policy", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The master_billing_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterBillingAccount is required")]
    public required TerraformProperty<string> MasterBillingAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_billing_account");
        set => SetProperty("master_billing_account", value);
    }

    /// <summary>
    /// The billing_account_id attribute.
    /// </summary>
    public TerraformExpression BillingAccountId => this["billing_account_id"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The open attribute.
    /// </summary>
    public TerraformExpression Open => this["open"];

}
