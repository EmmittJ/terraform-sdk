using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachments_configuration in AwsQbusinessApplication.
/// Nesting mode: list
/// </summary>
public class AwsQbusinessApplicationAttachmentsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attachments_configuration";

    /// <summary>
    /// Status information about whether file upload functionality is activated or deactivated for your end user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentsControlMode is required")]
    public required TerraformValue<string> AttachmentsControlMode
    {
        get => new TerraformReference<string>(this, "attachments_control_mode");
        set => SetArgument("attachments_control_mode", value);
    }

}


/// <summary>
/// Block type for encryption_configuration in AwsQbusinessApplication.
/// Nesting mode: list
/// </summary>
public class AwsQbusinessApplicationEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// The identifier of the AWS KMS key that is used to encrypt your data. Amazon Q doesn&#39;t support asymmetric keys.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    public required TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsQbusinessApplication.
/// Nesting mode: single
/// </summary>
public class AwsQbusinessApplicationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_qbusiness_application Terraform resource.
/// Manages a aws_qbusiness_application resource.
/// </summary>
public partial class AwsQbusinessApplication(string name) : TerraformResource("aws_qbusiness_application", name)
{
    /// <summary>
    /// A description of the Amazon Q application.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name of the Amazon Q application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the IAM service role that provides permissions for the Amazon Q application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamServiceRoleArn is required")]
    public required TerraformValue<string> IamServiceRoleArn
    {
        get => new TerraformReference<string>(this, "iam_service_role_arn");
        set => SetArgument("iam_service_role_arn", value);
    }

    /// <summary>
    /// ARN of the IAM Identity Center instance you are either creating for—or connecting to—your Amazon Q Business application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityCenterInstanceArn is required")]
    public required TerraformValue<string> IdentityCenterInstanceArn
    {
        get => new TerraformReference<string>(this, "identity_center_instance_arn");
        set => SetArgument("identity_center_instance_arn", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The identity_center_application_arn attribute.
    /// </summary>
    public TerraformValue<string> IdentityCenterApplicationArn
    {
        get => new TerraformReference<string>(this, "identity_center_application_arn");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// AttachmentsConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsQbusinessApplicationAttachmentsConfigurationBlock>? AttachmentsConfiguration
    {
        get => GetArgument<TerraformList<AwsQbusinessApplicationAttachmentsConfigurationBlock>>("attachments_configuration");
        set => SetArgument("attachments_configuration", value);
    }

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsQbusinessApplicationEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsQbusinessApplicationEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsQbusinessApplicationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsQbusinessApplicationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
