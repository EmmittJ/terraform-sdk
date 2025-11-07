using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("asset_id");
        this.DeclareOutput("auto_placement");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("cores");
        this.DeclareOutput("host_recovery");
        this.DeclareOutput("instance_family");
        this.DeclareOutput("instance_type");
        this.DeclareOutput("outpost_arn");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("sockets");
        this.DeclareOutput("total_vcpus");
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostId
    {
        get => GetProperty<TerraformProperty<string>>("host_id");
        set => this.WithProperty("host_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
