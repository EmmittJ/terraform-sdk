using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDxHostedTransitVirtualInterfaceAccepter.
/// Nesting mode: single
/// </summary>
public class AwsDxHostedTransitVirtualInterfaceAccepterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_dx_hosted_transit_virtual_interface_accepter Terraform resource.
/// Manages a aws_dx_hosted_transit_virtual_interface_accepter resource.
/// </summary>
public partial class AwsDxHostedTransitVirtualInterfaceAccepter(string name) : TerraformResource("aws_dx_hosted_transit_virtual_interface_accepter", name)
{
    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayId is required")]
    public required TerraformValue<string> DxGatewayId
    {
        get => GetArgument<TerraformValue<string>>("dx_gateway_id");
        set => SetArgument("dx_gateway_id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The virtual_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualInterfaceId is required")]
    public required TerraformValue<string> VirtualInterfaceId
    {
        get => GetArgument<TerraformValue<string>>("virtual_interface_id");
        set => SetArgument("virtual_interface_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDxHostedTransitVirtualInterfaceAccepterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDxHostedTransitVirtualInterfaceAccepterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
