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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The athena_properties attribute.
    /// </summary>
    public TerraformMap<string> AthenaProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "athena_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string> CatalogId
    {
        get => new TerraformReference<string>(this, "catalog_id");
    }

    /// <summary>
    /// The connection_properties attribute.
    /// </summary>
    public TerraformMap<string> ConnectionProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "connection_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    public TerraformValue<string> ConnectionType
    {
        get => new TerraformReference<string>(this, "connection_type");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The match_criteria attribute.
    /// </summary>
    public TerraformList<string> MatchCriteria
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "match_criteria").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The physical_connection_requirements attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PhysicalConnectionRequirements
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "physical_connection_requirements").ResolveNodes(ctx));
    }

}
