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
        SetOutput("start_on");
        SetOutput("state");
        SetOutput("cak");
        SetOutput("ckn");
        SetOutput("connection_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("secret_arn");
    }

    /// <summary>
    /// The cak attribute.
    /// </summary>
    public TerraformProperty<string> Cak
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cak");
        set => SetProperty("cak", value);
    }

    /// <summary>
    /// The ckn attribute.
    /// </summary>
    public TerraformProperty<string> Ckn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ckn");
        set => SetProperty("ckn", value);
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformProperty<string> ConnectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_id");
        set => SetProperty("connection_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformProperty<string> SecretArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secret_arn");
        set => SetProperty("secret_arn", value);
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
