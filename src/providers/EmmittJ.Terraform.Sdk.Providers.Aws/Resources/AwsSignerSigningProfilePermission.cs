using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_signer_signing_profile_permission Terraform resource.
/// Manages a aws_signer_signing_profile_permission resource.
/// </summary>
public partial class AwsSignerSigningProfilePermission(string name) : TerraformResource("aws_signer_signing_profile_permission", name)
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformValue<string> Principal
    {
        get => new TerraformReference<string>(this, "principal");
        set => SetArgument("principal", value);
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    public required TerraformValue<string> ProfileName
    {
        get => new TerraformReference<string>(this, "profile_name");
        set => SetArgument("profile_name", value);
    }

    /// <summary>
    /// The profile_version attribute.
    /// </summary>
    public TerraformValue<string> ProfileVersion
    {
        get => new TerraformReference<string>(this, "profile_version");
        set => SetArgument("profile_version", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    public TerraformValue<string> StatementId
    {
        get => new TerraformReference<string>(this, "statement_id");
        set => SetArgument("statement_id", value);
    }

    /// <summary>
    /// The statement_id_prefix attribute.
    /// </summary>
    public TerraformValue<string> StatementIdPrefix
    {
        get => new TerraformReference<string>(this, "statement_id_prefix");
        set => SetArgument("statement_id_prefix", value);
    }

}
