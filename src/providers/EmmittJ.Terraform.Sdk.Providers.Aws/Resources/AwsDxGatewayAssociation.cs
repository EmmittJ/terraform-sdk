using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDxGatewayAssociation.
/// Nesting mode: single
/// </summary>
public class AwsDxGatewayAssociationTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_dx_gateway_association Terraform resource.
/// Manages a aws_dx_gateway_association resource.
/// </summary>
public partial class AwsDxGatewayAssociation(string name) : TerraformResource("aws_dx_gateway_association", name)
{
    /// <summary>
    /// The allowed_prefixes attribute.
    /// </summary>
    public TerraformSet<string> AllowedPrefixes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_prefixes").ResolveNodes(ctx));
        set => SetArgument("allowed_prefixes", value);
    }

    /// <summary>
    /// The associated_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> AssociatedGatewayId
    {
        get => new TerraformReference<string>(this, "associated_gateway_id");
        set => SetArgument("associated_gateway_id", value);
    }

    /// <summary>
    /// The associated_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> AssociatedGatewayOwnerAccountId
    {
        get => new TerraformReference<string>(this, "associated_gateway_owner_account_id");
        set => SetArgument("associated_gateway_owner_account_id", value);
    }

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayId is required")]
    public required TerraformValue<string> DxGatewayId
    {
        get => new TerraformReference<string>(this, "dx_gateway_id");
        set => SetArgument("dx_gateway_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The proposal_id attribute.
    /// </summary>
    public TerraformValue<string>? ProposalId
    {
        get => new TerraformReference<string>(this, "proposal_id");
        set => SetArgument("proposal_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The associated_gateway_type attribute.
    /// </summary>
    public TerraformValue<string> AssociatedGatewayType
    {
        get => new TerraformReference<string>(this, "associated_gateway_type");
    }

    /// <summary>
    /// The dx_gateway_association_id attribute.
    /// </summary>
    public TerraformValue<string> DxGatewayAssociationId
    {
        get => new TerraformReference<string>(this, "dx_gateway_association_id");
    }

    /// <summary>
    /// The dx_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> DxGatewayOwnerAccountId
    {
        get => new TerraformReference<string>(this, "dx_gateway_owner_account_id");
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayAttachmentId
    {
        get => new TerraformReference<string>(this, "transit_gateway_attachment_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDxGatewayAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDxGatewayAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
