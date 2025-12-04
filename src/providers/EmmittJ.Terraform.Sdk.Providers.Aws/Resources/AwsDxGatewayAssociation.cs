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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
    public TerraformSet<string>? AllowedPrefixes
    {
        get => GetArgument<TerraformSet<string>>("allowed_prefixes");
        set => SetArgument("allowed_prefixes", value);
    }

    /// <summary>
    /// The associated_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? AssociatedGatewayId
    {
        get => GetArgument<TerraformValue<string>>("associated_gateway_id");
        set => SetArgument("associated_gateway_id", value);
    }

    /// <summary>
    /// The associated_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformValue<string>? AssociatedGatewayOwnerAccountId
    {
        get => GetArgument<TerraformValue<string>>("associated_gateway_owner_account_id");
        set => SetArgument("associated_gateway_owner_account_id", value);
    }

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayId is required")]
    public required TerraformValue<string> DxGatewayId
    {
        get => GetArgument<TerraformValue<string>>("dx_gateway_id");
        set => SetArgument("dx_gateway_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The proposal_id attribute.
    /// </summary>
    public TerraformValue<string>? ProposalId
    {
        get => GetArgument<TerraformValue<string>>("proposal_id");
        set => SetArgument("proposal_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The associated_gateway_type attribute.
    /// </summary>
    public TerraformValue<string> AssociatedGatewayType
        => AsReference("associated_gateway_type");

    /// <summary>
    /// The dx_gateway_association_id attribute.
    /// </summary>
    public TerraformValue<string> DxGatewayAssociationId
        => AsReference("dx_gateway_association_id");

    /// <summary>
    /// The dx_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> DxGatewayOwnerAccountId
        => AsReference("dx_gateway_owner_account_id");

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayAttachmentId
        => AsReference("transit_gateway_attachment_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDxGatewayAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDxGatewayAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
