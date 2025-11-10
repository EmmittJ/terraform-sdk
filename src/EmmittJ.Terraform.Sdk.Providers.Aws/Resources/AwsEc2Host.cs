using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2HostTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_ec2_host resource.
/// </summary>
public class AwsEc2Host : TerraformResource
{
    public AwsEc2Host(string name) : base("aws_ec2_host", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("owner_id");
    }

    /// <summary>
    /// The asset_id attribute.
    /// </summary>
    public TerraformProperty<string>? AssetId
    {
        get => GetProperty<TerraformProperty<string>>("asset_id");
        set => this.WithProperty("asset_id", value);
    }

    /// <summary>
    /// The auto_placement attribute.
    /// </summary>
    public TerraformProperty<string>? AutoPlacement
    {
        get => GetProperty<TerraformProperty<string>>("auto_placement");
        set => this.WithProperty("auto_placement", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZone is required")]
    public required TerraformProperty<string> AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The host_recovery attribute.
    /// </summary>
    public TerraformProperty<string>? HostRecovery
    {
        get => GetProperty<TerraformProperty<string>>("host_recovery");
        set => this.WithProperty("host_recovery", value);
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
    /// The instance_family attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceFamily
    {
        get => GetProperty<TerraformProperty<string>>("instance_family");
        set => this.WithProperty("instance_family", value);
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
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformProperty<string>? OutpostArn
    {
        get => GetProperty<TerraformProperty<string>>("outpost_arn");
        set => this.WithProperty("outpost_arn", value);
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2HostTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEc2HostTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
