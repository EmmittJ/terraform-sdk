using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsQuicksightAccountSettingsTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_account_settings resource.
/// </summary>
public class AwsQuicksightAccountSettings : TerraformResource
{
    public AwsQuicksightAccountSettings(string name) : base("aws_quicksight_account_settings", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AwsAccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aws_account_id");

    /// <summary>
    /// The default_namespace attribute.
    /// </summary>
    [TerraformPropertyName("default_namespace")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DefaultNamespace { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_namespace");

    /// <summary>
    /// The termination_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("termination_protection_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> TerminationProtectionEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "termination_protection_enabled");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsQuicksightAccountSettingsTimeoutsBlock>? Timeouts { get; set; } = new();

}
