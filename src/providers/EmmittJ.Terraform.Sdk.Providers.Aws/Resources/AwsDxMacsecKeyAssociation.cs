using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dx_macsec_key_association Terraform resource.
/// Manages a aws_dx_macsec_key_association resource.
/// </summary>
public partial class AwsDxMacsecKeyAssociation(string name) : TerraformResource("aws_dx_macsec_key_association", name)
{
    /// <summary>
    /// The cak attribute.
    /// </summary>
    public TerraformValue<string>? Cak
    {
        get => GetArgument<TerraformValue<string>>("cak");
        set => SetArgument("cak", value);
    }

    /// <summary>
    /// The ckn attribute.
    /// </summary>
    public TerraformValue<string> Ckn
    {
        get => GetArgument<TerraformValue<string>>("ckn") ?? CreateReference("ckn");
        set => SetArgument("ckn", value);
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformValue<string> ConnectionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("connection_id");
        set => SetArgument("connection_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformValue<string> SecretArn
    {
        get => GetArgument<TerraformValue<string>>("secret_arn") ?? CreateReference("secret_arn");
        set => SetArgument("secret_arn", value);
    }

    /// <summary>
    /// The start_on attribute.
    /// </summary>
    public TerraformValue<string> StartOn
        => CreateReference("start_on");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

}
