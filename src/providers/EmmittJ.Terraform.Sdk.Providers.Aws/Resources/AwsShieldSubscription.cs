using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_shield_subscription resource.
/// </summary>
public class AwsShieldSubscription : TerraformResource
{
    public AwsShieldSubscription(string name) : base("aws_shield_subscription", name)
    {
    }

    /// <summary>
    /// Whether to automatically renew the subscription when it expires.
    /// </summary>
    [TerraformPropertyName("auto_renew")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AutoRenew { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "auto_renew");

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformPropertyName("skip_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
