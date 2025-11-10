using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSqlSslCertTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a google_sql_ssl_cert resource.
/// </summary>
public class GoogleSqlSslCert : TerraformResource
{
    public GoogleSqlSslCert(string name) : base("google_sql_ssl_cert", name)
    {
    }

    /// <summary>
    /// The common name to be used in the certificate to identify the client. Constrained to [a-zA-Z.-_ ]+. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommonName is required")]
    [TerraformPropertyName("common_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CommonName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the Cloud SQL instance. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Instance { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSqlSslCertTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The actual certificate data for this client certificate.
    /// </summary>
    [TerraformPropertyName("cert")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Cert => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cert");

    /// <summary>
    /// The serial number extracted from the certificate data.
    /// </summary>
    [TerraformPropertyName("cert_serial_number")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertSerialNumber => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cert_serial_number");

    /// <summary>
    /// The time when the certificate was created in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The time when the certificate expires in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.
    /// </summary>
    [TerraformPropertyName("expiration_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpirationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expiration_time");

    /// <summary>
    /// The private key associated with the client certificate.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_key");

    /// <summary>
    /// The CA cert of the server this client cert was generated from.
    /// </summary>
    [TerraformPropertyName("server_ca_cert")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServerCaCert => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "server_ca_cert");

    /// <summary>
    /// The SHA1 Fingerprint of the certificate.
    /// </summary>
    [TerraformPropertyName("sha1_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sha1Fingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sha1_fingerprint");

}
