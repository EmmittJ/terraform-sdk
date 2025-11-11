using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_lag resource.
/// </summary>
public partial class AwsDxLag : TerraformResource
{
    public AwsDxLag(string name) : base("aws_dx_lag", name)
    {
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [TerraformProperty("connection_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionId { get; set; }

    /// <summary>
    /// The connections_bandwidth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionsBandwidth is required")]
    [TerraformProperty("connections_bandwidth")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectionsBandwidth { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformProperty("provider_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ProviderName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The has_logical_redundancy attribute.
    /// </summary>
    [TerraformProperty("has_logical_redundancy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HasLogicalRedundancy { get; }

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    [TerraformProperty("jumbo_frame_capable")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> JumboFrameCapable { get; }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformProperty("owner_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerAccountId { get; }

}
