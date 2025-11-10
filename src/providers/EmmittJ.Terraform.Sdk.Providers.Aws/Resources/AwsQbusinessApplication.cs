using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachments_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsQbusinessApplicationAttachmentsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Status information about whether file upload functionality is activated or deactivated for your end user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentsControlMode is required")]
    public required TerraformProperty<string> AttachmentsControlMode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("attachments_control_mode");
        set => WithProperty("attachments_control_mode", value);
    }

}

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsQbusinessApplicationEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The identifier of the AWS KMS key that is used to encrypt your data. Amazon Q doesn&#39;t support asymmetric keys.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    public required TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsQbusinessApplicationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_qbusiness_application resource.
/// </summary>
public class AwsQbusinessApplication : TerraformResource
{
    public AwsQbusinessApplication(string name) : base("aws_qbusiness_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("id");
        this.WithOutput("identity_center_application_arn");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// A description of the Amazon Q application.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the Amazon Q application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the IAM service role that provides permissions for the Amazon Q application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamServiceRoleArn is required")]
    public required TerraformProperty<string> IamServiceRoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("iam_service_role_arn");
        set => this.WithProperty("iam_service_role_arn", value);
    }

    /// <summary>
    /// ARN of the IAM Identity Center instance you are either creating for—or connecting to—your Amazon Q Business application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityCenterInstanceArn is required")]
    public required TerraformProperty<string> IdentityCenterInstanceArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("identity_center_instance_arn");
        set => this.WithProperty("identity_center_instance_arn", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for attachments_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsQbusinessApplicationAttachmentsConfigurationBlock>? AttachmentsConfiguration
    {
        get => GetProperty<List<AwsQbusinessApplicationAttachmentsConfigurationBlock>>("attachments_configuration");
        set => this.WithProperty("attachments_configuration", value);
    }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsQbusinessApplicationEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetProperty<List<AwsQbusinessApplicationEncryptionConfigurationBlock>>("encryption_configuration");
        set => this.WithProperty("encryption_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsQbusinessApplicationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsQbusinessApplicationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The identity_center_application_arn attribute.
    /// </summary>
    public TerraformExpression IdentityCenterApplicationArn => this["identity_center_application_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
