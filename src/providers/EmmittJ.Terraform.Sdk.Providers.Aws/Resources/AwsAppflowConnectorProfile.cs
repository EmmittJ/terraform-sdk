using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connector_profile_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppflowConnectorProfileConnectorProfileConfigBlock() : TerraformBlock("connector_profile_config")
{
}

/// <summary>
/// Manages a aws_appflow_connector_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAppflowConnectorProfile : TerraformResource
{
    public AwsAppflowConnectorProfile(string name) : base("aws_appflow_connector_profile", name)
    {
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionMode is required")]
    [TerraformProperty("connection_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectionMode { get; set; }

    /// <summary>
    /// The connector_label attribute.
    /// </summary>
    [TerraformProperty("connector_label")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectorLabel { get; set; }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    [TerraformProperty("connector_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectorType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_arn attribute.
    /// </summary>
    [TerraformProperty("kms_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsArn { get; set; }

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
    /// Block for connector_profile_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorProfileConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectorProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectorProfileConfig block(s) allowed")]
    [TerraformProperty("connector_profile_config")]
    public required TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlock> ConnectorProfileConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The credentials_arn attribute.
    /// </summary>
    [TerraformProperty("credentials_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CredentialsArn { get; }

}
