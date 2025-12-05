using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for distribution in AwsImagebuilderDistributionConfiguration.
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderDistributionConfigurationDistributionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "distribution";

    /// <summary>
    /// The license_configuration_arns attribute.
    /// </summary>
    public TerraformSet<string>? LicenseConfigurationArns
    {
        get => GetArgument<TerraformSet<string>>("license_configuration_arns");
        set => SetArgument("license_configuration_arns", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => GetRequiredArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// AmiDistributionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmiDistributionConfiguration block(s) allowed")]
    public TerraformList<AwsImagebuilderDistributionConfigurationDistributionBlockAmiDistributionConfigurationBlock>? AmiDistributionConfiguration
    {
        get => GetArgument<TerraformList<AwsImagebuilderDistributionConfigurationDistributionBlockAmiDistributionConfigurationBlock>>("ami_distribution_configuration");
        set => SetArgument("ami_distribution_configuration", value);
    }

    /// <summary>
    /// ContainerDistributionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerDistributionConfiguration block(s) allowed")]
    public TerraformList<AwsImagebuilderDistributionConfigurationDistributionBlockContainerDistributionConfigurationBlock>? ContainerDistributionConfiguration
    {
        get => GetArgument<TerraformList<AwsImagebuilderDistributionConfigurationDistributionBlockContainerDistributionConfigurationBlock>>("container_distribution_configuration");
        set => SetArgument("container_distribution_configuration", value);
    }

    /// <summary>
    /// FastLaunchConfiguration block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 FastLaunchConfiguration block(s) allowed")]
    public TerraformSet<AwsImagebuilderDistributionConfigurationDistributionBlockFastLaunchConfigurationBlock>? FastLaunchConfiguration
    {
        get => GetArgument<TerraformSet<AwsImagebuilderDistributionConfigurationDistributionBlockFastLaunchConfigurationBlock>>("fast_launch_configuration");
        set => SetArgument("fast_launch_configuration", value);
    }

    /// <summary>
    /// LaunchTemplateConfiguration block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 LaunchTemplateConfiguration block(s) allowed")]
    public TerraformSet<AwsImagebuilderDistributionConfigurationDistributionBlockLaunchTemplateConfigurationBlock>? LaunchTemplateConfiguration
    {
        get => GetArgument<TerraformSet<AwsImagebuilderDistributionConfigurationDistributionBlockLaunchTemplateConfigurationBlock>>("launch_template_configuration");
        set => SetArgument("launch_template_configuration", value);
    }

    /// <summary>
    /// S3ExportConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3ExportConfiguration block(s) allowed")]
    public TerraformList<AwsImagebuilderDistributionConfigurationDistributionBlockS3ExportConfigurationBlock>? S3ExportConfiguration
    {
        get => GetArgument<TerraformList<AwsImagebuilderDistributionConfigurationDistributionBlockS3ExportConfigurationBlock>>("s3_export_configuration");
        set => SetArgument("s3_export_configuration", value);
    }

    /// <summary>
    /// SsmParameterConfiguration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsImagebuilderDistributionConfigurationDistributionBlockSsmParameterConfigurationBlock>? SsmParameterConfiguration
    {
        get => GetArgument<TerraformSet<AwsImagebuilderDistributionConfigurationDistributionBlockSsmParameterConfigurationBlock>>("ssm_parameter_configuration");
        set => SetArgument("ssm_parameter_configuration", value);
    }

}

/// <summary>
/// Block type for ami_distribution_configuration in AwsImagebuilderDistributionConfigurationDistributionBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderDistributionConfigurationDistributionBlockAmiDistributionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ami_distribution_configuration";

    /// <summary>
    /// The ami_tags attribute.
    /// </summary>
    public TerraformMap<string>? AmiTags
    {
        get => GetArgument<TerraformMap<string>>("ami_tags");
        set => SetArgument("ami_tags", value);
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
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The target_account_ids attribute.
    /// </summary>
    public TerraformSet<string>? TargetAccountIds
    {
        get => GetArgument<TerraformSet<string>>("target_account_ids");
        set => SetArgument("target_account_ids", value);
    }

    /// <summary>
    /// LaunchPermission block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchPermission block(s) allowed")]
    public TerraformList<AwsImagebuilderDistributionConfigurationDistributionBlockAmiDistributionConfigurationBlockLaunchPermissionBlock>? LaunchPermission
    {
        get => GetArgument<TerraformList<AwsImagebuilderDistributionConfigurationDistributionBlockAmiDistributionConfigurationBlockLaunchPermissionBlock>>("launch_permission");
        set => SetArgument("launch_permission", value);
    }

}

/// <summary>
/// Block type for launch_permission in AwsImagebuilderDistributionConfigurationDistributionBlockAmiDistributionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderDistributionConfigurationDistributionBlockAmiDistributionConfigurationBlockLaunchPermissionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_permission";

    /// <summary>
    /// The organization_arns attribute.
    /// </summary>
    public TerraformSet<string>? OrganizationArns
    {
        get => GetArgument<TerraformSet<string>>("organization_arns");
        set => SetArgument("organization_arns", value);
    }

    /// <summary>
    /// The organizational_unit_arns attribute.
    /// </summary>
    public TerraformSet<string>? OrganizationalUnitArns
    {
        get => GetArgument<TerraformSet<string>>("organizational_unit_arns");
        set => SetArgument("organizational_unit_arns", value);
    }

    /// <summary>
    /// The user_groups attribute.
    /// </summary>
    public TerraformSet<string>? UserGroups
    {
        get => GetArgument<TerraformSet<string>>("user_groups");
        set => SetArgument("user_groups", value);
    }

    /// <summary>
    /// The user_ids attribute.
    /// </summary>
    public TerraformSet<string>? UserIds
    {
        get => GetArgument<TerraformSet<string>>("user_ids");
        set => SetArgument("user_ids", value);
    }

}

/// <summary>
/// Block type for container_distribution_configuration in AwsImagebuilderDistributionConfigurationDistributionBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderDistributionConfigurationDistributionBlockContainerDistributionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_distribution_configuration";

    /// <summary>
    /// The container_tags attribute.
    /// </summary>
    public TerraformSet<string>? ContainerTags
    {
        get => GetArgument<TerraformSet<string>>("container_tags");
        set => SetArgument("container_tags", value);
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
    /// TargetRepository block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRepository is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRepository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetRepository block(s) allowed")]
    public required TerraformList<AwsImagebuilderDistributionConfigurationDistributionBlockContainerDistributionConfigurationBlockTargetRepositoryBlock> TargetRepository
    {
        get => GetRequiredArgument<TerraformList<AwsImagebuilderDistributionConfigurationDistributionBlockContainerDistributionConfigurationBlockTargetRepositoryBlock>>("target_repository");
        set => SetArgument("target_repository", value);
    }

}

/// <summary>
/// Block type for target_repository in AwsImagebuilderDistributionConfigurationDistributionBlockContainerDistributionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderDistributionConfigurationDistributionBlockContainerDistributionConfigurationBlockTargetRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_repository";

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_name");
        set => SetArgument("repository_name", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for fast_launch_configuration in AwsImagebuilderDistributionConfigurationDistributionBlock.
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderDistributionConfigurationDistributionBlockFastLaunchConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fast_launch_configuration";

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformValue<string> AccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The max_parallel_launches attribute.
    /// </summary>
    public TerraformValue<double>? MaxParallelLaunches
    {
        get => GetArgument<TerraformValue<double>>("max_parallel_launches");
        set => SetArgument("max_parallel_launches", value);
    }

    /// <summary>
    /// LaunchTemplate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    public TerraformList<AwsImagebuilderDistributionConfigurationDistributionBlockFastLaunchConfigurationBlockLaunchTemplateBlock>? LaunchTemplate
    {
        get => GetArgument<TerraformList<AwsImagebuilderDistributionConfigurationDistributionBlockFastLaunchConfigurationBlockLaunchTemplateBlock>>("launch_template");
        set => SetArgument("launch_template", value);
    }

    /// <summary>
    /// SnapshotConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotConfiguration block(s) allowed")]
    public TerraformList<AwsImagebuilderDistributionConfigurationDistributionBlockFastLaunchConfigurationBlockSnapshotConfigurationBlock>? SnapshotConfiguration
    {
        get => GetArgument<TerraformList<AwsImagebuilderDistributionConfigurationDistributionBlockFastLaunchConfigurationBlockSnapshotConfigurationBlock>>("snapshot_configuration");
        set => SetArgument("snapshot_configuration", value);
    }

}

/// <summary>
/// Block type for launch_template in AwsImagebuilderDistributionConfigurationDistributionBlockFastLaunchConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderDistributionConfigurationDistributionBlockFastLaunchConfigurationBlockLaunchTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_template";

    /// <summary>
    /// The launch_template_id attribute.
    /// </summary>
    public TerraformValue<string>? LaunchTemplateId
    {
        get => GetArgument<TerraformValue<string>>("launch_template_id");
        set => SetArgument("launch_template_id", value);
    }

    /// <summary>
    /// The launch_template_name attribute.
    /// </summary>
    public TerraformValue<string>? LaunchTemplateName
    {
        get => GetArgument<TerraformValue<string>>("launch_template_name");
        set => SetArgument("launch_template_name", value);
    }

    /// <summary>
    /// The launch_template_version attribute.
    /// </summary>
    public TerraformValue<string>? LaunchTemplateVersion
    {
        get => GetArgument<TerraformValue<string>>("launch_template_version");
        set => SetArgument("launch_template_version", value);
    }

}

/// <summary>
/// Block type for snapshot_configuration in AwsImagebuilderDistributionConfigurationDistributionBlockFastLaunchConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderDistributionConfigurationDistributionBlockFastLaunchConfigurationBlockSnapshotConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snapshot_configuration";

    /// <summary>
    /// The target_resource_count attribute.
    /// </summary>
    public TerraformValue<double>? TargetResourceCount
    {
        get => GetArgument<TerraformValue<double>>("target_resource_count");
        set => SetArgument("target_resource_count", value);
    }

}

/// <summary>
/// Block type for launch_template_configuration in AwsImagebuilderDistributionConfigurationDistributionBlock.
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderDistributionConfigurationDistributionBlockLaunchTemplateConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_template_configuration";

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The default attribute.
    /// </summary>
    public TerraformValue<bool>? DefaultAttribute
    {
        get => GetArgument<TerraformValue<bool>>("default");
        set => SetArgument("default", value);
    }

    /// <summary>
    /// The launch_template_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LaunchTemplateId is required")]
    public required TerraformValue<string> LaunchTemplateId
    {
        get => GetRequiredArgument<TerraformValue<string>>("launch_template_id");
        set => SetArgument("launch_template_id", value);
    }

}

/// <summary>
/// Block type for s3_export_configuration in AwsImagebuilderDistributionConfigurationDistributionBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderDistributionConfigurationDistributionBlockS3ExportConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_export_configuration";

    /// <summary>
    /// The disk_image_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskImageFormat is required")]
    public required TerraformValue<string> DiskImageFormat
    {
        get => GetRequiredArgument<TerraformValue<string>>("disk_image_format");
        set => SetArgument("disk_image_format", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    public required TerraformValue<string> RoleName
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_name");
        set => SetArgument("role_name", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformValue<string> S3Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public TerraformValue<string>? S3Prefix
    {
        get => GetArgument<TerraformValue<string>>("s3_prefix");
        set => SetArgument("s3_prefix", value);
    }

}

/// <summary>
/// Block type for ssm_parameter_configuration in AwsImagebuilderDistributionConfigurationDistributionBlock.
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderDistributionConfigurationDistributionBlockSsmParameterConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssm_parameter_configuration";

    /// <summary>
    /// The ami_account_id attribute.
    /// </summary>
    public TerraformValue<string>? AmiAccountId
    {
        get => GetArgument<TerraformValue<string>>("ami_account_id");
        set => SetArgument("ami_account_id", value);
    }

    /// <summary>
    /// The data_type attribute.
    /// </summary>
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// The parameter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterName is required")]
    public required TerraformValue<string> ParameterName
    {
        get => GetRequiredArgument<TerraformValue<string>>("parameter_name");
        set => SetArgument("parameter_name", value);
    }

}


/// <summary>
/// Represents a aws_imagebuilder_distribution_configuration Terraform resource.
/// Manages a aws_imagebuilder_distribution_configuration resource.
/// </summary>
public partial class AwsImagebuilderDistributionConfiguration(string name) : TerraformResource("aws_imagebuilder_distribution_configuration", name)
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
    /// The date_created attribute.
    /// </summary>
    public TerraformValue<string> DateCreated
        => CreateReference("date_created");

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    public TerraformValue<string> DateUpdated
        => CreateReference("date_updated");

    /// <summary>
    /// Distribution block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Distribution is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Distribution block(s) required")]
    public required TerraformSet<AwsImagebuilderDistributionConfigurationDistributionBlock> Distribution
    {
        get => GetRequiredArgument<TerraformSet<AwsImagebuilderDistributionConfigurationDistributionBlock>>("distribution");
        set => SetArgument("distribution", value);
    }

}
