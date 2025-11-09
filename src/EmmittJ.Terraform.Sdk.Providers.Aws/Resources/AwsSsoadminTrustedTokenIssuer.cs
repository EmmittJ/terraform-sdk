using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public TerraformProperty<string>? InstanceArn
    {
        get => GetProperty<TerraformProperty<string>>("instance_arn");
        set => this.WithProperty("instance_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The trusted_token_issuer_type attribute.
    /// </summary>
    public TerraformProperty<string>? TrustedTokenIssuerType
    {
        get => GetProperty<TerraformProperty<string>>("trusted_token_issuer_type");
        set => this.WithProperty("trusted_token_issuer_type", value);
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
