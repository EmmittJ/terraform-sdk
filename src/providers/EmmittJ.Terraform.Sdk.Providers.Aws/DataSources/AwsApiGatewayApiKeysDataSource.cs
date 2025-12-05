using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_api_keys Terraform data source.
/// Retrieves information about a aws_api_gateway_api_keys.
/// </summary>
public partial class AwsApiGatewayApiKeysDataSource(string name) : TerraformDataSource("aws_api_gateway_api_keys", name)
{
    /// <summary>
    /// The customer_id attribute.
    /// </summary>
    public TerraformValue<string>? CustomerId
    {
        get => GetArgument<TerraformValue<string>>("customer_id");
        set => SetArgument("customer_id", value);
    }

    /// <summary>
    /// The include_values attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeValues
    {
        get => GetArgument<TerraformValue<bool>>("include_values");
        set => SetArgument("include_values", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Items
        => CreateReference("items");

}
