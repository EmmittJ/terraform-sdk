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
        SetOutput("associated_gateway_owner_account_id");
        SetOutput("associated_gateway_type");
        SetOutput("allowed_prefixes");
        SetOutput("associated_gateway_id");
        SetOutput("dx_gateway_id");
        SetOutput("dx_gateway_owner_account_id");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The allowed_prefixes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AllowedPrefixes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("allowed_prefixes");
        set => SetProperty("allowed_prefixes", value);
    }

    /// <summary>
    /// The associated_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociatedGatewayId is required")]
    public required TerraformProperty<string> AssociatedGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("associated_gateway_id");
        set => SetProperty("associated_gateway_id", value);
    }

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayId is required")]
    public required TerraformProperty<string> DxGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dx_gateway_id");
        set => SetProperty("dx_gateway_id", value);
    }

    /// <summary>
    /// The dx_gateway_owner_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayOwnerAccountId is required")]
    public required TerraformProperty<string> DxGatewayOwnerAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dx_gateway_owner_account_id");
        set => SetProperty("dx_gateway_owner_account_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
