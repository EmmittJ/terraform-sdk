using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRamResourceShareAccepterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_ram_resource_share_accepter resource.
/// </summary>
public class AwsRamResourceShareAccepter : TerraformResource
{
    public AwsRamResourceShareAccepter(string name) : base("aws_ram_resource_share_accepter", name)
    {
    }

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
    /// The share_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareArn is required")]
    [TerraformPropertyName("share_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ShareArn { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRamResourceShareAccepterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The invitation_arn attribute.
    /// </summary>
    [TerraformPropertyName("invitation_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InvitationArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "invitation_arn");

    /// <summary>
    /// The receiver_account_id attribute.
    /// </summary>
    [TerraformPropertyName("receiver_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReceiverAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "receiver_account_id");

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformPropertyName("resources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Resources => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "resources");

    /// <summary>
    /// The sender_account_id attribute.
    /// </summary>
    [TerraformPropertyName("sender_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SenderAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sender_account_id");

    /// <summary>
    /// The share_id attribute.
    /// </summary>
    [TerraformPropertyName("share_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ShareId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "share_id");

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [TerraformPropertyName("share_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ShareName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "share_name");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
