using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for statement in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlock : TerraformBlockBase
{
    /// <summary>
    /// The data_identifiers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataIdentifiers is required")]
    [TerraformProperty("data_identifiers")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> DataIdentifiers { get; set; }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    [TerraformProperty("sid")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Sid { get; set; }

}

/// <summary>
/// Retrieves information about a aws_cloudwatch_log_data_protection_policy_document.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudwatchLogDataProtectionPolicyDocumentDataSource : TerraformDataSource
{
    public AwsCloudwatchLogDataProtectionPolicyDocumentDataSource(string name) : base("aws_cloudwatch_log_data_protection_policy_document", name)
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
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    [TerraformProperty("configuration")]
    public partial TerraformList<TerraformBlock<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlock>>? Configuration { get; set; }

    /// <summary>
    /// Block for statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 Statement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 Statement block(s) allowed")]
    [TerraformProperty("statement")]
    public partial TerraformList<TerraformBlock<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlock>>? Statement { get; set; }

    /// <summary>
    /// The json attribute.
    /// </summary>
    [TerraformProperty("json")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Json { get; }

}
