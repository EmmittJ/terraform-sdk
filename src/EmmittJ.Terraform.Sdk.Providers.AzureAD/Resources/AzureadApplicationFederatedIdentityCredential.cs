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
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// List of audiences that can appear in the external token. This specifies what should be accepted in the `aud` claim of incoming tokens.
    /// </summary>
    public List<string>? Audiences
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("audiences")?.Value;
        set => this.WithProperty("audiences", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// A description for the federated identity credential
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A unique display name for the federated identity credential
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The URL of the external identity provider, which must match the issuer claim of the external token being exchanged. The combination of the values of issuer and subject must be unique on the app.
    /// </summary>
    public string? Issuer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("issuer")?.Value;
        set => this.WithProperty("issuer", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identifier of the external software workload within the external identity provider. The combination of issuer and subject must be unique on the app.
    /// </summary>
    public string? Subject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subject")?.Value;
        set => this.WithProperty("subject", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A UUID used to uniquely identify this federated identity credential
    /// </summary>
    public TerraformExpression CredentialId => this["credential_id"];

}
