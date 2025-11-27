using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination in AwsEfsReplicationConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsEfsReplicationConfigurationDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityZoneName
    {
        get => new TerraformReference<string>(this, "availability_zone_name");
        set => SetArgument("availability_zone_name", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string> FileSystemId
    {
        get => new TerraformReference<string>(this, "file_system_id");
        set => SetArgument("file_system_id", value);
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
    /// The region attribute.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}


/// <summary>
/// Block type for timeouts in AwsEfsReplicationConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsEfsReplicationConfigurationTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_efs_replication_configuration Terraform resource.
/// Manages a aws_efs_replication_configuration resource.
/// </summary>
public partial class AwsEfsReplicationConfiguration(string name) : TerraformResource("aws_efs_replication_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The source_file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceFileSystemId is required")]
    public required TerraformValue<string> SourceFileSystemId
    {
        get => new TerraformReference<string>(this, "source_file_system_id");
        set => SetArgument("source_file_system_id", value);
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
    {
        get => new TerraformReference<string>(this, "creation_time");
    }

    /// <summary>
    /// The original_source_file_system_arn attribute.
    /// </summary>
    public TerraformValue<string> OriginalSourceFileSystemArn
    {
        get => new TerraformReference<string>(this, "original_source_file_system_arn");
    }

    /// <summary>
    /// The source_file_system_arn attribute.
    /// </summary>
    public TerraformValue<string> SourceFileSystemArn
    {
        get => new TerraformReference<string>(this, "source_file_system_arn");
    }

    /// <summary>
    /// The source_file_system_region attribute.
    /// </summary>
    public TerraformValue<string> SourceFileSystemRegion
    {
        get => new TerraformReference<string>(this, "source_file_system_region");
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AwsEfsReplicationConfigurationDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsEfsReplicationConfigurationDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEfsReplicationConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEfsReplicationConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
