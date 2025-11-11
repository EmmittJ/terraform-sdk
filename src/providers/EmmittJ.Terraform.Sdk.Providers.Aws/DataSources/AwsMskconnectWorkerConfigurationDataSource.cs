using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_mskconnect_worker_configuration.
/// </summary>
public class AwsMskconnectWorkerConfigurationDataSource : TerraformDataSource
{
    public AwsMskconnectWorkerConfigurationDataSource(string name) : base("aws_mskconnect_worker_configuration", name)
    {
    }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The latest_revision attribute.
    /// </summary>
    [TerraformPropertyName("latest_revision")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> LatestRevision => new TerraformReference(this, "latest_revision");

    /// <summary>
    /// The properties_file_content attribute.
    /// </summary>
    [TerraformPropertyName("properties_file_content")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PropertiesFileContent => new TerraformReference(this, "properties_file_content");

}
