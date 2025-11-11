using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeKeystoresAliasesPkcs12TimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_apigee_keystores_aliases_pkcs12 resource.
/// </summary>
public partial class GoogleApigeeKeystoresAliasesPkcs12 : TerraformResource
{
    public GoogleApigeeKeystoresAliasesPkcs12(string name) : base("google_apigee_keystores_aliases_pkcs12", name)
    {
    }

    /// <summary>
    /// Alias Name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    [TerraformProperty("alias")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Alias { get; set; }

    /// <summary>
    /// Environment associated with the alias
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [TerraformProperty("environment")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Environment { get; set; }

    /// <summary>
    /// Cert content
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "File is required")]
    [TerraformProperty("file")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> File { get; set; }

    /// <summary>
    /// Hash of the pkcs file
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filehash is required")]
    [TerraformProperty("filehash")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Filehash { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Keystore Name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keystore is required")]
    [TerraformProperty("keystore")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Keystore { get; set; }

    /// <summary>
    /// Organization ID associated with the alias
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Password for the Private Key if it&#39;s encrypted
    /// </summary>
    [TerraformProperty("password")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Password { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleApigeeKeystoresAliasesPkcs12TimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Chain of certificates under this alias.
    /// </summary>
    [TerraformProperty("certs_info")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CertsInfo { get; }

    /// <summary>
    /// Optional.Type of Alias
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

}
