using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEc2LocalGatewayVirtualInterfaceGroupDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEc2LocalGatewayVirtualInterfaceGroupDataSourceFilterBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEc2LocalGatewayVirtualInterfaceGroupDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEc2LocalGatewayVirtualInterfaceGroupDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_ec2_local_gateway_virtual_interface_group Terraform data source.
/// Retrieves information about a aws_ec2_local_gateway_virtual_interface_group.
/// </summary>
public partial class AwsEc2LocalGatewayVirtualInterfaceGroupDataSource(string name) : TerraformDataSource("aws_ec2_local_gateway_virtual_interface_group", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? LocalGatewayId
    {
        get => GetArgument<TerraformValue<string>>("local_gateway_id");
        set => SetArgument("local_gateway_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The local_gateway_virtual_interface_ids attribute.
    /// </summary>
    public TerraformSet<string> LocalGatewayVirtualInterfaceIds
        => AsReference("local_gateway_virtual_interface_ids");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2LocalGatewayVirtualInterfaceGroupDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2LocalGatewayVirtualInterfaceGroupDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2LocalGatewayVirtualInterfaceGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2LocalGatewayVirtualInterfaceGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
