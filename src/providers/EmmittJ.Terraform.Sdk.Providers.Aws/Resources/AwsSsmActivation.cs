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
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string> ExpirationDate
    {
        get => GetArgument<TerraformValue<string>>("expiration_date") ?? CreateReference("expiration_date");
        set => SetArgument("expiration_date", value);
    }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRole is required")]
    public required TerraformValue<string> IamRole
    {
        get => GetRequiredArgument<TerraformValue<string>>("iam_role");
        set => SetArgument("iam_role", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The registration_limit attribute.
    /// </summary>
    public TerraformValue<double>? RegistrationLimit
    {
        get => GetArgument<TerraformValue<double>>("registration_limit");
        set => SetArgument("registration_limit", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The activation_code attribute.
    /// </summary>
    public TerraformValue<string> ActivationCode
        => CreateReference("activation_code");

    /// <summary>
    /// The expired attribute.
    /// </summary>
    public TerraformValue<bool> Expired
        => CreateReference("expired");

    /// <summary>
    /// The registration_count attribute.
    /// </summary>
    public TerraformValue<double> RegistrationCount
        => CreateReference("registration_count");

}
