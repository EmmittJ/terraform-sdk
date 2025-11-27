using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_glue_schema Terraform resource.
/// Manages a aws_glue_schema resource.
/// </summary>
public partial class AwsGlueSchema(string name) : TerraformResource("aws_glue_schema", name)
{
    /// <summary>
    /// The compatibility attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compatibility is required")]
    public required TerraformValue<string> Compatibility
    {
        get => new TerraformReference<string>(this, "compatibility");
        set => SetArgument("compatibility", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFormat is required")]
    public required TerraformValue<string> DataFormat
    {
        get => new TerraformReference<string>(this, "data_format");
        set => SetArgument("data_format", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The registry_arn attribute.
    /// </summary>
    public TerraformValue<string> RegistryArn
    {
        get => new TerraformReference<string>(this, "registry_arn");
        set => SetArgument("registry_arn", value);
    }

    /// <summary>
    /// The schema_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaDefinition is required")]
    public required TerraformValue<string> SchemaDefinition
    {
        get => new TerraformReference<string>(this, "schema_definition");
        set => SetArgument("schema_definition", value);
    }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaName is required")]
    public required TerraformValue<string> SchemaName
    {
        get => new TerraformReference<string>(this, "schema_name");
        set => SetArgument("schema_name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The latest_schema_version attribute.
    /// </summary>
    public TerraformValue<double> LatestSchemaVersion
    {
        get => new TerraformReference<double>(this, "latest_schema_version");
    }

    /// <summary>
    /// The next_schema_version attribute.
    /// </summary>
    public TerraformValue<double> NextSchemaVersion
    {
        get => new TerraformReference<double>(this, "next_schema_version");
    }

    /// <summary>
    /// The registry_name attribute.
    /// </summary>
    public TerraformValue<string> RegistryName
    {
        get => new TerraformReference<string>(this, "registry_name");
    }

    /// <summary>
    /// The schema_checkpoint attribute.
    /// </summary>
    public TerraformValue<double> SchemaCheckpoint
    {
        get => new TerraformReference<double>(this, "schema_checkpoint");
    }

}
