using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for high_availability_config in AwsM2Environment.
/// Nesting mode: list
/// </summary>
public class AwsM2EnvironmentHighAvailabilityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "high_availability_config";

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredCapacity is required")]
    public required TerraformValue<double> DesiredCapacity
    {
        get => GetRequiredArgument<TerraformValue<double>>("desired_capacity");
        set => SetArgument("desired_capacity", value);
    }

}


/// <summary>
/// Block type for storage_configuration in AwsM2Environment.
/// Nesting mode: list
/// </summary>
public class AwsM2EnvironmentStorageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_configuration";

    /// <summary>
    /// Efs block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsM2EnvironmentStorageConfigurationBlockEfsBlock>? Efs
    {
        get => GetArgument<TerraformList<AwsM2EnvironmentStorageConfigurationBlockEfsBlock>>("efs");
        set => SetArgument("efs", value);
    }

    /// <summary>
    /// Fsx block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsM2EnvironmentStorageConfigurationBlockFsxBlock>? Fsx
    {
        get => GetArgument<TerraformList<AwsM2EnvironmentStorageConfigurationBlockFsxBlock>>("fsx");
        set => SetArgument("fsx", value);
    }

}

/// <summary>
/// Block type for efs in AwsM2EnvironmentStorageConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsM2EnvironmentStorageConfigurationBlockEfsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "efs";

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformValue<string> FileSystemId
    {
        get => GetRequiredArgument<TerraformValue<string>>("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The mount_point attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPoint is required")]
    public required TerraformValue<string> MountPoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("mount_point");
        set => SetArgument("mount_point", value);
    }

}

/// <summary>
/// Block type for fsx in AwsM2EnvironmentStorageConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsM2EnvironmentStorageConfigurationBlockFsxBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fsx";

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformValue<string> FileSystemId
    {
        get => GetRequiredArgument<TerraformValue<string>>("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The mount_point attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPoint is required")]
    public required TerraformValue<string> MountPoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("mount_point");
        set => SetArgument("mount_point", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsM2Environment.
/// Nesting mode: single
/// </summary>
public class AwsM2EnvironmentTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_m2_environment Terraform resource.
/// Manages a aws_m2_environment resource.
/// </summary>
public partial class AwsM2Environment(string name) : TerraformResource("aws_m2_environment", name)
{
    /// <summary>
    /// The apply_changes_during_maintenance_window attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyChangesDuringMaintenanceWindow
    {
        get => GetArgument<TerraformValue<bool>>("apply_changes_during_maintenance_window");
        set => SetArgument("apply_changes_during_maintenance_window", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineType is required")]
    public required TerraformValue<string> EngineType
    {
        get => GetRequiredArgument<TerraformValue<string>>("engine_type");
        set => SetArgument("engine_type", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => GetArgument<TerraformValue<string>>("engine_version") ?? CreateReference("engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The force_update attribute.
    /// </summary>
    public TerraformValue<bool>? ForceUpdate
    {
        get => GetArgument<TerraformValue<bool>>("force_update");
        set => SetArgument("force_update", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
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
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
    {
        get => GetArgument<TerraformValue<string>>("preferred_maintenance_window") ?? CreateReference("preferred_maintenance_window");
        set => SetArgument("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
    {
        get => GetArgument<TerraformValue<bool>>("publicly_accessible") ?? CreateReference("publicly_accessible");
        set => SetArgument("publicly_accessible", value);
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
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids") ?? CreateReference("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => GetArgument<TerraformSet<string>>("subnet_ids") ?? CreateReference("subnet_ids");
        set => SetArgument("subnet_ids", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public TerraformValue<string> EnvironmentId
        => CreateReference("environment_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancerArn
        => CreateReference("load_balancer_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// HighAvailabilityConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsM2EnvironmentHighAvailabilityConfigBlock>? HighAvailabilityConfig
    {
        get => GetArgument<TerraformList<AwsM2EnvironmentHighAvailabilityConfigBlock>>("high_availability_config");
        set => SetArgument("high_availability_config", value);
    }

    /// <summary>
    /// StorageConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsM2EnvironmentStorageConfigurationBlock>? StorageConfiguration
    {
        get => GetArgument<TerraformList<AwsM2EnvironmentStorageConfigurationBlock>>("storage_configuration");
        set => SetArgument("storage_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsM2EnvironmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsM2EnvironmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
