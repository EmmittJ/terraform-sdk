using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSubnetNatGatewayAssociation.
/// Nesting mode: single
/// </summary>
public class AzurermSubnetNatGatewayAssociationTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

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
/// Represents a azurerm_subnet_nat_gateway_association Terraform resource.
/// Manages a azurerm_subnet_nat_gateway_association resource.
/// </summary>
public partial class AzurermSubnetNatGatewayAssociation(string name) : TerraformResource("azurerm_subnet_nat_gateway_association", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The nat_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NatGatewayId is required")]
    public required TerraformValue<string> NatGatewayId
    {
        get => new TerraformReference<string>(this, "nat_gateway_id");
        set => SetArgument("nat_gateway_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSubnetNatGatewayAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSubnetNatGatewayAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
