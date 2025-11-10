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
        SetOutput("hash_key");
        SetOutput("id");
        SetOutput("item");
        SetOutput("range_key");
        SetOutput("region");
        SetOutput("table_name");
    }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKey is required")]
    public required TerraformProperty<string> HashKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hash_key");
        set => SetProperty("hash_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The item attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Item is required")]
    public required TerraformProperty<string> Item
    {
        get => GetRequiredOutput<TerraformProperty<string>>("item");
        set => SetProperty("item", value);
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public TerraformProperty<string> RangeKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("range_key");
        set => SetProperty("range_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_name");
        set => SetProperty("table_name", value);
    }

}
