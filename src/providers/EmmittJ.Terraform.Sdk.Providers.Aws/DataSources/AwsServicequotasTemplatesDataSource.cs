using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_servicequotas_templates.
/// </summary>
public partial class AwsServicequotasTemplatesDataSource : TerraformDataSource
{
    public AwsServicequotasTemplatesDataSource(string name) : base("aws_servicequotas_templates", name)
    {
    }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    [TerraformProperty("aws_region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AwsRegion { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The templates attribute.
    /// </summary>
    [TerraformProperty("templates")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Templates { get; }

}
