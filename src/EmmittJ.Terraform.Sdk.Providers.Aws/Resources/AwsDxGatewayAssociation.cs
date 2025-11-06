using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_gateway_association resource.
/// </summary>
public class AwsDxGatewayAssociation : TerraformResource
{
    public AwsDxGatewayAssociation(string name) : base("aws_dx_gateway_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("associated_gateway_type");
        this.DeclareOutput("dx_gateway_association_id");
        this.DeclareOutput("dx_gateway_owner_account_id");
        this.DeclareOutput("transit_gateway_attachment_id");
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
    /// The associated_gateway_owner_account_id attribute.
    /// </summary>
    public string? AssociatedGatewayOwnerAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("associated_gateway_owner_account_id")?.Value;
        set => this.WithProperty("associated_gateway_owner_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The proposal_id attribute.
    /// </summary>
    public string? ProposalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("proposal_id")?.Value;
        set => this.WithProperty("proposal_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The associated_gateway_type attribute.
    /// </summary>
    public TerraformExpression AssociatedGatewayType => this["associated_gateway_type"];

    /// <summary>
    /// The dx_gateway_association_id attribute.
    /// </summary>
    public TerraformExpression DxGatewayAssociationId => this["dx_gateway_association_id"];

    /// <summary>
    /// The dx_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformExpression DxGatewayOwnerAccountId => this["dx_gateway_owner_account_id"];

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayAttachmentId => this["transit_gateway_attachment_id"];

}
