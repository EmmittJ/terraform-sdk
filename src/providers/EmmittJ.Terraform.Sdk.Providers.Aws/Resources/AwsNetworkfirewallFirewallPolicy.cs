using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkfirewallFirewallPolicyEncryptionConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [TerraformProperty("key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyId { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for firewall_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The stateful_default_actions attribute.
    /// </summary>
    [TerraformProperty("stateful_default_actions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? StatefulDefaultActions { get; set; }

    /// <summary>
    /// The stateless_default_actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatelessDefaultActions is required")]
    [TerraformProperty("stateless_default_actions")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> StatelessDefaultActions { get; set; }

    /// <summary>
    /// The stateless_fragment_default_actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatelessFragmentDefaultActions is required")]
    [TerraformProperty("stateless_fragment_default_actions")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> StatelessFragmentDefaultActions { get; set; }

    /// <summary>
    /// The tls_inspection_configuration_arn attribute.
    /// </summary>
    [TerraformProperty("tls_inspection_configuration_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TlsInspectionConfigurationArn { get; set; }

}

/// <summary>
/// Manages a aws_networkfirewall_firewall_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsNetworkfirewallFirewallPolicy : TerraformResource
{
    public AwsNetworkfirewallFirewallPolicy(string name) : base("aws_networkfirewall_firewall_policy", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    [TerraformProperty("encryption_configuration")]
    public partial TerraformList<TerraformBlock<AwsNetworkfirewallFirewallPolicyEncryptionConfigurationBlock>>? EncryptionConfiguration { get; set; }

    /// <summary>
    /// Block for firewall_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FirewallPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FirewallPolicy block(s) allowed")]
    [TerraformProperty("firewall_policy")]
    public partial TerraformList<TerraformBlock<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock>>? FirewallPolicy { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    [TerraformProperty("update_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateToken { get; }

}
