using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSfnStateMachineEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The kms_data_key_reuse_period_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? KmsDataKeyReusePeriodSeconds
    {
        get => GetProperty<TerraformProperty<double>>("kms_data_key_reuse_period_seconds");
        set => WithProperty("kms_data_key_reuse_period_seconds", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for logging_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSfnStateMachineLoggingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The include_execution_data attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeExecutionData
    {
        get => GetProperty<TerraformProperty<bool>>("include_execution_data");
        set => WithProperty("include_execution_data", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformProperty<string>? Level
    {
        get => GetProperty<TerraformProperty<string>>("level");
        set => WithProperty("level", value);
    }

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    public TerraformProperty<string>? LogDestination
    {
        get => GetProperty<TerraformProperty<string>>("log_destination");
        set => WithProperty("log_destination", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSfnStateMachineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for tracing_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSfnStateMachineTracingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

}

/// <summary>
/// Manages a aws_sfn_state_machine resource.
/// </summary>
public class AwsSfnStateMachine : TerraformResource
{
    public AwsSfnStateMachine(string name) : base("aws_sfn_state_machine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("creation_date");
        this.DeclareOutput("description");
        this.DeclareOutput("revision_id");
        this.DeclareOutput("state_machine_version_arn");
        this.DeclareOutput("status");
        this.DeclareOutput("version_description");
    }

    /// <summary>
    /// The definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Definition is required")]
    public required TerraformProperty<string> Definition
    {
        get => GetProperty<TerraformProperty<string>>("definition");
        set => this.WithProperty("definition", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    public TerraformProperty<bool>? Publish
    {
        get => GetProperty<TerraformProperty<bool>>("publish");
        set => this.WithProperty("publish", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public List<AwsSfnStateMachineEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetProperty<List<AwsSfnStateMachineEncryptionConfigurationBlock>>("encryption_configuration");
        set => this.WithProperty("encryption_configuration", value);
    }

    /// <summary>
    /// Block for logging_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    public List<AwsSfnStateMachineLoggingConfigurationBlock>? LoggingConfiguration
    {
        get => GetProperty<List<AwsSfnStateMachineLoggingConfigurationBlock>>("logging_configuration");
        set => this.WithProperty("logging_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSfnStateMachineTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsSfnStateMachineTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for tracing_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TracingConfiguration block(s) allowed")]
    public List<AwsSfnStateMachineTracingConfigurationBlock>? TracingConfiguration
    {
        get => GetProperty<List<AwsSfnStateMachineTracingConfigurationBlock>>("tracing_configuration");
        set => this.WithProperty("tracing_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The revision_id attribute.
    /// </summary>
    public TerraformExpression RevisionId => this["revision_id"];

    /// <summary>
    /// The state_machine_version_arn attribute.
    /// </summary>
    public TerraformExpression StateMachineVersionArn => this["state_machine_version_arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public TerraformExpression VersionDescription => this["version_description"];

}
