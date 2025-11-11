using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_shield_subscription resource.
/// </summary>
public partial class AwsShieldSubscription : TerraformResource
{
    public AwsShieldSubscription(string name) : base("aws_shield_subscription", name)
    {
    }

    /// <summary>
    /// Whether to automatically renew the subscription when it expires.
    /// </summary>
    [TerraformProperty("auto_renew")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AutoRenew { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformProperty("skip_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
