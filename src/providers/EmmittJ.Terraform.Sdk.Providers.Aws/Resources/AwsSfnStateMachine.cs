using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in AwsSfnStateMachine.
/// Nesting mode: list
/// </summary>
public class AwsSfnStateMachineEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// The kms_data_key_reuse_period_seconds attribute.
    /// </summary>
    public TerraformValue<double>? KmsDataKeyReusePeriodSeconds
    {
        get => new TerraformReference<double>(this, "kms_data_key_reuse_period_seconds");
        set => SetArgument("kms_data_key_reuse_period_seconds", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for logging_configuration in AwsSfnStateMachine.
/// Nesting mode: list
/// </summary>
public class AwsSfnStateMachineLoggingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_configuration";

    /// <summary>
    /// The include_execution_data attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeExecutionData
    {
        get => new TerraformReference<bool>(this, "include_execution_data");
        set => SetArgument("include_execution_data", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformValue<string>? Level
    {
        get => new TerraformReference<string>(this, "level");
        set => SetArgument("level", value);
    }

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    public TerraformValue<string>? LogDestination
    {
        get => new TerraformReference<string>(this, "log_destination");
        set => SetArgument("log_destination", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsSfnStateMachine.
/// Nesting mode: single
/// </summary>
public class AwsSfnStateMachineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for tracing_configuration in AwsSfnStateMachine.
/// Nesting mode: list
/// </summary>
public class AwsSfnStateMachineTracingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tracing_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Represents a aws_sfn_state_machine Terraform resource.
/// Manages a aws_sfn_state_machine resource.
/// </summary>
public partial class AwsSfnStateMachine(string name) : TerraformResource("aws_sfn_state_machine", name)
{
    /// <summary>
    /// The definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Definition is required")]
    public required TerraformValue<string> Definition
    {
        get => new TerraformReference<string>(this, "definition");
        set => SetArgument("definition", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    public TerraformValue<bool>? Publish
    {
        get => new TerraformReference<bool>(this, "publish");
        set => SetArgument("publish", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
    {
        get => new TerraformReference<string>(this, "creation_date");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The revision_id attribute.
    /// </summary>
    public TerraformValue<string> RevisionId
    {
        get => new TerraformReference<string>(this, "revision_id");
    }

    /// <summary>
    /// The state_machine_version_arn attribute.
    /// </summary>
    public TerraformValue<string> StateMachineVersionArn
    {
        get => new TerraformReference<string>(this, "state_machine_version_arn");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public TerraformValue<string> VersionDescription
    {
        get => new TerraformReference<string>(this, "version_description");
    }

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public TerraformList<AwsSfnStateMachineEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsSfnStateMachineEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// LoggingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    public TerraformList<AwsSfnStateMachineLoggingConfigurationBlock>? LoggingConfiguration
    {
        get => GetArgument<TerraformList<AwsSfnStateMachineLoggingConfigurationBlock>>("logging_configuration");
        set => SetArgument("logging_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSfnStateMachineTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSfnStateMachineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TracingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TracingConfiguration block(s) allowed")]
    public TerraformList<AwsSfnStateMachineTracingConfigurationBlock>? TracingConfiguration
    {
        get => GetArgument<TerraformList<AwsSfnStateMachineTracingConfigurationBlock>>("tracing_configuration");
        set => SetArgument("tracing_configuration", value);
    }

}
