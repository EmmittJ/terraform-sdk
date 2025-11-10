using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_secret_manager_secrets.
/// </summary>
public class GoogleSecretManagerSecretsDataSource : TerraformDataSource
{
    public GoogleSecretManagerSecretsDataSource(string name) : base("google_secret_manager_secrets", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("secrets");
        SetOutput("filter");
        SetOutput("id");
        SetOutput("project");
    }

    /// <summary>
    /// Filter string, adhering to the rules in List-operation filtering (https://cloud.google.com/secret-manager/docs/filtering).
    /// List only secrets matching the filter. If filter is empty, all secrets are listed.
    /// </summary>
    public TerraformProperty<string> Filter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter");
        set => SetProperty("filter", value);
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
    /// The secrets attribute.
    /// </summary>
    public TerraformExpression Secrets => this["secrets"];

}
