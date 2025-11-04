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
    public string? BillingAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_account")?.Value;
        set => this.WithProperty("billing_account", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The lookup_projects attribute.
    /// </summary>
    public bool? LookupProjects
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("lookup_projects")?.Value;
        set => this.WithProperty("lookup_projects", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The open attribute.
    /// </summary>
    public bool? Open
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("open")?.Value;
        set => this.WithProperty("open", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
