using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for saml_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchserverlessSecurityConfigSamlOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// Group attribute for this SAML integration.
    /// </summary>
    [TerraformProperty("group_attribute")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GroupAttribute { get; set; }

    /// <summary>
    /// The XML IdP metadata file generated from your identity provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metadata is required")]
    [TerraformProperty("metadata")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Metadata { get; set; }

    /// <summary>
    /// Session timeout, in minutes. Minimum is 5 minutes and maximum is 720 minutes (12 hours). Default is 60 minutes.
    /// </summary>
    [TerraformProperty("session_timeout")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> SessionTimeout { get; set; }

    /// <summary>
    /// User attribute for this SAML integration.
    /// </summary>
    [TerraformProperty("user_attribute")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserAttribute { get; set; }

}

/// <summary>
/// Manages a aws_opensearchserverless_security_config resource.
/// </summary>
public partial class AwsOpensearchserverlessSecurityConfig : TerraformResource
{
    public AwsOpensearchserverlessSecurityConfig(string name) : base("aws_opensearchserverless_security_config", name)
    {
    }

    /// <summary>
    /// Description of the security configuration.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Name of the policy.
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
    /// Type of configuration. Must be `saml`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for saml_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("saml_options")]
    public partial TerraformList<TerraformBlock<AwsOpensearchserverlessSecurityConfigSamlOptionsBlock>>? SamlOptions { get; set; }

    /// <summary>
    /// Version of the configuration.
    /// </summary>
    [TerraformProperty("config_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConfigVersion { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
