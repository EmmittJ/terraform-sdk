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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("owner_id");
        SetOutput("asset_id");
        SetOutput("auto_placement");
        SetOutput("availability_zone");
        SetOutput("host_recovery");
        SetOutput("id");
        SetOutput("instance_family");
        SetOutput("instance_type");
        SetOutput("outpost_arn");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The asset_id attribute.
    /// </summary>
    public TerraformProperty<string> AssetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("asset_id");
        set => SetProperty("asset_id", value);
    }

    /// <summary>
    /// The auto_placement attribute.
    /// </summary>
    public TerraformProperty<string> AutoPlacement
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_placement");
        set => SetProperty("auto_placement", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZone is required")]
    public required TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone");
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The host_recovery attribute.
    /// </summary>
    public TerraformProperty<string> HostRecovery
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_recovery");
        set => SetProperty("host_recovery", value);
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
    /// The instance_family attribute.
    /// </summary>
    public TerraformProperty<string> InstanceFamily
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_family");
        set => SetProperty("instance_family", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string> InstanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_type");
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformProperty<string> OutpostArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("outpost_arn");
        set => SetProperty("outpost_arn", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2HostTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
