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
        get => GetProperty<TerraformProperty<double>>("iops");
        set => WithProperty("iops", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<double> Size
    {
        get => GetRequiredProperty<TerraformProperty<double>>("size");
        set => WithProperty("size", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The volumes_per_instance attribute.
    /// </summary>
    public TerraformProperty<double>? VolumesPerInstance
    {
        get => GetProperty<TerraformProperty<double>>("volumes_per_instance");
        set => WithProperty("volumes_per_instance", value);
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
        this.WithOutput("running_instance_count");
        this.WithOutput("status");
    }

    /// <summary>
    /// The autoscaling_policy attribute.
    /// </summary>
    public TerraformProperty<string>? AutoscalingPolicy
    {
        get => GetProperty<TerraformProperty<string>>("autoscaling_policy");
        set => this.WithProperty("autoscaling_policy", value);
    }

    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    public TerraformProperty<string>? BidPrice
    {
        get => GetProperty<TerraformProperty<string>>("bid_price");
        set => this.WithProperty("bid_price", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
    }

    /// <summary>
    /// The configurations_json attribute.
    /// </summary>
    public TerraformProperty<string>? ConfigurationsJson
    {
        get => GetProperty<TerraformProperty<string>>("configurations_json");
        set => this.WithProperty("configurations_json", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformProperty<bool>? EbsOptimized
    {
        get => GetProperty<TerraformProperty<bool>>("ebs_optimized");
        set => this.WithProperty("ebs_optimized", value);
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
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("instance_count");
        set => this.WithProperty("instance_count", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for ebs_config.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEmrInstanceGroupEbsConfigBlock>? EbsConfig
    {
        get => GetProperty<HashSet<AwsEmrInstanceGroupEbsConfigBlock>>("ebs_config");
        set => this.WithProperty("ebs_config", value);
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
