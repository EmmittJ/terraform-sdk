using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_accounts.
/// </summary>
public class GoogleServiceAccountsDataSource : TerraformDataSource
{
    public GoogleServiceAccountsDataSource(string name) : base("google_service_accounts", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("accounts");
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
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        get => GetProperty<TerraformProperty<string>>("prefix");
        set => this.WithProperty("prefix", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The regex attribute.
    /// </summary>
    public TerraformProperty<string>? Regex
    {
        get => GetProperty<TerraformProperty<string>>("regex");
        set => this.WithProperty("regex", value);
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public TerraformExpression Accounts => this["accounts"];

}
