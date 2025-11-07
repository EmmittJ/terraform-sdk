using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_application_redirect_uris resource.
/// </summary>
public class AzureadApplicationRedirectUris : TerraformResource
{
    public AzureadApplicationRedirectUris(string name) : base("azuread_application_redirect_uris", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The resource ID of the application to which these redirect URIs belong
    /// </summary>
    public TerraformProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
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
    /// A set of redirect URIs
    /// </summary>
    public TerraformProperty<HashSet<string>>? RedirectUris
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("redirect_uris");
        set => this.WithProperty("redirect_uris", value);
    }

    /// <summary>
    /// The type of redirect URIs to assign to the application
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

}
