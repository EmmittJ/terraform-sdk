using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_athena_named_query Terraform data source.
/// Retrieves information about a aws_athena_named_query.
/// </summary>
public partial class AwsAthenaNamedQueryDataSource(string name) : TerraformDataSource("aws_athena_named_query", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The workgroup attribute.
    /// </summary>
    public TerraformValue<string>? Workgroup
    {
        get => GetArgument<TerraformValue<string>>("workgroup");
        set => SetArgument("workgroup", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    public TerraformValue<string> Database
        => AsReference("database");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The querystring attribute.
    /// </summary>
    public TerraformValue<string> Querystring
        => AsReference("querystring");

}
