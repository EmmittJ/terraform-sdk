using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalCertificateTimeoutsBlock : TerraformBlock
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
/// Manages a azuread_service_principal_certificate resource.
/// </summary>
public class AzureadServicePrincipalCertificate : TerraformResource
{
    public AzureadServicePrincipalCertificate(string name) : base("azuread_service_principal_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Specifies the encoding used for the supplied certificate data
    /// </summary>
    public TerraformProperty<string>? Encoding
    {
        get => GetProperty<TerraformProperty<string>>("encoding");
        set => this.WithProperty("encoding", value);
    }

    /// <summary>
    /// The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`)
    /// </summary>
    public TerraformProperty<string>? EndDate
    {
        get => GetProperty<TerraformProperty<string>>("end_date");
        set => this.WithProperty("end_date", value);
    }

    /// <summary>
    /// A relative duration for which the certificate is valid until, for example `240h` (10 days) or `2400h30m`. Valid time units are &amp;quot;ns&amp;quot;, &amp;quot;us&amp;quot; (or &amp;quot;&#181;s&amp;quot;), &amp;quot;ms&amp;quot;, &amp;quot;s&amp;quot;, &amp;quot;m&amp;quot;, &amp;quot;h&amp;quot;
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? EndDateRelative
    {
        get => GetProperty<TerraformProperty<string>>("end_date_relative");
        set => this.WithProperty("end_date_relative", value);
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
    /// A UUID used to uniquely identify this certificate. If not specified a UUID will be automatically generated
    /// </summary>
    public TerraformProperty<string>? KeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_id");
        set => this.WithProperty("key_id", value);
    }

    /// <summary>
    /// The object ID of the service principal for which this certificate should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    public required TerraformProperty<string> ServicePrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_id");
        set => this.WithProperty("service_principal_id", value);
    }

    /// <summary>
    /// The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn&#39;t specified, the current date is used
    /// </summary>
    public TerraformProperty<string>? StartDate
    {
        get => GetProperty<TerraformProperty<string>>("start_date");
        set => this.WithProperty("start_date", value);
    }

    /// <summary>
    /// The type of key/certificate
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => this.WithProperty("value", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadServicePrincipalCertificateTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadServicePrincipalCertificateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
