using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_location_place_index.
/// </summary>
public partial class AwsLocationPlaceIndexDataSource : TerraformDataSource
{
    public AwsLocationPlaceIndexDataSource(string name) : base("aws_location_place_index", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    [TerraformProperty("index_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IndexName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    [TerraformProperty("data_source")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DataSource { get; }

    /// <summary>
    /// The data_source_configuration attribute.
    /// </summary>
    [TerraformProperty("data_source_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DataSourceConfiguration { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The index_arn attribute.
    /// </summary>
    [TerraformProperty("index_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IndexArn { get; }

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
