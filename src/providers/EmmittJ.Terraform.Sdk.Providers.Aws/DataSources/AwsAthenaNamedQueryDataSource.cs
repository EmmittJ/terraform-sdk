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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
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
    /// The workgroup attribute.
    /// </summary>
    public TerraformValue<string>? Workgroup
    {
        get => new TerraformReference<string>(this, "workgroup");
        set => SetArgument("workgroup", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    public TerraformValue<string> Database
    {
        get => new TerraformReference<string>(this, "database");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The querystring attribute.
    /// </summary>
    public TerraformValue<string> Querystring
    {
        get => new TerraformReference<string>(this, "querystring");
    }

}
