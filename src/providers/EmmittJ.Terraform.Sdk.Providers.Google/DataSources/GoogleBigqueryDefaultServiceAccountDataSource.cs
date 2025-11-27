using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_bigquery_default_service_account Terraform data source.
/// Retrieves information about a google_bigquery_default_service_account.
/// </summary>
public partial class GoogleBigqueryDefaultServiceAccountDataSource(string name) : TerraformDataSource("google_bigquery_default_service_account", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
    }

    /// <summary>
    /// The member attribute.
    /// </summary>
    public TerraformValue<string> Member
    {
        get => new TerraformReference<string>(this, "member");
    }

}
