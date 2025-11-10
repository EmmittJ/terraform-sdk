using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for trusted_token_issuer_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_ssoadmin_trusted_token_issuer resource.
/// </summary>
public class AwsSsoadminTrustedTokenIssuer : TerraformResource
{
    public AwsSsoadminTrustedTokenIssuer(string name) : base("aws_ssoadmin_trusted_token_issuer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    public TerraformProperty<string>? ClientToken
    {
        get => GetProperty<TerraformProperty<string>>("client_token");
        set => this.WithProperty("client_token", value);
    }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformProperty<string> InstanceArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_arn");
        set => this.WithProperty("instance_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The trusted_token_issuer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustedTokenIssuerType is required")]
    public required TerraformProperty<string> TrustedTokenIssuerType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("trusted_token_issuer_type");
        set => this.WithProperty("trusted_token_issuer_type", value);
    }

    /// <summary>
    /// Block for trusted_token_issuer_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationBlock>? TrustedTokenIssuerConfiguration
    {
        get => GetProperty<List<AwsSsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationBlock>>("trusted_token_issuer_configuration");
        set => this.WithProperty("trusted_token_issuer_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
