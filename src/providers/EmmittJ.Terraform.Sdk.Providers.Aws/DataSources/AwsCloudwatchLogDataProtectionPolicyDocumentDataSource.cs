using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for statement in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlock : ITerraformBlock
{
    /// <summary>
    /// The data_identifiers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataIdentifiers is required")]
    [TerraformPropertyName("data_identifiers")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DataIdentifiers { get; set; }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    [TerraformPropertyName("sid")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Sid { get; set; }

}

/// <summary>
/// Retrieves information about a aws_cloudwatch_log_data_protection_policy_document.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSource : TerraformDataSource
{
    public AwsCloudwatchLogDataProtectionPolicyDocumentDataSource(string name) : base("aws_cloudwatch_log_data_protection_policy_document", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    [TerraformPropertyName("configuration")]
    public TerraformList<TerraformBlock<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlock>>? Configuration { get; set; } = new();

    /// <summary>
    /// Block for statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 Statement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 Statement block(s) allowed")]
    [TerraformPropertyName("statement")]
    public TerraformList<TerraformBlock<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlock>>? Statement { get; set; } = new();

    /// <summary>
    /// The json attribute.
    /// </summary>
    [TerraformPropertyName("json")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Json => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "json");

}
