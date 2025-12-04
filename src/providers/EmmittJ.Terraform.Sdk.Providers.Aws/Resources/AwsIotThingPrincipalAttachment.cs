using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iot_thing_principal_attachment Terraform resource.
/// Manages a aws_iot_thing_principal_attachment resource.
/// </summary>
public partial class AwsIotThingPrincipalAttachment(string name) : TerraformResource("aws_iot_thing_principal_attachment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformValue<string> Principal
    {
        get => GetArgument<TerraformValue<string>>("principal");
        set => SetArgument("principal", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The thing attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thing is required")]
    public required TerraformValue<string> Thing
    {
        get => GetArgument<TerraformValue<string>>("thing");
        set => SetArgument("thing", value);
    }

    /// <summary>
    /// The thing_principal_type attribute.
    /// </summary>
    public TerraformValue<string>? ThingPrincipalType
    {
        get => GetArgument<TerraformValue<string>>("thing_principal_type");
        set => SetArgument("thing_principal_type", value);
    }

}
