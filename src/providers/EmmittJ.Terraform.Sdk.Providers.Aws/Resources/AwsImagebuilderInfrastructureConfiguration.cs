using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for instance_metadata_options in AwsImagebuilderInfrastructureConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderInfrastructureConfigurationInstanceMetadataOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_metadata_options";

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    public TerraformValue<double>? HttpPutResponseHopLimit
    {
        get => new TerraformReference<double>(this, "http_put_response_hop_limit");
        set => SetArgument("http_put_response_hop_limit", value);
    }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    public TerraformValue<string>? HttpTokens
    {
        get => new TerraformReference<string>(this, "http_tokens");
        set => SetArgument("http_tokens", value);
    }

}


/// <summary>
/// Block type for logging in AwsImagebuilderInfrastructureConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderInfrastructureConfigurationLoggingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging";

    /// <summary>
    /// S3Logs block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Logs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Logs block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Logs block(s) allowed")]
    public required TerraformList<AwsImagebuilderInfrastructureConfigurationLoggingBlockS3LogsBlock> S3Logs
    {
        get => GetRequiredArgument<TerraformList<AwsImagebuilderInfrastructureConfigurationLoggingBlockS3LogsBlock>>("s3_logs");
        set => SetArgument("s3_logs", value);
    }

}

/// <summary>
/// Block type for s3_logs in AwsImagebuilderInfrastructureConfigurationLoggingBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderInfrastructureConfigurationLoggingBlockS3LogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_logs";

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformValue<string> S3BucketName
    {
        get => new TerraformReference<string>(this, "s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? S3KeyPrefix
    {
        get => new TerraformReference<string>(this, "s3_key_prefix");
        set => SetArgument("s3_key_prefix", value);
    }

}


/// <summary>
/// Block type for placement in AwsImagebuilderInfrastructureConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderInfrastructureConfigurationPlacementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placement";

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformValue<string>? HostId
    {
        get => new TerraformReference<string>(this, "host_id");
        set => SetArgument("host_id", value);
    }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? HostResourceGroupArn
    {
        get => new TerraformReference<string>(this, "host_resource_group_arn");
        set => SetArgument("host_resource_group_arn", value);
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformValue<string>? Tenancy
    {
        get => new TerraformReference<string>(this, "tenancy");
        set => SetArgument("tenancy", value);
    }

}


/// <summary>
/// Represents a aws_imagebuilder_infrastructure_configuration Terraform resource.
/// Manages a aws_imagebuilder_infrastructure_configuration resource.
/// </summary>
public partial class AwsImagebuilderInfrastructureConfiguration(string name) : TerraformResource("aws_imagebuilder_infrastructure_configuration", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The instance_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProfileName is required")]
    public required TerraformValue<string> InstanceProfileName
    {
        get => new TerraformReference<string>(this, "instance_profile_name");
        set => SetArgument("instance_profile_name", value);
    }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public TerraformSet<string>? InstanceTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "instance_types").ResolveNodes(ctx));
        set => SetArgument("instance_types", value);
    }

    /// <summary>
    /// The key_pair attribute.
    /// </summary>
    public TerraformValue<string>? KeyPair
    {
        get => new TerraformReference<string>(this, "key_pair");
        set => SetArgument("key_pair", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The resource_tags attribute.
    /// </summary>
    public TerraformMap<string>? ResourceTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_tags").ResolveNodes(ctx));
        set => SetArgument("resource_tags", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? SnsTopicArn
    {
        get => new TerraformReference<string>(this, "sns_topic_arn");
        set => SetArgument("sns_topic_arn", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// The terminate_instance_on_failure attribute.
    /// </summary>
    public TerraformValue<bool>? TerminateInstanceOnFailure
    {
        get => new TerraformReference<bool>(this, "terminate_instance_on_failure");
        set => SetArgument("terminate_instance_on_failure", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformValue<string> DateCreated
    {
        get => new TerraformReference<string>(this, "date_created");
    }

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    public TerraformValue<string> DateUpdated
    {
        get => new TerraformReference<string>(this, "date_updated");
    }

    /// <summary>
    /// InstanceMetadataOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMetadataOptions block(s) allowed")]
    public TerraformList<AwsImagebuilderInfrastructureConfigurationInstanceMetadataOptionsBlock>? InstanceMetadataOptions
    {
        get => GetArgument<TerraformList<AwsImagebuilderInfrastructureConfigurationInstanceMetadataOptionsBlock>>("instance_metadata_options");
        set => SetArgument("instance_metadata_options", value);
    }

    /// <summary>
    /// Logging block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    public TerraformList<AwsImagebuilderInfrastructureConfigurationLoggingBlock>? Logging
    {
        get => GetArgument<TerraformList<AwsImagebuilderInfrastructureConfigurationLoggingBlock>>("logging");
        set => SetArgument("logging", value);
    }

    /// <summary>
    /// Placement block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    public TerraformList<AwsImagebuilderInfrastructureConfigurationPlacementBlock>? Placement
    {
        get => GetArgument<TerraformList<AwsImagebuilderInfrastructureConfigurationPlacementBlock>>("placement");
        set => SetArgument("placement", value);
    }

}
