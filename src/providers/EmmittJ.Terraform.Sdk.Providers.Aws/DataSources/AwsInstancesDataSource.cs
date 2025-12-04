using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsInstancesDataSource.
/// Nesting mode: set
/// </summary>
public class AwsInstancesDataSourceFilterBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsInstancesDataSource.
/// Nesting mode: single
/// </summary>
public class AwsInstancesDataSourceTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_instances Terraform data source.
/// Retrieves information about a aws_instances.
/// </summary>
public partial class AwsInstancesDataSource(string name) : TerraformDataSource("aws_instances", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_state_names attribute.
    /// </summary>
    public TerraformSet<string>? InstanceStateNames
    {
        get => GetArgument<TerraformSet<string>>("instance_state_names");
        set => SetArgument("instance_state_names", value);
    }

    /// <summary>
    /// The instance_tags attribute.
    /// </summary>
    public TerraformMap<string> InstanceTags
    {
        get => GetArgument<TerraformMap<string>>("instance_tags") ?? AsReference("instance_tags");
        set => SetArgument("instance_tags", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformList<string> Ids
        => AsReference("ids");

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformList<string> Ipv6Addresses
        => AsReference("ipv6_addresses");

    /// <summary>
    /// The private_ips attribute.
    /// </summary>
    public TerraformList<string> PrivateIps
        => AsReference("private_ips");

    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    public TerraformList<string> PublicIps
        => AsReference("public_ips");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInstancesDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsInstancesDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsInstancesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsInstancesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
