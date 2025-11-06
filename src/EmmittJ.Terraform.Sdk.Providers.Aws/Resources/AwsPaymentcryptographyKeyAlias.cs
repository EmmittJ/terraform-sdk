using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_paymentcryptography_key_alias resource.
/// </summary>
public class AwsPaymentcryptographyKeyAlias : TerraformResource
{
    public AwsPaymentcryptographyKeyAlias(string name) : base("aws_paymentcryptography_key_alias", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The alias_name attribute.
    /// </summary>
    public string? AliasName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias_name")?.Value;
        set => this.WithProperty("alias_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    public string? KeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_arn")?.Value;
        set => this.WithProperty("key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
