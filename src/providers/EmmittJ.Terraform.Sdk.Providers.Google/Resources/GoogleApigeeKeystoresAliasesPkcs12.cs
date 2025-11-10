using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeKeystoresAliasesPkcs12TimeoutsBlock : ITerraformBlock
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
/// Manages a google_apigee_keystores_aliases_pkcs12 resource.
/// </summary>
public class GoogleApigeeKeystoresAliasesPkcs12 : TerraformResource
{
    public GoogleApigeeKeystoresAliasesPkcs12(string name) : base("google_apigee_keystores_aliases_pkcs12", name)
    {
    }

    /// <summary>
    /// Alias Name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    [TerraformPropertyName("alias")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Alias { get; set; }

    /// <summary>
    /// Environment associated with the alias
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [TerraformPropertyName("environment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Environment { get; set; }

    /// <summary>
    /// Cert content
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "File is required")]
    [TerraformPropertyName("file")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> File { get; set; }

    /// <summary>
    /// Hash of the pkcs file
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filehash is required")]
    [TerraformPropertyName("filehash")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Filehash { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Keystore Name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keystore is required")]
    [TerraformPropertyName("keystore")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Keystore { get; set; }

    /// <summary>
    /// Organization ID associated with the alias
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformPropertyName("org_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OrgId { get; set; }

    /// <summary>
    /// Password for the Private Key if it&#39;s encrypted
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Password { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "password");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeKeystoresAliasesPkcs12TimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Chain of certificates under this alias.
    /// </summary>
    [TerraformPropertyName("certs_info")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CertsInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "certs_info");

    /// <summary>
    /// Optional.Type of Alias
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
