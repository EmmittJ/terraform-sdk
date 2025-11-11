using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_saml_provider.
/// </summary>
public partial class AwsIamSamlProviderDataSource : TerraformDataSource
{
    public AwsIamSamlProviderDataSource(string name) : base("aws_iam_saml_provider", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformProperty("create_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateDate { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The saml_metadata_document attribute.
    /// </summary>
    [TerraformProperty("saml_metadata_document")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SamlMetadataDocument { get; }

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    [TerraformProperty("valid_until")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ValidUntil { get; }

}
