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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        SetOutput("id");
        SetOutput("nat_gateway_id");
        SetOutput("public_ip_prefix_id");
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
    /// The nat_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NatGatewayId is required")]
    public required TerraformProperty<string> NatGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("nat_gateway_id");
        set => SetProperty("nat_gateway_id", value);
    }

    /// <summary>
    /// The public_ip_prefix_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpPrefixId is required")]
    public required TerraformProperty<string> PublicIpPrefixId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_ip_prefix_id");
        set => SetProperty("public_ip_prefix_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNatGatewayPublicIpPrefixAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
