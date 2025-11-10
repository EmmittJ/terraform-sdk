using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDxGatewayAssociationTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public HashSet<TerraformProperty<string>>? AllowedPrefixes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_prefixes");
        set => this.WithProperty("allowed_prefixes", value);
    }

    /// <summary>
    /// The associated_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? AssociatedGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("associated_gateway_id");
        set => this.WithProperty("associated_gateway_id", value);
    }

    /// <summary>
    /// The associated_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AssociatedGatewayOwnerAccountId
    {
        get => GetProperty<TerraformProperty<string>>("associated_gateway_owner_account_id");
        set => this.WithProperty("associated_gateway_owner_account_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The proposal_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProposalId
    {
        get => GetProperty<TerraformProperty<string>>("proposal_id");
        set => this.WithProperty("proposal_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDxGatewayAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDxGatewayAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
