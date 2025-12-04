using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for as2_config in AwsTransferConnector.
/// Nesting mode: list
/// </summary>
public class AwsTransferConnectorAs2ConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "as2_config";

    /// <summary>
    /// The compression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compression is required")]
    public required TerraformValue<string> Compression
    {
        get => GetArgument<TerraformValue<string>>("compression");
        set => SetArgument("compression", value);
    }

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionAlgorithm is required")]
    public required TerraformValue<string> EncryptionAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("encryption_algorithm");
        set => SetArgument("encryption_algorithm", value);
    }

    /// <summary>
    /// The local_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalProfileId is required")]
    public required TerraformValue<string> LocalProfileId
    {
        get => GetArgument<TerraformValue<string>>("local_profile_id");
        set => SetArgument("local_profile_id", value);
    }

    /// <summary>
    /// The mdn_response attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MdnResponse is required")]
    public required TerraformValue<string> MdnResponse
    {
        get => GetArgument<TerraformValue<string>>("mdn_response");
        set => SetArgument("mdn_response", value);
    }

    /// <summary>
    /// The mdn_signing_algorithm attribute.
    /// </summary>
    public TerraformValue<string>? MdnSigningAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("mdn_signing_algorithm");
        set => SetArgument("mdn_signing_algorithm", value);
    }

    /// <summary>
    /// The message_subject attribute.
    /// </summary>
    public TerraformValue<string>? MessageSubject
    {
        get => GetArgument<TerraformValue<string>>("message_subject");
        set => SetArgument("message_subject", value);
    }

    /// <summary>
    /// The partner_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerProfileId is required")]
    public required TerraformValue<string> PartnerProfileId
    {
        get => GetArgument<TerraformValue<string>>("partner_profile_id");
        set => SetArgument("partner_profile_id", value);
    }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    public required TerraformValue<string> SigningAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("signing_algorithm");
        set => SetArgument("signing_algorithm", value);
    }

}


/// <summary>
/// Block type for sftp_config in AwsTransferConnector.
/// Nesting mode: list
/// </summary>
public class AwsTransferConnectorSftpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sftp_config";

    /// <summary>
    /// The trusted_host_keys attribute.
    /// </summary>
    public TerraformSet<string>? TrustedHostKeys
    {
        get => GetArgument<TerraformSet<string>>("trusted_host_keys");
        set => SetArgument("trusted_host_keys", value);
    }

    /// <summary>
    /// The user_secret_id attribute.
    /// </summary>
    public TerraformValue<string>? UserSecretId
    {
        get => GetArgument<TerraformValue<string>>("user_secret_id");
        set => SetArgument("user_secret_id", value);
    }

}


/// <summary>
/// Represents a aws_transfer_connector Terraform resource.
/// Manages a aws_transfer_connector resource.
/// </summary>
public partial class AwsTransferConnector(string name) : TerraformResource("aws_transfer_connector", name)
{
    /// <summary>
    /// The access_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRole is required")]
    public required TerraformValue<string> AccessRole
    {
        get => GetArgument<TerraformValue<string>>("access_role");
        set => SetArgument("access_role", value);
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
    /// The logging_role attribute.
    /// </summary>
    public TerraformValue<string>? LoggingRole
    {
        get => GetArgument<TerraformValue<string>>("logging_role");
        set => SetArgument("logging_role", value);
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
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformValue<string>? SecurityPolicyName
    {
        get => GetArgument<TerraformValue<string>>("security_policy_name");
        set => SetArgument("security_policy_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The connector_id attribute.
    /// </summary>
    public TerraformValue<string> ConnectorId
        => AsReference("connector_id");

    /// <summary>
    /// As2Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 As2Config block(s) allowed")]
    public TerraformList<AwsTransferConnectorAs2ConfigBlock>? As2Config
    {
        get => GetArgument<TerraformList<AwsTransferConnectorAs2ConfigBlock>>("as2_config");
        set => SetArgument("as2_config", value);
    }

    /// <summary>
    /// SftpConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SftpConfig block(s) allowed")]
    public TerraformList<AwsTransferConnectorSftpConfigBlock>? SftpConfig
    {
        get => GetArgument<TerraformList<AwsTransferConnectorSftpConfigBlock>>("sftp_config");
        set => SetArgument("sftp_config", value);
    }

}
