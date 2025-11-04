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
    public HashSet<string>? AllowedPrefixes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("allowed_prefixes")?.Value;
        set => this.WithProperty("allowed_prefixes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The associated_gateway_id attribute.
    /// </summary>
    public string? AssociatedGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("associated_gateway_id")?.Value;
        set => this.WithProperty("associated_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    public string? DxGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dx_gateway_id")?.Value;
        set => this.WithProperty("dx_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dx_gateway_owner_account_id attribute.
    /// </summary>
    public string? DxGatewayOwnerAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dx_gateway_owner_account_id")?.Value;
        set => this.WithProperty("dx_gateway_owner_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
