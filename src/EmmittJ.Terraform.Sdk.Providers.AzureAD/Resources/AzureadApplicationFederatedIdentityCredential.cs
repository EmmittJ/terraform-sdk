using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_application_federated_identity_credential resource.
/// </summary>
public class AzureadApplicationFederatedIdentityCredential : TerraformResource
{
    public AzureadApplicationFederatedIdentityCredential(string name) : base("azuread_application_federated_identity_credential", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("credential_id");
    }

    /// <summary>
    /// The resource ID of the application for which this federated identity credential should be created
    /// </summary>
    public TerraformProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// List of audiences that can appear in the external token. This specifies what should be accepted in the `aud` claim of incoming tokens.
    /// </summary>
    public TerraformProperty<List<string>>? Audiences
    {
        get => GetProperty<TerraformProperty<List<string>>>("audiences");
        set => this.WithProperty("audiences", value);
    }

    /// <summary>
    /// A description for the federated identity credential
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// A unique display name for the federated identity credential
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The URL of the external identity provider, which must match the issuer claim of the external token being exchanged. The combination of the values of issuer and subject must be unique on the app.
    /// </summary>
    public TerraformProperty<string>? Issuer
    {
        get => GetProperty<TerraformProperty<string>>("issuer");
        set => this.WithProperty("issuer", value);
    }

    /// <summary>
    /// The identifier of the external software workload within the external identity provider. The combination of issuer and subject must be unique on the app.
    /// </summary>
    public TerraformProperty<string>? Subject
    {
        get => GetProperty<TerraformProperty<string>>("subject");
        set => this.WithProperty("subject", value);
    }

    /// <summary>
    /// A UUID used to uniquely identify this federated identity credential
    /// </summary>
    public TerraformExpression CredentialId => this["credential_id"];

}
