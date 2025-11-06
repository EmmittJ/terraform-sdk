using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_pinpoint_baidu_channel resource.
/// </summary>
public class AwsPinpointBaiduChannel : TerraformResource
{
    public AwsPinpointBaiduChannel(string name) : base("aws_pinpoint_baidu_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public string? ApiKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_key")?.Value;
        set => this.WithProperty("api_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The secret_key attribute.
    /// </summary>
    public string? SecretKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_key")?.Value;
        set => this.WithProperty("secret_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
