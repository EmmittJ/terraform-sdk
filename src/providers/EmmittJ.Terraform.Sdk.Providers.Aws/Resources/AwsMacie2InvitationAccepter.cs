using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMacie2InvitationAccepterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

}

/// <summary>
/// Manages a aws_macie2_invitation_accepter resource.
/// </summary>
public class AwsMacie2InvitationAccepter : TerraformResource
{
    public AwsMacie2InvitationAccepter(string name) : base("aws_macie2_invitation_accepter", name)
    {
    }

    /// <summary>
    /// The administrator_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorAccountId is required")]
    [TerraformPropertyName("administrator_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AdministratorAccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMacie2InvitationAccepterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The invitation_id attribute.
    /// </summary>
    [TerraformPropertyName("invitation_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InvitationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "invitation_id");

}
