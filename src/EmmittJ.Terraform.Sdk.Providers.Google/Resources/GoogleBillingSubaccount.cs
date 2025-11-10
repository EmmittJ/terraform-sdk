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
        this.DeclareOutput("billing_account_id");
        this.DeclareOutput("name");
        this.DeclareOutput("open");
    }

    /// <summary>
    /// The deletion_policy attribute.
    /// </summary>
    public TerraformProperty<string>? DeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("deletion_policy");
        set => this.WithProperty("deletion_policy", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The master_billing_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterBillingAccount is required")]
    public required TerraformProperty<string> MasterBillingAccount
    {
        get => GetProperty<TerraformProperty<string>>("master_billing_account");
        set => this.WithProperty("master_billing_account", value);
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
