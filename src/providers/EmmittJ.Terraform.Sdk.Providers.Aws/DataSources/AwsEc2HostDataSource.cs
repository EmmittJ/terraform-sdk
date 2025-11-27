using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEc2HostDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEc2HostDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEc2HostDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEc2HostDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_ec2_host Terraform data source.
/// Retrieves information about a aws_ec2_host.
/// </summary>
public partial class AwsEc2HostDataSource(string name) : TerraformDataSource("aws_ec2_host", name)
{
    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformValue<string> HostId
    {
        get => new TerraformReference<string>(this, "host_id");
        set => SetArgument("host_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The asset_id attribute.
    /// </summary>
    public TerraformValue<string> AssetId
    {
        get => new TerraformReference<string>(this, "asset_id");
    }

    /// <summary>
    /// The auto_placement attribute.
    /// </summary>
    public TerraformValue<string> AutoPlacement
    {
        get => new TerraformReference<string>(this, "auto_placement");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
    }

    /// <summary>
    /// The cores attribute.
    /// </summary>
    public TerraformValue<double> Cores
    {
        get => new TerraformReference<double>(this, "cores");
    }

    /// <summary>
    /// The host_recovery attribute.
    /// </summary>
    public TerraformValue<string> HostRecovery
    {
        get => new TerraformReference<string>(this, "host_recovery");
    }

    /// <summary>
    /// The instance_family attribute.
    /// </summary>
    public TerraformValue<string> InstanceFamily
    {
        get => new TerraformReference<string>(this, "instance_family");
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> OutpostArn
    {
        get => new TerraformReference<string>(this, "outpost_arn");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The sockets attribute.
    /// </summary>
    public TerraformValue<double> Sockets
    {
        get => new TerraformReference<double>(this, "sockets");
    }

    /// <summary>
    /// The total_vcpus attribute.
    /// </summary>
    public TerraformValue<double> TotalVcpus
    {
        get => new TerraformReference<double>(this, "total_vcpus");
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2HostDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2HostDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2HostDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2HostDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
