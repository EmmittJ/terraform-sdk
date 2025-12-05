using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dx_gateway_association_proposal Terraform resource.
/// Manages a aws_dx_gateway_association_proposal resource.
/// </summary>
public partial class AwsDxGatewayAssociationProposal(string name) : TerraformResource("aws_dx_gateway_association_proposal", name)
{
    /// <summary>
    /// The allowed_prefixes attribute.
    /// </summary>
    public TerraformSet<string> AllowedPrefixes
    {
        get => GetArgument<TerraformSet<string>>("allowed_prefixes") ?? CreateReference("allowed_prefixes");
        set => SetArgument("allowed_prefixes", value);
    }

    /// <summary>
    /// The associated_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociatedGatewayId is required")]
    public required TerraformValue<string> AssociatedGatewayId
    {
        get => GetRequiredArgument<TerraformValue<string>>("associated_gateway_id");
        set => SetArgument("associated_gateway_id", value);
    }

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayId is required")]
    public required TerraformValue<string> DxGatewayId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dx_gateway_id");
        set => SetArgument("dx_gateway_id", value);
    }

    /// <summary>
    /// The dx_gateway_owner_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayOwnerAccountId is required")]
    public required TerraformValue<string> DxGatewayOwnerAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dx_gateway_owner_account_id");
        set => SetArgument("dx_gateway_owner_account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The associated_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> AssociatedGatewayOwnerAccountId
        => CreateReference("associated_gateway_owner_account_id");

    /// <summary>
    /// The associated_gateway_type attribute.
    /// </summary>
    public TerraformValue<string> AssociatedGatewayType
        => CreateReference("associated_gateway_type");

}
