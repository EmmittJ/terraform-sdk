using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_billing_account Terraform data source.
/// Retrieves information about a google_billing_account.
/// </summary>
public partial class GoogleBillingAccountDataSource(string name) : TerraformDataSource("google_billing_account", name)
{
    /// <summary>
    /// The billing_account attribute.
    /// </summary>
    public TerraformValue<string>? BillingAccount
    {
        get => GetArgument<TerraformValue<string>>("billing_account");
        set => SetArgument("billing_account", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name") ?? AsReference("display_name");
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
    /// The lookup_projects attribute.
    /// </summary>
    public TerraformValue<bool>? LookupProjects
    {
        get => GetArgument<TerraformValue<bool>>("lookup_projects");
        set => SetArgument("lookup_projects", value);
    }

    /// <summary>
    /// The open attribute.
    /// </summary>
    public TerraformValue<bool> Open
    {
        get => GetArgument<TerraformValue<bool>>("open") ?? AsReference("open");
        set => SetArgument("open", value);
    }

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    public TerraformValue<string> CurrencyCode
        => AsReference("currency_code");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The project_ids attribute.
    /// </summary>
    public TerraformSet<string> ProjectIds
        => AsReference("project_ids");

}
