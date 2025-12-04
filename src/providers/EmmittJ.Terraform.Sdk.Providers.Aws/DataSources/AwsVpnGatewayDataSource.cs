using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsVpnGatewayDataSource.
/// Nesting mode: set
/// </summary>
public class AwsVpnGatewayDataSourceFilterBlock : TerraformBlock
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
/// Block type for timeouts in AwsVpnGatewayDataSource.
/// Nesting mode: single
/// </summary>
public class AwsVpnGatewayDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_vpn_gateway Terraform data source.
/// Retrieves information about a aws_vpn_gateway.
/// </summary>
public partial class AwsVpnGatewayDataSource(string name) : TerraformDataSource("aws_vpn_gateway", name)
{
    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    public TerraformValue<string>? AmazonSideAsn
    {
        get => GetArgument<TerraformValue<string>>("amazon_side_asn");
        set => SetArgument("amazon_side_asn", value);
    }

    /// <summary>
    /// The attached_vpc_id attribute.
    /// </summary>
    public TerraformValue<string>? AttachedVpcId
    {
        get => GetArgument<TerraformValue<string>>("attached_vpc_id");
        set => SetArgument("attached_vpc_id", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsVpnGatewayDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsVpnGatewayDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpnGatewayDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpnGatewayDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
