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
        this.WithOutput("start_on");
        this.WithOutput("state");
    }

    /// <summary>
    /// The cak attribute.
    /// </summary>
    public TerraformProperty<string>? Cak
    {
        get => GetProperty<TerraformProperty<string>>("cak");
        set => this.WithProperty("cak", value);
    }

    /// <summary>
    /// The ckn attribute.
    /// </summary>
    public TerraformProperty<string>? Ckn
    {
        get => GetProperty<TerraformProperty<string>>("ckn");
        set => this.WithProperty("ckn", value);
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformProperty<string> ConnectionId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connection_id");
        set => this.WithProperty("connection_id", value);
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
    /// The secret_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SecretArn
    {
        get => GetProperty<TerraformProperty<string>>("secret_arn");
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
