using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("running_instance_count");
        this.DeclareOutput("status");
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
    public TerraformProperty<string>? ClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_id");
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
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
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
    /// The running_instance_count attribute.
    /// </summary>
    public TerraformExpression RunningInstanceCount => this["running_instance_count"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
