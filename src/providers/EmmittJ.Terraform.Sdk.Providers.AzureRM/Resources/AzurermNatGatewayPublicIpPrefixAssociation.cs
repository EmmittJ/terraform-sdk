using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNatGatewayPublicIpPrefixAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_nat_gateway_public_ip_prefix_association Terraform resource.
/// Manages a azurerm_nat_gateway_public_ip_prefix_association resource.
/// </summary>
public partial class AzurermNatGatewayPublicIpPrefixAssociation(string name) : TerraformResource("azurerm_nat_gateway_public_ip_prefix_association", name)
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
    /// The public_ip_prefix_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpPrefixId is required")]
    public required TerraformValue<string> PublicIpPrefixId
    {
        get => new TerraformReference<string>(this, "public_ip_prefix_id");
        set => SetArgument("public_ip_prefix_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNatGatewayPublicIpPrefixAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNatGatewayPublicIpPrefixAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
