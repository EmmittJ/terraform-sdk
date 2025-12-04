using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudcontrolapi_resource Terraform data source.
/// Retrieves information about a aws_cloudcontrolapi_resource.
/// </summary>
public partial class AwsCloudcontrolapiResourceDataSource(string name) : TerraformDataSource("aws_cloudcontrolapi_resource", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformValue<string> Identifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeName is required")]
    public required TerraformValue<string> TypeName
    {
        get => GetRequiredArgument<TerraformValue<string>>("type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// The type_version_id attribute.
    /// </summary>
    public TerraformValue<string>? TypeVersionId
    {
        get => GetArgument<TerraformValue<string>>("type_version_id");
        set => SetArgument("type_version_id", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformValue<string> Properties
        => AsReference("properties");

}
