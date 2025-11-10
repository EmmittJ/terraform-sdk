using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connector_profile_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_appflow_connector_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppflowConnectorProfile : TerraformResource
{
    public AwsAppflowConnectorProfile(string name) : base("aws_appflow_connector_profile", name)
    {
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionMode is required")]
    [TerraformPropertyName("connection_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectionMode { get; set; }

    /// <summary>
    /// The connector_label attribute.
    /// </summary>
    [TerraformPropertyName("connector_label")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConnectorLabel { get; set; }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    [TerraformPropertyName("connector_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectorType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_arn");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for connector_profile_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorProfileConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectorProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectorProfileConfig block(s) allowed")]
    [TerraformPropertyName("connector_profile_config")]
    public TerraformList<TerraformBlock<AwsAppflowConnectorProfileConnectorProfileConfigBlock>>? ConnectorProfileConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The credentials_arn attribute.
    /// </summary>
    [TerraformPropertyName("credentials_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CredentialsArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "credentials_arn");

}
