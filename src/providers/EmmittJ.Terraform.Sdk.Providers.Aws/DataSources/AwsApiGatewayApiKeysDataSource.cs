using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_api_keys.
/// </summary>
public class AwsApiGatewayApiKeysDataSource : TerraformDataSource
{
    public AwsApiGatewayApiKeysDataSource(string name) : base("aws_api_gateway_api_keys", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("id");
        this.WithOutput("items");
    }

    /// <summary>
    /// The customer_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerId
    {
        get => GetProperty<TerraformProperty<string>>("customer_id");
        set => this.WithProperty("customer_id", value);
    }

    /// <summary>
    /// The include_values attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeValues
    {
        get => GetProperty<TerraformProperty<bool>>("include_values");
        set => this.WithProperty("include_values", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformExpression Items => this["items"];

}
