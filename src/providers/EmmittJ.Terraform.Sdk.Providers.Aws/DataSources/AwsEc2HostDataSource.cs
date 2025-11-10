using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2HostDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2HostDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a aws_ec2_host.
/// </summary>
public class AwsEc2HostDataSource : TerraformDataSource
{
    public AwsEc2HostDataSource(string name) : base("aws_ec2_host", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("asset_id");
        SetOutput("auto_placement");
        SetOutput("availability_zone");
        SetOutput("cores");
        SetOutput("host_recovery");
        SetOutput("instance_family");
        SetOutput("instance_type");
        SetOutput("outpost_arn");
        SetOutput("owner_id");
        SetOutput("sockets");
        SetOutput("total_vcpus");
        SetOutput("host_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformProperty<string> HostId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_id");
        set => SetProperty("host_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEc2HostDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2HostDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The asset_id attribute.
    /// </summary>
    public TerraformExpression AssetId => this["asset_id"];

    /// <summary>
    /// The auto_placement attribute.
    /// </summary>
    public TerraformExpression AutoPlacement => this["auto_placement"];

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The cores attribute.
    /// </summary>
    public TerraformExpression Cores => this["cores"];

    /// <summary>
    /// The host_recovery attribute.
    /// </summary>
    public TerraformExpression HostRecovery => this["host_recovery"];

    /// <summary>
    /// The instance_family attribute.
    /// </summary>
    public TerraformExpression InstanceFamily => this["instance_family"];

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformExpression InstanceType => this["instance_type"];

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformExpression OutpostArn => this["outpost_arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The sockets attribute.
    /// </summary>
    public TerraformExpression Sockets => this["sockets"];

    /// <summary>
    /// The total_vcpus attribute.
    /// </summary>
    public TerraformExpression TotalVcpus => this["total_vcpus"];

}
