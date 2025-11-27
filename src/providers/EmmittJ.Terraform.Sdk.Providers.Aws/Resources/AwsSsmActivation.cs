using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssm_activation Terraform resource.
/// Manages a aws_ssm_activation resource.
/// </summary>
public partial class AwsSsmActivation(string name) : TerraformResource("aws_ssm_activation", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string> ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
        set => SetArgument("expiration_date", value);
    }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRole is required")]
    public required TerraformValue<string> IamRole
    {
        get => new TerraformReference<string>(this, "iam_role");
        set => SetArgument("iam_role", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The registration_limit attribute.
    /// </summary>
    public TerraformValue<double>? RegistrationLimit
    {
        get => new TerraformReference<double>(this, "registration_limit");
        set => SetArgument("registration_limit", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The activation_code attribute.
    /// </summary>
    public TerraformValue<string> ActivationCode
    {
        get => new TerraformReference<string>(this, "activation_code");
    }

    /// <summary>
    /// The expired attribute.
    /// </summary>
    public TerraformValue<bool> Expired
    {
        get => new TerraformReference<bool>(this, "expired");
    }

    /// <summary>
    /// The registration_count attribute.
    /// </summary>
    public TerraformValue<double> RegistrationCount
    {
        get => new TerraformReference<double>(this, "registration_count");
    }

}
