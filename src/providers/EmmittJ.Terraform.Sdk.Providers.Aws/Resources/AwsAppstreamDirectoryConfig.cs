using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_based_auth_properties in AwsAppstreamDirectoryConfig.
/// Nesting mode: list
/// </summary>
public class AwsAppstreamDirectoryConfigCertificateBasedAuthPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_based_auth_properties";

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    public TerraformValue<string>? CertificateAuthorityArn
    {
        get => GetArgument<TerraformValue<string>>("certificate_authority_arn");
        set => SetArgument("certificate_authority_arn", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}


/// <summary>
/// Block type for service_account_credentials in AwsAppstreamDirectoryConfig.
/// Nesting mode: list
/// </summary>
public class AwsAppstreamDirectoryConfigServiceAccountCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_account_credentials";

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => GetArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The account_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountPassword is required")]
    public required TerraformValue<string> AccountPassword
    {
        get => GetArgument<TerraformValue<string>>("account_password");
        set => SetArgument("account_password", value);
    }

}


/// <summary>
/// Represents a aws_appstream_directory_config Terraform resource.
/// Manages a aws_appstream_directory_config resource.
/// </summary>
public partial class AwsAppstreamDirectoryConfig(string name) : TerraformResource("aws_appstream_directory_config", name)
{
    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryName is required")]
    public required TerraformValue<string> DirectoryName
    {
        get => GetArgument<TerraformValue<string>>("directory_name");
        set => SetArgument("directory_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The organizational_unit_distinguished_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationalUnitDistinguishedNames is required")]
    public required TerraformSet<string> OrganizationalUnitDistinguishedNames
    {
        get => GetArgument<TerraformSet<string>>("organizational_unit_distinguished_names");
        set => SetArgument("organizational_unit_distinguished_names", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
        => AsReference("created_time");

    /// <summary>
    /// CertificateBasedAuthProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateBasedAuthProperties block(s) allowed")]
    public TerraformList<AwsAppstreamDirectoryConfigCertificateBasedAuthPropertiesBlock>? CertificateBasedAuthProperties
    {
        get => GetArgument<TerraformList<AwsAppstreamDirectoryConfigCertificateBasedAuthPropertiesBlock>>("certificate_based_auth_properties");
        set => SetArgument("certificate_based_auth_properties", value);
    }

    /// <summary>
    /// ServiceAccountCredentials block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountCredentials is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServiceAccountCredentials block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccountCredentials block(s) allowed")]
    public required TerraformList<AwsAppstreamDirectoryConfigServiceAccountCredentialsBlock> ServiceAccountCredentials
    {
        get => GetRequiredArgument<TerraformList<AwsAppstreamDirectoryConfigServiceAccountCredentialsBlock>>("service_account_credentials");
        set => SetArgument("service_account_credentials", value);
    }

}
