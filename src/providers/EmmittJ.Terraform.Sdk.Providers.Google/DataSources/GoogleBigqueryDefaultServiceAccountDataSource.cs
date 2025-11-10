using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_bigquery_default_service_account.
/// </summary>
public class GoogleBigqueryDefaultServiceAccountDataSource : TerraformDataSource
{
    public GoogleBigqueryDefaultServiceAccountDataSource(string name) : base("google_bigquery_default_service_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("email");
        SetOutput("member");
        SetOutput("id");
        SetOutput("project");
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformExpression Email => this["email"];

    /// <summary>
    /// The member attribute.
    /// </summary>
    public TerraformExpression Member => this["member"];

}
