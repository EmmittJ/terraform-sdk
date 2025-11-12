using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_based_auth_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppstreamDirectoryConfigCertificateBasedAuthPropertiesBlock() : TerraformBlock("certificate_based_auth_properties")
{
    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_authority_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateAuthorityArn { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

}

/// <summary>
/// Block type for service_account_credentials in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppstreamDirectoryConfigServiceAccountCredentialsBlock() : TerraformBlock("service_account_credentials")
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountPassword is required")]
    [TerraformProperty("account_password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountPassword { get; set; }

}

/// <summary>
/// Manages a aws_appstream_directory_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAppstreamDirectoryConfig : TerraformResource
{
    public AwsAppstreamDirectoryConfig(string name) : base("aws_appstream_directory_config", name)
    {
    }

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryName is required")]
    [TerraformProperty("directory_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DirectoryName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The organizational_unit_distinguished_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationalUnitDistinguishedNames is required")]
    [TerraformProperty("organizational_unit_distinguished_names")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> OrganizationalUnitDistinguishedNames { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for certificate_based_auth_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateBasedAuthProperties block(s) allowed")]
    [TerraformProperty("certificate_based_auth_properties")]
    public TerraformList<AwsAppstreamDirectoryConfigCertificateBasedAuthPropertiesBlock> CertificateBasedAuthProperties { get; set; } = new();

    /// <summary>
    /// Block for service_account_credentials.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountCredentials is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServiceAccountCredentials block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccountCredentials block(s) allowed")]
    [TerraformProperty("service_account_credentials")]
    public required TerraformList<AwsAppstreamDirectoryConfigServiceAccountCredentialsBlock> ServiceAccountCredentials { get; set; } = new();

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformProperty("created_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedTime { get; }

}
