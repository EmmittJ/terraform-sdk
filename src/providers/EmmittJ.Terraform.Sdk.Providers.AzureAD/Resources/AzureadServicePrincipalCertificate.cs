using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadServicePrincipalCertificateTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azuread_service_principal_certificate resource.
/// </summary>
public partial class AzureadServicePrincipalCertificate : TerraformResource
{
    public AzureadServicePrincipalCertificate(string name) : base("azuread_service_principal_certificate", name)
    {
    }

    /// <summary>
    /// Specifies the encoding used for the supplied certificate data
    /// </summary>
    [TerraformProperty("encoding")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Encoding { get; set; }

    /// <summary>
    /// The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`)
    /// </summary>
    [TerraformProperty("end_date")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EndDate { get; set; }

    /// <summary>
    /// A relative duration for which the certificate is valid until, for example `240h` (10 days) or `2400h30m`. Valid time units are &amp;quot;ns&amp;quot;, &amp;quot;us&amp;quot; (or &amp;quot;&#181;s&amp;quot;), &amp;quot;ms&amp;quot;, &amp;quot;s&amp;quot;, &amp;quot;m&amp;quot;, &amp;quot;h&amp;quot;
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("end_date_relative")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndDateRelative { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A UUID used to uniquely identify this certificate. If not specified a UUID will be automatically generated
    /// </summary>
    [TerraformProperty("key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// The object ID of the service principal for which this certificate should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    [TerraformProperty("service_principal_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServicePrincipalId { get; set; }

    /// <summary>
    /// The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn&#39;t specified, the current date is used
    /// </summary>
    [TerraformProperty("start_date")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StartDate { get; set; }

    /// <summary>
    /// The type of key/certificate
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzureadServicePrincipalCertificateTimeoutsBlock>? Timeouts { get; set; }

}
