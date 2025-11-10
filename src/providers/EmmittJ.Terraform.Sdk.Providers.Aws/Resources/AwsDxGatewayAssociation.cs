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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("associated_gateway_type");
        SetOutput("dx_gateway_association_id");
        SetOutput("dx_gateway_owner_account_id");
        SetOutput("transit_gateway_attachment_id");
        SetOutput("allowed_prefixes");
        SetOutput("associated_gateway_id");
        SetOutput("associated_gateway_owner_account_id");
        SetOutput("dx_gateway_id");
        SetOutput("id");
        SetOutput("proposal_id");
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
    public TerraformProperty<string> AssociatedGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("associated_gateway_id");
        set => SetProperty("associated_gateway_id", value);
    }

    /// <summary>
    /// The associated_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformProperty<string> AssociatedGatewayOwnerAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("associated_gateway_owner_account_id");
        set => SetProperty("associated_gateway_owner_account_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The proposal_id attribute.
    /// </summary>
    public TerraformProperty<string> ProposalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("proposal_id");
        set => SetProperty("proposal_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDxGatewayAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
