using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_based_auth_properties in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamDirectoryConfigCertificateBasedAuthPropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_authority_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateAuthorityArn { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

}

/// <summary>
/// Block type for service_account_credentials in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamDirectoryConfigServiceAccountCredentialsBlock : ITerraformBlock
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountName { get; set; }

    /// <summary>
    /// The account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountPassword is required")]
    [TerraformPropertyName("account_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountPassword { get; set; }

}

/// <summary>
/// Manages a aws_appstream_directory_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppstreamDirectoryConfig : TerraformResource
{
    public AwsAppstreamDirectoryConfig(string name) : base("aws_appstream_directory_config", name)
    {
    }

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryName is required")]
    [TerraformPropertyName("directory_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DirectoryName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The organizational_unit_distinguished_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationalUnitDistinguishedNames is required")]
    [TerraformPropertyName("organizational_unit_distinguished_names")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? OrganizationalUnitDistinguishedNames { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for certificate_based_auth_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateBasedAuthProperties block(s) allowed")]
    [TerraformPropertyName("certificate_based_auth_properties")]
    public TerraformList<TerraformBlock<AwsAppstreamDirectoryConfigCertificateBasedAuthPropertiesBlock>>? CertificateBasedAuthProperties { get; set; } = new();

    /// <summary>
    /// Block for service_account_credentials.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountCredentials is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServiceAccountCredentials block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccountCredentials block(s) allowed")]
    [TerraformPropertyName("service_account_credentials")]
    public TerraformList<TerraformBlock<AwsAppstreamDirectoryConfigServiceAccountCredentialsBlock>>? ServiceAccountCredentials { get; set; } = new();

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_time");

}
