using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationCertificateTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_application_certificate resource.
/// </summary>
public class AzureadApplicationCertificate : TerraformResource
{
    public AzureadApplicationCertificate(string name) : base("azuread_application_certificate", name)
    {
    }

    /// <summary>
    /// The resource ID of the application for which this certificate should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformPropertyName("application_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApplicationId { get; set; }

    /// <summary>
    /// Specifies the encoding used for the supplied certificate data
    /// </summary>
    [TerraformPropertyName("encoding")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Encoding { get; set; }

    /// <summary>
    /// The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If omitted, the API will decide a suitable expiry date, which is typically around 2 years from the start date
    /// </summary>
    [TerraformPropertyName("end_date")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EndDate { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "end_date");

    /// <summary>
    /// A relative duration for which the certificate is valid until, for example `240h` (10 days) or `2400h30m`
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("end_date_relative")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndDateRelative { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// A UUID used to uniquely identify this certificate. If omitted, a random UUID will be automatically generated
    /// </summary>
    [TerraformPropertyName("key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_id");

    /// <summary>
    /// The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn&#39;t specified, the current date and time are use
    /// </summary>
    [TerraformPropertyName("start_date")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StartDate { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_date");

    /// <summary>
    /// The type of key/certificate
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER. See also the `encoding` argument
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadApplicationCertificateTimeoutsBlock>? Timeouts { get; set; } = new();

}
