using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_usage_plan_key Terraform resource.
/// Manages a aws_api_gateway_usage_plan_key resource.
/// </summary>
public partial class AwsApiGatewayUsagePlanKey(string name) : TerraformResource("aws_api_gateway_usage_plan_key", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => new TerraformReference<string>(this, "key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyType is required")]
    public required TerraformValue<string> KeyType
    {
        get => new TerraformReference<string>(this, "key_type");
        set => SetArgument("key_type", value);
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
    /// The usage_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsagePlanId is required")]
    public required TerraformValue<string> UsagePlanId
    {
        get => new TerraformReference<string>(this, "usage_plan_id");
        set => SetArgument("usage_plan_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
    }

}
