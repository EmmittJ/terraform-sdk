using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSqlSslCertTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_sql_ssl_cert resource.
/// </summary>
public partial class GoogleSqlSslCert : TerraformResource
{
    public GoogleSqlSslCert(string name) : base("google_sql_ssl_cert", name)
    {
    }

    /// <summary>
    /// The common name to be used in the certificate to identify the client. Constrained to [a-zA-Z.-_ ]+. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommonName is required")]
    [TerraformProperty("common_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CommonName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Cloud SQL instance. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleSqlSslCertTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The actual certificate data for this client certificate.
    /// </summary>
    [TerraformProperty("cert")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Cert { get; }

    /// <summary>
    /// The serial number extracted from the certificate data.
    /// </summary>
    [TerraformProperty("cert_serial_number")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertSerialNumber { get; }

    /// <summary>
    /// The time when the certificate was created in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The time when the certificate expires in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.
    /// </summary>
    [TerraformProperty("expiration_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpirationTime { get; }

    /// <summary>
    /// The private key associated with the client certificate.
    /// </summary>
    [TerraformProperty("private_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateKey { get; }

    /// <summary>
    /// The CA cert of the server this client cert was generated from.
    /// </summary>
    [TerraformProperty("server_ca_cert")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServerCaCert { get; }

    /// <summary>
    /// The SHA1 Fingerprint of the certificate.
    /// </summary>
    [TerraformProperty("sha1_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Sha1Fingerprint { get; }

}
