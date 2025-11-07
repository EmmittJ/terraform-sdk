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
    public TerraformLiteralProperty<string>? AliasName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias_name");
        set => this.WithProperty("alias_name", value);
    }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_arn");
        set => this.WithProperty("key_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
