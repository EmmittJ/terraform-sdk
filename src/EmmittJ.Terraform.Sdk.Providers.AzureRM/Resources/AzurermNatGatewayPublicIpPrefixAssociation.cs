using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNatGatewayPublicIpPrefixAssociationTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_nat_gateway_public_ip_prefix_association resource.
/// </summary>
public class AzurermNatGatewayPublicIpPrefixAssociation : TerraformResource
{
    public AzurermNatGatewayPublicIpPrefixAssociation(string name) : base("azurerm_nat_gateway_public_ip_prefix_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The nat_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NatGatewayId is required")]
    public required TerraformProperty<string> NatGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("nat_gateway_id");
        set => this.WithProperty("nat_gateway_id", value);
    }

    /// <summary>
    /// The public_ip_prefix_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpPrefixId is required")]
    public required TerraformProperty<string> PublicIpPrefixId
    {
        get => GetProperty<TerraformProperty<string>>("public_ip_prefix_id");
        set => this.WithProperty("public_ip_prefix_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNatGatewayPublicIpPrefixAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNatGatewayPublicIpPrefixAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
