using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_glue_connection Terraform data source.
/// Retrieves information about a aws_glue_connection.
/// </summary>
public partial class AwsGlueConnectionDataSource(string name) : TerraformDataSource("aws_glue_connection", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The athena_properties attribute.
    /// </summary>
    public TerraformMap<string> AthenaProperties
        => CreateReference("athena_properties");

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string> CatalogId
        => CreateReference("catalog_id");

    /// <summary>
    /// The connection_properties attribute.
    /// </summary>
    public TerraformMap<string> ConnectionProperties
        => CreateReference("connection_properties");

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    public TerraformValue<string> ConnectionType
        => CreateReference("connection_type");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The match_criteria attribute.
    /// </summary>
    public TerraformList<string> MatchCriteria
        => CreateReference("match_criteria");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The physical_connection_requirements attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PhysicalConnectionRequirements
        => CreateReference("physical_connection_requirements");

}
