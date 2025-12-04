using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_memorydb_user Terraform data source.
/// Retrieves information about a aws_memorydb_user.
/// </summary>
public partial class AwsMemorydbUserDataSource(string name) : TerraformDataSource("aws_memorydb_user", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
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
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => GetArgument<TerraformValue<string>>("user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The access_string attribute.
    /// </summary>
    public TerraformValue<string> AccessString
        => AsReference("access_string");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthenticationMode
        => AsReference("authentication_mode");

    /// <summary>
    /// The minimum_engine_version attribute.
    /// </summary>
    public TerraformValue<string> MinimumEngineVersion
        => AsReference("minimum_engine_version");

}
