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
        get => GetProperty<TerraformProperty<string>>("certificate_authority_arn");
        set => WithProperty("certificate_authority_arn", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("account_name");
        set => WithProperty("account_name", value);
    }

    /// <summary>
    /// The account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountPassword is required")]
    public required TerraformProperty<string> AccountPassword
    {
        get => GetRequiredProperty<TerraformProperty<string>>("account_password");
        set => WithProperty("account_password", value);
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
        this.WithOutput("created_time");
    }

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryName is required")]
    public required TerraformProperty<string> DirectoryName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("directory_name");
        set => this.WithProperty("directory_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The organizational_unit_distinguished_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationalUnitDistinguishedNames is required")]
    public HashSet<TerraformProperty<string>>? OrganizationalUnitDistinguishedNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("organizational_unit_distinguished_names");
        set => this.WithProperty("organizational_unit_distinguished_names", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for certificate_based_auth_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateBasedAuthProperties block(s) allowed")]
    public List<AwsAppstreamDirectoryConfigCertificateBasedAuthPropertiesBlock>? CertificateBasedAuthProperties
    {
        get => GetProperty<List<AwsAppstreamDirectoryConfigCertificateBasedAuthPropertiesBlock>>("certificate_based_auth_properties");
        set => this.WithProperty("certificate_based_auth_properties", value);
    }

    /// <summary>
    /// Block for service_account_credentials.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServiceAccountCredentials block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccountCredentials block(s) allowed")]
    public List<AwsAppstreamDirectoryConfigServiceAccountCredentialsBlock>? ServiceAccountCredentials
    {
        get => GetProperty<List<AwsAppstreamDirectoryConfigServiceAccountCredentialsBlock>>("service_account_credentials");
        set => this.WithProperty("service_account_credentials", value);
    }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

}
