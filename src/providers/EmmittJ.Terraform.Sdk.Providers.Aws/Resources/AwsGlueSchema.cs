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
        get => GetRequiredArgument<TerraformValue<string>>("compatibility");
        set => SetArgument("compatibility", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFormat is required")]
    public required TerraformValue<string> DataFormat
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_format");
        set => SetArgument("data_format", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    /// The registry_arn attribute.
    /// </summary>
    public TerraformValue<string> RegistryArn
    {
        get => GetArgument<TerraformValue<string>>("registry_arn") ?? AsReference("registry_arn");
        set => SetArgument("registry_arn", value);
    }

    /// <summary>
    /// The schema_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaDefinition is required")]
    public required TerraformValue<string> SchemaDefinition
    {
        get => GetRequiredArgument<TerraformValue<string>>("schema_definition");
        set => SetArgument("schema_definition", value);
    }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaName is required")]
    public required TerraformValue<string> SchemaName
    {
        get => GetRequiredArgument<TerraformValue<string>>("schema_name");
        set => SetArgument("schema_name", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The latest_schema_version attribute.
    /// </summary>
    public TerraformValue<double> LatestSchemaVersion
        => AsReference("latest_schema_version");

    /// <summary>
    /// The next_schema_version attribute.
    /// </summary>
    public TerraformValue<double> NextSchemaVersion
        => AsReference("next_schema_version");

    /// <summary>
    /// The registry_name attribute.
    /// </summary>
    public TerraformValue<string> RegistryName
        => AsReference("registry_name");

    /// <summary>
    /// The schema_checkpoint attribute.
    /// </summary>
    public TerraformValue<double> SchemaCheckpoint
        => AsReference("schema_checkpoint");

}
