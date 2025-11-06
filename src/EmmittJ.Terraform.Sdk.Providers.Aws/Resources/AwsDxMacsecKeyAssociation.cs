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
    public string? Cak
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cak")?.Value;
        set => this.WithProperty("cak", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ckn attribute.
    /// </summary>
    public string? Ckn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ckn")?.Value;
        set => this.WithProperty("ckn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    public string? ConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_id")?.Value;
        set => this.WithProperty("connection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The secret_arn attribute.
    /// </summary>
    public string? SecretArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_arn")?.Value;
        set => this.WithProperty("secret_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
