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
        get => new TerraformReference<string>(this, "compression");
        set => SetArgument("compression", value);
    }

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionAlgorithm is required")]
    public required TerraformValue<string> EncryptionAlgorithm
    {
        get => new TerraformReference<string>(this, "encryption_algorithm");
        set => SetArgument("encryption_algorithm", value);
    }

    /// <summary>
    /// The local_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalProfileId is required")]
    public required TerraformValue<string> LocalProfileId
    {
        get => new TerraformReference<string>(this, "local_profile_id");
        set => SetArgument("local_profile_id", value);
    }

    /// <summary>
    /// The mdn_response attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MdnResponse is required")]
    public required TerraformValue<string> MdnResponse
    {
        get => new TerraformReference<string>(this, "mdn_response");
        set => SetArgument("mdn_response", value);
    }

    /// <summary>
    /// The mdn_signing_algorithm attribute.
    /// </summary>
    public TerraformValue<string>? MdnSigningAlgorithm
    {
        get => new TerraformReference<string>(this, "mdn_signing_algorithm");
        set => SetArgument("mdn_signing_algorithm", value);
    }

    /// <summary>
    /// The message_subject attribute.
    /// </summary>
    public TerraformValue<string>? MessageSubject
    {
        get => new TerraformReference<string>(this, "message_subject");
        set => SetArgument("message_subject", value);
    }

    /// <summary>
    /// The partner_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerProfileId is required")]
    public required TerraformValue<string> PartnerProfileId
    {
        get => new TerraformReference<string>(this, "partner_profile_id");
        set => SetArgument("partner_profile_id", value);
    }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    public required TerraformValue<string> SigningAlgorithm
    {
        get => new TerraformReference<string>(this, "signing_algorithm");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "trusted_host_keys").ResolveNodes(ctx));
        set => SetArgument("trusted_host_keys", value);
    }

    /// <summary>
    /// The user_secret_id attribute.
    /// </summary>
    public TerraformValue<string>? UserSecretId
    {
        get => new TerraformReference<string>(this, "user_secret_id");
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
        get => new TerraformReference<string>(this, "access_role");
        set => SetArgument("access_role", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    public TerraformValue<string>? LoggingRole
    {
        get => new TerraformReference<string>(this, "logging_role");
        set => SetArgument("logging_role", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformValue<string> SecurityPolicyName
    {
        get => new TerraformReference<string>(this, "security_policy_name");
        set => SetArgument("security_policy_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The connector_id attribute.
    /// </summary>
    public TerraformValue<string> ConnectorId
    {
        get => new TerraformReference<string>(this, "connector_id");
    }

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
