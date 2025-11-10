using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for saml_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchserverlessSecurityConfigDataSourceSamlOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// Group attribute for this SAML integration.
    /// </summary>
    [TerraformPropertyName("group_attribute")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GroupAttribute => new TerraformReferenceProperty<TerraformProperty<string>>("", "group_attribute");

    /// <summary>
    /// The XML IdP metadata file generated from your identity provider.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Metadata => new TerraformReferenceProperty<TerraformProperty<string>>("", "metadata");

    /// <summary>
    /// Session timeout, in minutes. Minimum is 5 minutes and maximum is 720 minutes (12 hours). Default is 60 minutes.
    /// </summary>
    [TerraformPropertyName("session_timeout")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SessionTimeout => new TerraformReferenceProperty<TerraformProperty<double>>("", "session_timeout");

    /// <summary>
    /// User attribute for this SAML integration.
    /// </summary>
    [TerraformPropertyName("user_attribute")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserAttribute => new TerraformReferenceProperty<TerraformProperty<string>>("", "user_attribute");

}

/// <summary>
/// Retrieves information about a aws_opensearchserverless_security_config.
/// </summary>
public class AwsOpensearchserverlessSecurityConfigDataSource : TerraformDataSource
{
    public AwsOpensearchserverlessSecurityConfigDataSource(string name) : base("aws_opensearchserverless_security_config", name)
    {
    }

    /// <summary>
    /// The unique identifier of the security configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for saml_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("saml_options")]
    public TerraformList<TerraformBlock<AwsOpensearchserverlessSecurityConfigDataSourceSamlOptionsBlock>>? SamlOptions { get; set; } = new();

    /// <summary>
    /// The version of the security configuration.
    /// </summary>
    [TerraformPropertyName("config_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "config_version");

    /// <summary>
    /// The date the configuration was created.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_date");

    /// <summary>
    /// The description of the security configuration.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The date the configuration was last modified.
    /// </summary>
    [TerraformPropertyName("last_modified_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_date");

    /// <summary>
    /// The type of security configuration.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
