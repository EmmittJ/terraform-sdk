using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for as2_config in .
/// Nesting mode: list
/// </summary>
public class AwsTransferConnectorAs2ConfigBlock : TerraformBlock
{
    /// <summary>
    /// The compression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compression is required")]
    public required TerraformProperty<string> Compression
    {
        get => GetRequiredProperty<TerraformProperty<string>>("compression");
        set => WithProperty("compression", value);
    }

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionAlgorithm is required")]
    public required TerraformProperty<string> EncryptionAlgorithm
    {
        get => GetRequiredProperty<TerraformProperty<string>>("encryption_algorithm");
        set => WithProperty("encryption_algorithm", value);
    }

    /// <summary>
    /// The local_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalProfileId is required")]
    public required TerraformProperty<string> LocalProfileId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("local_profile_id");
        set => WithProperty("local_profile_id", value);
    }

    /// <summary>
    /// The mdn_response attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MdnResponse is required")]
    public required TerraformProperty<string> MdnResponse
    {
        get => GetRequiredProperty<TerraformProperty<string>>("mdn_response");
        set => WithProperty("mdn_response", value);
    }

    /// <summary>
    /// The mdn_signing_algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? MdnSigningAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("mdn_signing_algorithm");
        set => WithProperty("mdn_signing_algorithm", value);
    }

    /// <summary>
    /// The message_subject attribute.
    /// </summary>
    public TerraformProperty<string>? MessageSubject
    {
        get => GetProperty<TerraformProperty<string>>("message_subject");
        set => WithProperty("message_subject", value);
    }

    /// <summary>
    /// The partner_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerProfileId is required")]
    public required TerraformProperty<string> PartnerProfileId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("partner_profile_id");
        set => WithProperty("partner_profile_id", value);
    }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    public required TerraformProperty<string> SigningAlgorithm
    {
        get => GetRequiredProperty<TerraformProperty<string>>("signing_algorithm");
        set => WithProperty("signing_algorithm", value);
    }

}

/// <summary>
/// Block type for sftp_config in .
/// Nesting mode: list
/// </summary>
public class AwsTransferConnectorSftpConfigBlock : TerraformBlock
{
    /// <summary>
    /// The trusted_host_keys attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? TrustedHostKeys
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("trusted_host_keys");
        set => WithProperty("trusted_host_keys", value);
    }

    /// <summary>
    /// The user_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserSecretId
    {
        get => GetProperty<TerraformProperty<string>>("user_secret_id");
        set => WithProperty("user_secret_id", value);
    }

}

/// <summary>
/// Manages a aws_transfer_connector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsTransferConnector : TerraformResource
{
    public AwsTransferConnector(string name) : base("aws_transfer_connector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("connector_id");
    }

    /// <summary>
    /// The access_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRole is required")]
    public required TerraformProperty<string> AccessRole
    {
        get => GetRequiredProperty<TerraformProperty<string>>("access_role");
        set => this.WithProperty("access_role", value);
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
    /// The logging_role attribute.
    /// </summary>
    public TerraformProperty<string>? LoggingRole
    {
        get => GetProperty<TerraformProperty<string>>("logging_role");
        set => this.WithProperty("logging_role", value);
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
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityPolicyName
    {
        get => GetProperty<TerraformProperty<string>>("security_policy_name");
        set => this.WithProperty("security_policy_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetRequiredProperty<TerraformProperty<string>>("url");
        set => this.WithProperty("url", value);
    }

    /// <summary>
    /// Block for as2_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 As2Config block(s) allowed")]
    public List<AwsTransferConnectorAs2ConfigBlock>? As2Config
    {
        get => GetProperty<List<AwsTransferConnectorAs2ConfigBlock>>("as2_config");
        set => this.WithProperty("as2_config", value);
    }

    /// <summary>
    /// Block for sftp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SftpConfig block(s) allowed")]
    public List<AwsTransferConnectorSftpConfigBlock>? SftpConfig
    {
        get => GetProperty<List<AwsTransferConnectorSftpConfigBlock>>("sftp_config");
        set => this.WithProperty("sftp_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The connector_id attribute.
    /// </summary>
    public TerraformExpression ConnectorId => this["connector_id"];

}
