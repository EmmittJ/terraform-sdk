using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dynamodb_table_item.
/// </summary>
public partial class AwsDynamodbTableItemDataSource : TerraformDataSource
{
    public AwsDynamodbTableItemDataSource(string name) : base("aws_dynamodb_table_item", name)
    {
    }

    /// <summary>
    /// The expression_attribute_names attribute.
    /// </summary>
    [TerraformProperty("expression_attribute_names")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ExpressionAttributeNames { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The projection_expression attribute.
    /// </summary>
    [TerraformProperty("projection_expression")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProjectionExpression { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformProperty("table_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TableName { get; set; }

    /// <summary>
    /// The item attribute.
    /// </summary>
    [TerraformProperty("item")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Item { get; }

}
