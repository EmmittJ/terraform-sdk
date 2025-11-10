using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalCertificateTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a azuread_service_principal_certificate resource.
/// </summary>
public class AzureadServicePrincipalCertificate : TerraformResource
{
    public AzureadServicePrincipalCertificate(string name) : base("azuread_service_principal_certificate", name)
    {
    }

    /// <summary>
    /// Specifies the encoding used for the supplied certificate data
    /// </summary>
    [TerraformPropertyName("encoding")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Encoding { get; set; }

    /// <summary>
    /// The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`)
    /// </summary>
    [TerraformPropertyName("end_date")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EndDate { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "end_date");

    /// <summary>
    /// A relative duration for which the certificate is valid until, for example `240h` (10 days) or `2400h30m`. Valid time units are &amp;quot;ns&amp;quot;, &amp;quot;us&amp;quot; (or &amp;quot;&#181;s&amp;quot;), &amp;quot;ms&amp;quot;, &amp;quot;s&amp;quot;, &amp;quot;m&amp;quot;, &amp;quot;h&amp;quot;
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
    /// A UUID used to uniquely identify this certificate. If not specified a UUID will be automatically generated
    /// </summary>
    [TerraformPropertyName("key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_id");

    /// <summary>
    /// The object ID of the service principal for which this certificate should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    [TerraformPropertyName("service_principal_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServicePrincipalId { get; set; }

    /// <summary>
    /// The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn&#39;t specified, the current date is used
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
    /// The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER
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
    public TerraformBlock<AzureadServicePrincipalCertificateTimeoutsBlock>? Timeouts { get; set; } = new();

}
