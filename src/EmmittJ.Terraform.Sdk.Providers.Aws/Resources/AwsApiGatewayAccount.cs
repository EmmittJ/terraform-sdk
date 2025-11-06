using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_account resource.
/// </summary>
public class AwsApiGatewayAccount : TerraformResource
{
    public AwsApiGatewayAccount(string name) : base("aws_api_gateway_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("api_key_version");
        this.DeclareOutput("features");
        this.DeclareOutput("id");
        this.DeclareOutput("throttle_settings");
    }

    /// <summary>
    /// The cloudwatch_role_arn attribute.
    /// </summary>
    public string? CloudwatchRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloudwatch_role_arn")?.Value;
        set => this.WithProperty("cloudwatch_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The api_key_version attribute.
    /// </summary>
    public TerraformExpression ApiKeyVersion => this["api_key_version"];

    /// <summary>
    /// The features attribute.
    /// </summary>
    public TerraformExpression Features => this["features"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The throttle_settings attribute.
    /// </summary>
    public TerraformExpression ThrottleSettings => this["throttle_settings"];

}
