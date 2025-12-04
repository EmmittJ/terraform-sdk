using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_detective_organization_configuration Terraform resource.
/// Manages a aws_detective_organization_configuration resource.
/// </summary>
public partial class AwsDetectiveOrganizationConfiguration(string name) : TerraformResource("aws_detective_organization_configuration", name)
{
    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    public required TerraformValue<bool> AutoEnable
    {
        get => GetArgument<TerraformValue<bool>>("auto_enable");
        set => SetArgument("auto_enable", value);
    }

    /// <summary>
    /// The graph_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GraphArn is required")]
    public required TerraformValue<string> GraphArn
    {
        get => GetArgument<TerraformValue<string>>("graph_arn");
        set => SetArgument("graph_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}
