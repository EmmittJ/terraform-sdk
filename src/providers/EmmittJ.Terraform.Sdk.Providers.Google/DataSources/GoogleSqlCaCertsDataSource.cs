using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_ca_certs.
/// </summary>
public class GoogleSqlCaCertsDataSource : TerraformDataSource
{
    public GoogleSqlCaCertsDataSource(string name) : base("google_sql_ca_certs", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("active_version");
        SetOutput("certs");
        SetOutput("id");
        SetOutput("instance");
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
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
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
    /// The active_version attribute.
    /// </summary>
    public TerraformExpression ActiveVersion => this["active_version"];

    /// <summary>
    /// The certs attribute.
    /// </summary>
    public TerraformExpression Certs => this["certs"];

}
