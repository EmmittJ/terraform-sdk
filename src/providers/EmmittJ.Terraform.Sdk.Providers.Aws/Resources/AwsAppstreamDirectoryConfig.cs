using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_based_auth_properties in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamDirectoryConfigCertificateBasedAuthPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateAuthorityArn
    {
        set => SetProperty("certificate_authority_arn", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        set => SetProperty("status", value);
    }

}

/// <summary>
/// Block type for service_account_credentials in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamDirectoryConfigServiceAccountCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        set => SetProperty("account_name", value);
    }

    /// <summary>
    /// The account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountPassword is required")]
    public required TerraformProperty<string> AccountPassword
    {
        set => SetProperty("account_password", value);
    }

}

/// <summary>
/// Manages a aws_appstream_directory_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppstreamDirectoryConfig : TerraformResource
{
    public AwsAppstreamDirectoryConfig(string name) : base("aws_appstream_directory_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("created_time");
        SetOutput("directory_name");
        SetOutput("id");
        SetOutput("organizational_unit_distinguished_names");
        SetOutput("region");
    }

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryName is required")]
    public required TerraformProperty<string> DirectoryName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("directory_name");
        set => SetProperty("directory_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The organizational_unit_distinguished_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationalUnitDistinguishedNames is required")]
    public HashSet<TerraformProperty<string>> OrganizationalUnitDistinguishedNames
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("organizational_unit_distinguished_names");
        set => SetProperty("organizational_unit_distinguished_names", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for certificate_based_auth_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateBasedAuthProperties block(s) allowed")]
    public List<AwsAppstreamDirectoryConfigCertificateBasedAuthPropertiesBlock>? CertificateBasedAuthProperties
    {
        set => SetProperty("certificate_based_auth_properties", value);
    }

    /// <summary>
    /// Block for service_account_credentials.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountCredentials is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServiceAccountCredentials block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccountCredentials block(s) allowed")]
    public List<AwsAppstreamDirectoryConfigServiceAccountCredentialsBlock>? ServiceAccountCredentials
    {
        set => SetProperty("service_account_credentials", value);
    }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

}
