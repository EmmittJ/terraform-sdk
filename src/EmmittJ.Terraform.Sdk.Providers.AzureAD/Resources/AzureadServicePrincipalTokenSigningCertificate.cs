using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalTokenSigningCertificateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Manages a azuread_service_principal_token_signing_certificate resource.
/// </summary>
public class AzureadServicePrincipalTokenSigningCertificate : TerraformResource
{
    public AzureadServicePrincipalTokenSigningCertificate(string name) : base("azuread_service_principal_token_signing_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("key_id");
        this.DeclareOutput("start_date");
        this.DeclareOutput("thumbprint");
        this.DeclareOutput("value");
    }

    /// <summary>
    /// A friendly name for the certificate
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). Default is 3 years from current date.
    /// </summary>
    public TerraformProperty<string>? EndDate
    {
        get => GetProperty<TerraformProperty<string>>("end_date");
        set => this.WithProperty("end_date", value);
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
    /// The ID of the service principal for which this certificate should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    public required TerraformProperty<string> ServicePrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_id");
        set => this.WithProperty("service_principal_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadServicePrincipalTokenSigningCertificateTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadServicePrincipalTokenSigningCertificateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// A UUID used to uniquely identify the verify certificate.
    /// </summary>
    public TerraformExpression KeyId => this["key_id"];

    /// <summary>
    /// The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).
    /// </summary>
    public TerraformExpression StartDate => this["start_date"];

    /// <summary>
    /// The thumbprint of the certificate.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

    /// <summary>
    /// The certificate data, which is PEM encoded but does not include the header/footer
    /// </summary>
    public TerraformExpression Value => this["value"];

}
