using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_parameter ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class AwsSsmParameterEphemeralResource : TerraformEphemeralResource
{
    public AwsSsmParameterEphemeralResource(string name) : base("aws_ssm_parameter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
        this.WithOutput("type");
        this.WithOutput("value");
        this.WithOutput("version");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
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
    /// The with_decryption attribute.
    /// </summary>
    public TerraformProperty<bool>? WithDecryption
    {
        get => GetProperty<TerraformProperty<bool>>("with_decryption");
        set => this.WithProperty("with_decryption", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformExpression Value => this["value"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
