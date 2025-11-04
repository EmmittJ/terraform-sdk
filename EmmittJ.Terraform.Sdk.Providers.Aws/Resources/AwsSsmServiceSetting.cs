using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_service_setting resource.
/// </summary>
public class AwsSsmServiceSetting : TerraformResource
{
    public AwsSsmServiceSetting(string name) : base("aws_ssm_service_setting", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("status");
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
    /// The setting_id attribute.
    /// </summary>
    public string? SettingId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("setting_id")?.Value;
        set => this.WithProperty("setting_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The setting_value attribute.
    /// </summary>
    public string? SettingValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("setting_value")?.Value;
        set => this.WithProperty("setting_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
