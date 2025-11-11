using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_macsec_key_association resource.
/// </summary>
public partial class AwsDxMacsecKeyAssociation : TerraformResource
{
    public AwsDxMacsecKeyAssociation(string name) : base("aws_dx_macsec_key_association", name)
    {
    }

    /// <summary>
    /// The cak attribute.
    /// </summary>
    [TerraformProperty("cak")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Cak { get; set; }

    /// <summary>
    /// The ckn attribute.
    /// </summary>
    [TerraformProperty("ckn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Ckn { get; set; }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformProperty("connection_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectionId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    [TerraformProperty("secret_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SecretArn { get; set; }

    /// <summary>
    /// The start_on attribute.
    /// </summary>
    [TerraformProperty("start_on")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StartOn { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
