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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The setting_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SettingId is required")]
    public required TerraformProperty<string> SettingId
    {
        get => GetProperty<TerraformProperty<string>>("setting_id");
        set => this.WithProperty("setting_id", value);
    }

    /// <summary>
    /// The setting_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SettingValue is required")]
    public required TerraformProperty<string> SettingValue
    {
        get => GetProperty<TerraformProperty<string>>("setting_value");
        set => this.WithProperty("setting_value", value);
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
