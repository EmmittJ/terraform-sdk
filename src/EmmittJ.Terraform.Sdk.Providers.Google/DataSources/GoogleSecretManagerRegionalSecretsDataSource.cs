using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_secret_manager_regional_secrets.
/// </summary>
public class GoogleSecretManagerRegionalSecretsDataSource : TerraformDataSource
{
    public GoogleSecretManagerRegionalSecretsDataSource(string name) : base("google_secret_manager_regional_secrets", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("secrets");
    }

    /// <summary>
    /// Filter string, adhering to the rules in List-operation filtering (https://cloud.google.com/secret-manager/docs/filtering).
    /// List only secrets matching the filter. If filter is empty, all regional secrets are listed from the specified location.
    /// </summary>
    public TerraformProperty<string>? Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The secrets attribute.
    /// </summary>
    public TerraformExpression Secrets => this["secrets"];

}
