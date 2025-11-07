using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_billing_account.
/// </summary>
public class GoogleBillingAccountDataSource : TerraformDataSource
{
    public GoogleBillingAccountDataSource(string name) : base("google_billing_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("currency_code");
        this.DeclareOutput("name");
        this.DeclareOutput("project_ids");
    }

    /// <summary>
    /// The billing_account attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BillingAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_account");
        set => this.WithProperty("billing_account", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The lookup_projects attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LookupProjects
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("lookup_projects");
        set => this.WithProperty("lookup_projects", value);
    }

    /// <summary>
    /// The open attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Open
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("open");
        set => this.WithProperty("open", value);
    }

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    public TerraformExpression CurrencyCode => this["currency_code"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The project_ids attribute.
    /// </summary>
    public TerraformExpression ProjectIds => this["project_ids"];

}
