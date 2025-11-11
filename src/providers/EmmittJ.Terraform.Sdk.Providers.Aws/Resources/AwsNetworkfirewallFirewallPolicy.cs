using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallPolicyEncryptionConfigurationBlock
{
    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyId { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for firewall_policy in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock
{
    /// <summary>
    /// The stateful_default_actions attribute.
    /// </summary>
    [TerraformPropertyName("stateful_default_actions")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? StatefulDefaultActions { get; set; }

    /// <summary>
    /// The stateless_default_actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatelessDefaultActions is required")]
    [TerraformPropertyName("stateless_default_actions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> StatelessDefaultActions { get; set; }

    /// <summary>
    /// The stateless_fragment_default_actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatelessFragmentDefaultActions is required")]
    [TerraformPropertyName("stateless_fragment_default_actions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> StatelessFragmentDefaultActions { get; set; }

    /// <summary>
    /// The tls_inspection_configuration_arn attribute.
    /// </summary>
    [TerraformPropertyName("tls_inspection_configuration_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TlsInspectionConfigurationArn { get; set; }

}

/// <summary>
/// Manages a aws_networkfirewall_firewall_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsNetworkfirewallFirewallPolicy : TerraformResource
{
    public AwsNetworkfirewallFirewallPolicy(string name) : base("aws_networkfirewall_firewall_policy", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    [TerraformPropertyName("encryption_configuration")]
    public TerraformList<TerraformBlock<AwsNetworkfirewallFirewallPolicyEncryptionConfigurationBlock>>? EncryptionConfiguration { get; set; }

    /// <summary>
    /// Block for firewall_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FirewallPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FirewallPolicy block(s) allowed")]
    [TerraformPropertyName("firewall_policy")]
    public TerraformList<TerraformBlock<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock>>? FirewallPolicy { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    [TerraformPropertyName("update_token")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateToken => new TerraformReference(this, "update_token");

}
