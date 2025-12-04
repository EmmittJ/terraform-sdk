using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsMacie2CustomDataIdentifier.
/// Nesting mode: single
/// </summary>
public class AwsMacie2CustomDataIdentifierTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_macie2_custom_data_identifier Terraform resource.
/// Manages a aws_macie2_custom_data_identifier resource.
/// </summary>
public partial class AwsMacie2CustomDataIdentifier(string name) : TerraformResource("aws_macie2_custom_data_identifier", name)
{
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ignore_words attribute.
    /// </summary>
    public TerraformSet<string>? IgnoreWords
    {
        get => GetArgument<TerraformSet<string>>("ignore_words");
        set => SetArgument("ignore_words", value);
    }

    /// <summary>
    /// The keywords attribute.
    /// </summary>
    public TerraformSet<string>? Keywords
    {
        get => GetArgument<TerraformSet<string>>("keywords");
        set => SetArgument("keywords", value);
    }

    /// <summary>
    /// The maximum_match_distance attribute.
    /// </summary>
    public TerraformValue<double>? MaximumMatchDistance
    {
        get => GetArgument<TerraformValue<double>>("maximum_match_distance");
        set => SetArgument("maximum_match_distance", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The regex attribute.
    /// </summary>
    public TerraformValue<string>? Regex
    {
        get => GetArgument<TerraformValue<string>>("regex");
        set => SetArgument("regex", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMacie2CustomDataIdentifierTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMacie2CustomDataIdentifierTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
