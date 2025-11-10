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
        this.WithOutput("currency_code");
        this.WithOutput("name");
        this.WithOutput("project_ids");
    }

    /// <summary>
    /// The billing_account attribute.
    /// </summary>
    public TerraformProperty<string>? BillingAccount
    {
        get => GetProperty<TerraformProperty<string>>("billing_account");
        set => this.WithProperty("billing_account", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
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
    /// The lookup_projects attribute.
    /// </summary>
    public TerraformProperty<bool>? LookupProjects
    {
        get => GetProperty<TerraformProperty<bool>>("lookup_projects");
        set => this.WithProperty("lookup_projects", value);
    }

    /// <summary>
    /// The open attribute.
    /// </summary>
    public TerraformProperty<bool>? Open
    {
        get => GetProperty<TerraformProperty<bool>>("open");
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
