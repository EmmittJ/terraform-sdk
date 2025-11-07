using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_macsec_key_association resource.
/// </summary>
public class AwsDxMacsecKeyAssociation : TerraformResource
{
    public AwsDxMacsecKeyAssociation(string name) : base("aws_dx_macsec_key_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("start_on");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The cak attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Cak
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cak");
        set => this.WithProperty("cak", value);
    }

    /// <summary>
    /// The ckn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Ckn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ckn");
        set => this.WithProperty("ckn", value);
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_id");
        set => this.WithProperty("connection_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The secret_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecretArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_arn");
        set => this.WithProperty("secret_arn", value);
    }

    /// <summary>
    /// The start_on attribute.
    /// </summary>
    public TerraformExpression StartOn => this["start_on"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
