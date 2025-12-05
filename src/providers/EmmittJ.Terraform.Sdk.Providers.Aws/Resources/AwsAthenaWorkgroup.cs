using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsAthenaWorkgroup.
/// Nesting mode: list
/// </summary>
public class AwsAthenaWorkgroupConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// The bytes_scanned_cutoff_per_query attribute.
    /// </summary>
    public TerraformValue<double>? BytesScannedCutoffPerQuery
    {
        get => GetArgument<TerraformValue<double>>("bytes_scanned_cutoff_per_query");
        set => SetArgument("bytes_scanned_cutoff_per_query", value);
    }

    /// <summary>
    /// The enforce_workgroup_configuration attribute.
    /// </summary>
    public TerraformValue<bool>? EnforceWorkgroupConfiguration
    {
        get => GetArgument<TerraformValue<bool>>("enforce_workgroup_configuration");
        set => SetArgument("enforce_workgroup_configuration", value);
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionRole
    {
        get => GetArgument<TerraformValue<string>>("execution_role");
        set => SetArgument("execution_role", value);
    }

    /// <summary>
    /// The publish_cloudwatch_metrics_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublishCloudwatchMetricsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("publish_cloudwatch_metrics_enabled");
        set => SetArgument("publish_cloudwatch_metrics_enabled", value);
    }

    /// <summary>
    /// The requester_pays_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RequesterPaysEnabled
    {
        get => GetArgument<TerraformValue<bool>>("requester_pays_enabled");
        set => SetArgument("requester_pays_enabled", value);
    }

    /// <summary>
    /// EngineVersion block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EngineVersion block(s) allowed")]
    public TerraformList<AwsAthenaWorkgroupConfigurationBlockEngineVersionBlock>? EngineVersion
    {
        get => GetArgument<TerraformList<AwsAthenaWorkgroupConfigurationBlockEngineVersionBlock>>("engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// IdentityCenterConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityCenterConfiguration block(s) allowed")]
    public TerraformList<AwsAthenaWorkgroupConfigurationBlockIdentityCenterConfigurationBlock>? IdentityCenterConfiguration
    {
        get => GetArgument<TerraformList<AwsAthenaWorkgroupConfigurationBlockIdentityCenterConfigurationBlock>>("identity_center_configuration");
        set => SetArgument("identity_center_configuration", value);
    }

    /// <summary>
    /// ResultConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResultConfiguration block(s) allowed")]
    public TerraformList<AwsAthenaWorkgroupConfigurationBlockResultConfigurationBlock>? ResultConfiguration
    {
        get => GetArgument<TerraformList<AwsAthenaWorkgroupConfigurationBlockResultConfigurationBlock>>("result_configuration");
        set => SetArgument("result_configuration", value);
    }

}

/// <summary>
/// Block type for engine_version in AwsAthenaWorkgroupConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAthenaWorkgroupConfigurationBlockEngineVersionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "engine_version";

    /// <summary>
    /// The effective_engine_version attribute.
    /// </summary>
    public TerraformValue<string> EffectiveEngineVersion
        => CreateReference("effective_engine_version");

    /// <summary>
    /// The selected_engine_version attribute.
    /// </summary>
    public TerraformValue<string>? SelectedEngineVersion
    {
        get => GetArgument<TerraformValue<string>>("selected_engine_version");
        set => SetArgument("selected_engine_version", value);
    }

}

/// <summary>
/// Block type for identity_center_configuration in AwsAthenaWorkgroupConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAthenaWorkgroupConfigurationBlockIdentityCenterConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity_center_configuration";

    /// <summary>
    /// The enable_identity_center attribute.
    /// </summary>
    public TerraformValue<bool>? EnableIdentityCenter
    {
        get => GetArgument<TerraformValue<bool>>("enable_identity_center");
        set => SetArgument("enable_identity_center", value);
    }

    /// <summary>
    /// The identity_center_instance_arn attribute.
    /// </summary>
    public TerraformValue<string>? IdentityCenterInstanceArn
    {
        get => GetArgument<TerraformValue<string>>("identity_center_instance_arn");
        set => SetArgument("identity_center_instance_arn", value);
    }

}

/// <summary>
/// Block type for result_configuration in AwsAthenaWorkgroupConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAthenaWorkgroupConfigurationBlockResultConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "result_configuration";

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformValue<string>? ExpectedBucketOwner
    {
        get => GetArgument<TerraformValue<string>>("expected_bucket_owner");
        set => SetArgument("expected_bucket_owner", value);
    }

    /// <summary>
    /// The output_location attribute.
    /// </summary>
    public TerraformValue<string>? OutputLocation
    {
        get => GetArgument<TerraformValue<string>>("output_location");
        set => SetArgument("output_location", value);
    }

    /// <summary>
    /// AclConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AclConfiguration block(s) allowed")]
    public TerraformList<AwsAthenaWorkgroupConfigurationBlockResultConfigurationBlockAclConfigurationBlock>? AclConfiguration
    {
        get => GetArgument<TerraformList<AwsAthenaWorkgroupConfigurationBlockResultConfigurationBlockAclConfigurationBlock>>("acl_configuration");
        set => SetArgument("acl_configuration", value);
    }

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public TerraformList<AwsAthenaWorkgroupConfigurationBlockResultConfigurationBlockEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsAthenaWorkgroupConfigurationBlockResultConfigurationBlockEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

}

/// <summary>
/// Block type for acl_configuration in AwsAthenaWorkgroupConfigurationBlockResultConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAthenaWorkgroupConfigurationBlockResultConfigurationBlockAclConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "acl_configuration";

    /// <summary>
    /// The s3_acl_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3AclOption is required")]
    public required TerraformValue<string> S3AclOption
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_acl_option");
        set => SetArgument("s3_acl_option", value);
    }

}

/// <summary>
/// Block type for encryption_configuration in AwsAthenaWorkgroupConfigurationBlockResultConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAthenaWorkgroupConfigurationBlockResultConfigurationBlockEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// The encryption_option attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionOption
    {
        get => GetArgument<TerraformValue<string>>("encryption_option");
        set => SetArgument("encryption_option", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}


/// <summary>
/// Represents a aws_athena_workgroup Terraform resource.
/// Manages a aws_athena_workgroup resource.
/// </summary>
public partial class AwsAthenaWorkgroup(string name) : TerraformResource("aws_athena_workgroup", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => GetArgument<TerraformValue<bool>>("force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public TerraformList<AwsAthenaWorkgroupConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsAthenaWorkgroupConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

}
