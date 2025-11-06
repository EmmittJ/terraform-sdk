using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ecs_account_setting_default resource.
/// </summary>
public class AwsEcsAccountSettingDefault : TerraformResource
{
    public AwsEcsAccountSettingDefault(string name) : base("aws_ecs_account_setting_default", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("principal_arn");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The value attribute.
    /// </summary>
    public string? Value
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value")?.Value;
        set => this.WithProperty("value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    public TerraformExpression PrincipalArn => this["principal_arn"];

}
