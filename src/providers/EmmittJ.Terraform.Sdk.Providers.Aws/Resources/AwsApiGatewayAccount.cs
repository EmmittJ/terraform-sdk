using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_account Terraform resource.
/// Manages a aws_api_gateway_account resource.
/// </summary>
public partial class AwsApiGatewayAccount(string name) : TerraformResource("aws_api_gateway_account", name)
{
    /// <summary>
    /// The cloudwatch_role_arn attribute.
    /// </summary>
    public TerraformValue<string> CloudwatchRoleArn
    {
        get => new TerraformReference<string>(this, "cloudwatch_role_arn");
        set => SetArgument("cloudwatch_role_arn", value);
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
    /// The api_key_version attribute.
    /// </summary>
    public TerraformValue<string> ApiKeyVersion
    {
        get => new TerraformReference<string>(this, "api_key_version");
    }

    /// <summary>
    /// The features attribute.
    /// </summary>
    public TerraformSet<string> Features
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "features").ResolveNodes(ctx));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The throttle_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ThrottleSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "throttle_settings").ResolveNodes(ctx));
    }

}
