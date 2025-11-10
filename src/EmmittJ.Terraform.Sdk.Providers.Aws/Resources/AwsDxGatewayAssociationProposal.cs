using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_gateway_association_proposal resource.
/// </summary>
public class AwsDxGatewayAssociationProposal : TerraformResource
{
    public AwsDxGatewayAssociationProposal(string name) : base("aws_dx_gateway_association_proposal", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("associated_gateway_owner_account_id");
        this.DeclareOutput("associated_gateway_type");
    }

    /// <summary>
    /// The allowed_prefixes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedPrefixes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_prefixes");
        set => this.WithProperty("allowed_prefixes", value);
    }

    /// <summary>
    /// The associated_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociatedGatewayId is required")]
    public required TerraformProperty<string> AssociatedGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("associated_gateway_id");
        set => this.WithProperty("associated_gateway_id", value);
    }

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayId is required")]
    public required TerraformProperty<string> DxGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("dx_gateway_id");
        set => this.WithProperty("dx_gateway_id", value);
    }

    /// <summary>
    /// The dx_gateway_owner_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayOwnerAccountId is required")]
    public required TerraformProperty<string> DxGatewayOwnerAccountId
    {
        get => GetProperty<TerraformProperty<string>>("dx_gateway_owner_account_id");
        set => this.WithProperty("dx_gateway_owner_account_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The associated_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformExpression AssociatedGatewayOwnerAccountId => this["associated_gateway_owner_account_id"];

    /// <summary>
    /// The associated_gateway_type attribute.
    /// </summary>
    public TerraformExpression AssociatedGatewayType => this["associated_gateway_type"];

}
