using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dynamodb_table_item Terraform resource.
/// Manages a aws_dynamodb_table_item resource.
/// </summary>
public partial class AwsDynamodbTableItem(string name) : TerraformResource("aws_dynamodb_table_item", name)
{
    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKey is required")]
    public required TerraformValue<string> HashKey
    {
        get => new TerraformReference<string>(this, "hash_key");
        set => SetArgument("hash_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The item attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Item is required")]
    public required TerraformValue<string> Item
    {
        get => new TerraformReference<string>(this, "item");
        set => SetArgument("item", value);
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public TerraformValue<string>? RangeKey
    {
        get => new TerraformReference<string>(this, "range_key");
        set => SetArgument("range_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => new TerraformReference<string>(this, "table_name");
        set => SetArgument("table_name", value);
    }

}
