using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for saml_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchserverlessSecurityConfigDataSourceSamlOptionsBlock() : TerraformBlock("saml_options")
{




}

/// <summary>
/// Retrieves information about a aws_opensearchserverless_security_config.
/// </summary>
public partial class AwsOpensearchserverlessSecurityConfigDataSource : TerraformDataSource
{
    public AwsOpensearchserverlessSecurityConfigDataSource(string name) : base("aws_opensearchserverless_security_config", name)
    {
    }

    /// <summary>
    /// The unique identifier of the security configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for saml_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("saml_options")]
    public TerraformList<AwsOpensearchserverlessSecurityConfigDataSourceSamlOptionsBlock> SamlOptions { get; set; } = new();

    /// <summary>
    /// The version of the security configuration.
    /// </summary>
    [TerraformProperty("config_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConfigVersion { get; }

    /// <summary>
    /// The date the configuration was created.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The description of the security configuration.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The date the configuration was last modified.
    /// </summary>
    [TerraformProperty("last_modified_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModifiedDate { get; }

    /// <summary>
    /// The type of security configuration.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

}
