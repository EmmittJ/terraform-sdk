using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationFederatedIdentityCredentialTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("credential_id");
        SetOutput("application_id");
        SetOutput("audiences");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("issuer");
        SetOutput("subject");
    }

    /// <summary>
    /// The resource ID of the application for which this federated identity credential should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_id");
        set => SetProperty("application_id", value);
    }

    /// <summary>
    /// List of audiences that can appear in the external token. This specifies what should be accepted in the `aud` claim of incoming tokens.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Audiences is required")]
    public List<TerraformProperty<string>> Audiences
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("audiences");
        set => SetProperty("audiences", value);
    }

    /// <summary>
    /// A description for the federated identity credential
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// A unique display name for the federated identity credential
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The URL of the external identity provider, which must match the issuer claim of the external token being exchanged. The combination of the values of issuer and subject must be unique on the app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformProperty<string> Issuer
    {
        get => GetRequiredOutput<TerraformProperty<string>>("issuer");
        set => SetProperty("issuer", value);
    }

    /// <summary>
    /// The identifier of the external software workload within the external identity provider. The combination of issuer and subject must be unique on the app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    public required TerraformProperty<string> Subject
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subject");
        set => SetProperty("subject", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationFederatedIdentityCredentialTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// A UUID used to uniquely identify this federated identity credential
    /// </summary>
    public TerraformExpression CredentialId => this["credential_id"];

}
