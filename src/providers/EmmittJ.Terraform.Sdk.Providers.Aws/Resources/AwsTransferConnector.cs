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
        set => SetProperty("compression", value);
    }

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionAlgorithm is required")]
    public required TerraformProperty<string> EncryptionAlgorithm
    {
        set => SetProperty("encryption_algorithm", value);
    }

    /// <summary>
    /// The local_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalProfileId is required")]
    public required TerraformProperty<string> LocalProfileId
    {
        set => SetProperty("local_profile_id", value);
    }

    /// <summary>
    /// The mdn_response attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MdnResponse is required")]
    public required TerraformProperty<string> MdnResponse
    {
        set => SetProperty("mdn_response", value);
    }

    /// <summary>
    /// The mdn_signing_algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? MdnSigningAlgorithm
    {
        set => SetProperty("mdn_signing_algorithm", value);
    }

    /// <summary>
    /// The message_subject attribute.
    /// </summary>
    public TerraformProperty<string>? MessageSubject
    {
        set => SetProperty("message_subject", value);
    }

    /// <summary>
    /// The partner_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerProfileId is required")]
    public required TerraformProperty<string> PartnerProfileId
    {
        set => SetProperty("partner_profile_id", value);
    }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    public required TerraformProperty<string> SigningAlgorithm
    {
        set => SetProperty("signing_algorithm", value);
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
        set => SetProperty("trusted_host_keys", value);
    }

    /// <summary>
    /// The user_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserSecretId
    {
        set => SetProperty("user_secret_id", value);
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
        SetOutput("arn");
        SetOutput("connector_id");
        SetOutput("access_role");
        SetOutput("id");
        SetOutput("logging_role");
        SetOutput("region");
        SetOutput("security_policy_name");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("url");
    }

    /// <summary>
    /// The access_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRole is required")]
    public required TerraformProperty<string> AccessRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_role");
        set => SetProperty("access_role", value);
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
    /// The logging_role attribute.
    /// </summary>
    public TerraformProperty<string> LoggingRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("logging_role");
        set => SetProperty("logging_role", value);
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
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformProperty<string> SecurityPolicyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_policy_name");
        set => SetProperty("security_policy_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetRequiredOutput<TerraformProperty<string>>("url");
        set => SetProperty("url", value);
    }

    /// <summary>
    /// Block for as2_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 As2Config block(s) allowed")]
    public List<AwsTransferConnectorAs2ConfigBlock>? As2Config
    {
        set => SetProperty("as2_config", value);
    }

    /// <summary>
    /// Block for sftp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SftpConfig block(s) allowed")]
    public List<AwsTransferConnectorSftpConfigBlock>? SftpConfig
    {
        set => SetProperty("sftp_config", value);
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
