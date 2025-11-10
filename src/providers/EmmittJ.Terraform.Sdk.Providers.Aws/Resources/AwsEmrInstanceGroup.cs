using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_config in .
/// Nesting mode: set
/// </summary>
public class AwsEmrInstanceGroupEbsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        set => SetProperty("iops", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<double> Size
    {
        set => SetProperty("size", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The volumes_per_instance attribute.
    /// </summary>
    public TerraformProperty<double>? VolumesPerInstance
    {
        set => SetProperty("volumes_per_instance", value);
    }

}

/// <summary>
/// Manages a aws_emr_instance_group resource.
/// </summary>
public class AwsEmrInstanceGroup : TerraformResource
{
    public AwsEmrInstanceGroup(string name) : base("aws_emr_instance_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("running_instance_count");
        SetOutput("status");
        SetOutput("autoscaling_policy");
        SetOutput("bid_price");
        SetOutput("cluster_id");
        SetOutput("configurations_json");
        SetOutput("ebs_optimized");
        SetOutput("id");
        SetOutput("instance_count");
        SetOutput("instance_type");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The autoscaling_policy attribute.
    /// </summary>
    public TerraformProperty<string> AutoscalingPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("autoscaling_policy");
        set => SetProperty("autoscaling_policy", value);
    }

    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    public TerraformProperty<string> BidPrice
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bid_price");
        set => SetProperty("bid_price", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_id");
        set => SetProperty("cluster_id", value);
    }

    /// <summary>
    /// The configurations_json attribute.
    /// </summary>
    public TerraformProperty<string> ConfigurationsJson
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configurations_json");
        set => SetProperty("configurations_json", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformProperty<bool> EbsOptimized
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ebs_optimized");
        set => SetProperty("ebs_optimized", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double> InstanceCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("instance_count");
        set => SetProperty("instance_count", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_type");
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for ebs_config.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEmrInstanceGroupEbsConfigBlock>? EbsConfig
    {
        set => SetProperty("ebs_config", value);
    }

    /// <summary>
    /// The running_instance_count attribute.
    /// </summary>
    public TerraformExpression RunningInstanceCount => this["running_instance_count"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
