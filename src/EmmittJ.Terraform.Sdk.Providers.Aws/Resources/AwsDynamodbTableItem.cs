using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dynamodb_table_item resource.
/// </summary>
public class AwsDynamodbTableItem : TerraformResource
{
    public AwsDynamodbTableItem(string name) : base("aws_dynamodb_table_item", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKey is required")]
    public required TerraformProperty<string> HashKey
    {
        get => GetProperty<TerraformProperty<string>>("hash_key");
        set => this.WithProperty("hash_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The item attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Item is required")]
    public required TerraformProperty<string> Item
    {
        get => GetProperty<TerraformProperty<string>>("item");
        set => this.WithProperty("item", value);
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public TerraformProperty<string>? RangeKey
    {
        get => GetProperty<TerraformProperty<string>>("range_key");
        set => this.WithProperty("range_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetProperty<TerraformProperty<string>>("table_name");
        set => this.WithProperty("table_name", value);
    }

}
