using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_config in AwsEmrInstanceGroup.
/// Nesting mode: set
/// </summary>
public class AwsEmrInstanceGroupEbsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_config";

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
    {
        get => GetArgument<TerraformValue<double>>("iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<double> Size
    {
        get => GetRequiredArgument<TerraformValue<double>>("size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The volumes_per_instance attribute.
    /// </summary>
    public TerraformValue<double>? VolumesPerInstance
    {
        get => GetArgument<TerraformValue<double>>("volumes_per_instance");
        set => SetArgument("volumes_per_instance", value);
    }

}


/// <summary>
/// Represents a aws_emr_instance_group Terraform resource.
/// Manages a aws_emr_instance_group resource.
/// </summary>
public partial class AwsEmrInstanceGroup(string name) : TerraformResource("aws_emr_instance_group", name)
{
    /// <summary>
    /// The autoscaling_policy attribute.
    /// </summary>
    public TerraformValue<string>? AutoscalingPolicy
    {
        get => GetArgument<TerraformValue<string>>("autoscaling_policy");
        set => SetArgument("autoscaling_policy", value);
    }

    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    public TerraformValue<string>? BidPrice
    {
        get => GetArgument<TerraformValue<string>>("bid_price");
        set => SetArgument("bid_price", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The configurations_json attribute.
    /// </summary>
    public TerraformValue<string>? ConfigurationsJson
    {
        get => GetArgument<TerraformValue<string>>("configurations_json");
        set => SetArgument("configurations_json", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformValue<bool>? EbsOptimized
    {
        get => GetArgument<TerraformValue<bool>>("ebs_optimized");
        set => SetArgument("ebs_optimized", value);
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
    /// The instance_count attribute.
    /// </summary>
    public TerraformValue<double> InstanceCount
    {
        get => GetArgument<TerraformValue<double>>("instance_count") ?? CreateReference("instance_count");
        set => SetArgument("instance_count", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
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
    /// The running_instance_count attribute.
    /// </summary>
    public TerraformValue<double> RunningInstanceCount
        => CreateReference("running_instance_count");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// EbsConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEmrInstanceGroupEbsConfigBlock>? EbsConfig
    {
        get => GetArgument<TerraformSet<AwsEmrInstanceGroupEbsConfigBlock>>("ebs_config");
        set => SetArgument("ebs_config", value);
    }

}
