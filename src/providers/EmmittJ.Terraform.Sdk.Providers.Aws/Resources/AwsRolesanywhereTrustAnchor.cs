using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for notification_settings in AwsRolesanywhereTrustAnchor.
/// Nesting mode: set
/// </summary>
public class AwsRolesanywhereTrustAnchorNotificationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_settings";

    /// <summary>
    /// The channel attribute.
    /// </summary>
    public TerraformValue<string>? Channel
    {
        get => GetArgument<TerraformValue<string>>("channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// The configured_by attribute.
    /// </summary>
    public TerraformValue<string> ConfiguredBy
        => AsReference("configured_by");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The event attribute.
    /// </summary>
    public TerraformValue<string>? EventAttribute
    {
        get => GetArgument<TerraformValue<string>>("event");
        set => SetArgument("event", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    public TerraformValue<double>? Threshold
    {
        get => GetArgument<TerraformValue<double>>("threshold");
        set => SetArgument("threshold", value);
    }

}


/// <summary>
/// Block type for source in AwsRolesanywhereTrustAnchor.
/// Nesting mode: list
/// </summary>
public class AwsRolesanywhereTrustAnchorSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    public required TerraformValue<string> SourceType
    {
        get => GetArgument<TerraformValue<string>>("source_type");
        set => SetArgument("source_type", value);
    }

    /// <summary>
    /// SourceData block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceData is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceData block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceData block(s) allowed")]
    public required TerraformList<AwsRolesanywhereTrustAnchorSourceBlockSourceDataBlock> SourceData
    {
        get => GetRequiredArgument<TerraformList<AwsRolesanywhereTrustAnchorSourceBlockSourceDataBlock>>("source_data");
        set => SetArgument("source_data", value);
    }

}

/// <summary>
/// Block type for source_data in AwsRolesanywhereTrustAnchorSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsRolesanywhereTrustAnchorSourceBlockSourceDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_data";

    /// <summary>
    /// The acm_pca_arn attribute.
    /// </summary>
    public TerraformValue<string>? AcmPcaArn
    {
        get => GetArgument<TerraformValue<string>>("acm_pca_arn");
        set => SetArgument("acm_pca_arn", value);
    }

    /// <summary>
    /// The x509_certificate_data attribute.
    /// </summary>
    public TerraformValue<string>? X509CertificateData
    {
        get => GetArgument<TerraformValue<string>>("x509_certificate_data");
        set => SetArgument("x509_certificate_data", value);
    }

}


/// <summary>
/// Represents a aws_rolesanywhere_trust_anchor Terraform resource.
/// Manages a aws_rolesanywhere_trust_anchor resource.
/// </summary>
public partial class AwsRolesanywhereTrustAnchor(string name) : TerraformResource("aws_rolesanywhere_trust_anchor", name)
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// NotificationSettings block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 NotificationSettings block(s) allowed")]
    public TerraformSet<AwsRolesanywhereTrustAnchorNotificationSettingsBlock>? NotificationSettings
    {
        get => GetArgument<TerraformSet<AwsRolesanywhereTrustAnchorNotificationSettingsBlock>>("notification_settings");
        set => SetArgument("notification_settings", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<AwsRolesanywhereTrustAnchorSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<AwsRolesanywhereTrustAnchorSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}
