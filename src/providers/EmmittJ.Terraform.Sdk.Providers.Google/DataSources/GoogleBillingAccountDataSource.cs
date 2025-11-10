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
        SetOutput("currency_code");
        SetOutput("name");
        SetOutput("project_ids");
        SetOutput("billing_account");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("lookup_projects");
        SetOutput("open");
    }

    /// <summary>
    /// The billing_account attribute.
    /// </summary>
    public TerraformProperty<string> BillingAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("billing_account");
        set => SetProperty("billing_account", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
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
    /// The lookup_projects attribute.
    /// </summary>
    public TerraformProperty<bool> LookupProjects
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("lookup_projects");
        set => SetProperty("lookup_projects", value);
    }

    /// <summary>
    /// The open attribute.
    /// </summary>
    public TerraformProperty<bool> Open
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("open");
        set => SetProperty("open", value);
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
