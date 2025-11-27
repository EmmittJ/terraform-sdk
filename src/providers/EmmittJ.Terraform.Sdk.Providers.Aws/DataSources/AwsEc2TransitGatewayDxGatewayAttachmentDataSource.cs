using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEc2TransitGatewayDxGatewayAttachmentDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayDxGatewayAttachmentDataSourceFilterBlock : TerraformBlock
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
/// Block type for timeouts in AwsEc2TransitGatewayDxGatewayAttachmentDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayDxGatewayAttachmentDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_ec2_transit_gateway_dx_gateway_attachment Terraform data source.
/// Retrieves information about a aws_ec2_transit_gateway_dx_gateway_attachment.
/// </summary>
public partial class AwsEc2TransitGatewayDxGatewayAttachmentDataSource(string name) : TerraformDataSource("aws_ec2_transit_gateway_dx_gateway_attachment", name)
{
    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? DxGatewayId
    {
        get => new TerraformReference<string>(this, "dx_gateway_id");
        set => SetArgument("dx_gateway_id", value);
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
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? TransitGatewayId
    {
        get => new TerraformReference<string>(this, "transit_gateway_id");
        set => SetArgument("transit_gateway_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2TransitGatewayDxGatewayAttachmentDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2TransitGatewayDxGatewayAttachmentDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2TransitGatewayDxGatewayAttachmentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2TransitGatewayDxGatewayAttachmentDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
