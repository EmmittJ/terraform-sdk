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
    public string? DeletionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deletion_policy")?.Value;
        set => this.WithProperty("deletion_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The master_billing_account attribute.
    /// </summary>
    public string? MasterBillingAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_billing_account")?.Value;
        set => this.WithProperty("master_billing_account", value == null ? null : new TerraformLiteralProperty<string>(value));
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
