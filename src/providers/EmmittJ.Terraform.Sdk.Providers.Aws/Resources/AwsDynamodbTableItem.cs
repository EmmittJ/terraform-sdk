using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dynamodb_table_item resource.
/// </summary>
public partial class AwsDynamodbTableItem : TerraformResource
{
    public AwsDynamodbTableItem(string name) : base("aws_dynamodb_table_item", name)
    {
    }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKey is required")]
    [TerraformProperty("hash_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HashKey { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The item attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Item is required")]
    [TerraformProperty("item")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Item { get; set; }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [TerraformProperty("range_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RangeKey { get; set; }

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

}
